using MySql.Data.MySqlClient;
using System.Globalization;

namespace Eco_Matic_Winforms.Data
{
    public partial class MySqlStore
    {
        private readonly string _connectionString = ResolveConnectionString();

        private static string ResolveConnectionString()
        {
            string? explicitConnectionString = Environment.GetEnvironmentVariable("ECOMATIC_DB_CONNECTION_STRING");
            if (!string.IsNullOrWhiteSpace(explicitConnectionString))
            {
                return explicitConnectionString;
            }

            string host = GetEnv("ECOMATIC_DB_HOST", "127.0.0.1");
            uint port = ParsePort(GetEnv("ECOMATIC_DB_PORT", "3306"));
            string database = GetEnv("ECOMATIC_DB_NAME", "ecomatic_winforms_db");
            string user = GetEnv("ECOMATIC_DB_USER", "root");
            string password = GetEnv("ECOMATIC_DB_PASSWORD", "admin123");

            var builder = new MySqlConnectionStringBuilder
            {
                Server = host,
                Port = port,
                Database = database,
                UserID = user,
                Password = password,
                SslMode = MySqlSslMode.Disabled
            };

            return builder.ConnectionString;
        }

        private static uint ParsePort(string value)
        {
            return uint.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out uint port)
                ? port
                : 3306u;
        }

        private static string GetEnv(string key, string fallback)
        {
            string? value = Environment.GetEnvironmentVariable(key);
            return string.IsNullOrWhiteSpace(value) ? fallback : value;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }

        public void EnsureDatabaseReady(IEnumerable<Product>? seedProducts = null)
        {
            var builder = new MySqlConnectionStringBuilder(_connectionString);
            string databaseName = builder.Database;

            builder.Database = string.Empty;
            using (var serverConn = new MySqlConnection(builder.ConnectionString))
            {
                serverConn.Open();
                using var createDbCmd = new MySqlCommand($"CREATE DATABASE IF NOT EXISTS `{databaseName}`;", serverConn);
                createDbCmd.ExecuteNonQuery();
            }

            using (var conn = GetConnection())
            {
                conn.Open();
                CreateTables(conn);
            }

            if (seedProducts != null)
            {
                SeedInventoryIfEmpty(seedProducts);
            }
        }

        public List<Product> LoadInventory(IEnumerable<Product> fallback)
        {
            EnsureDatabaseReady(fallback);

            using var conn = GetConnection();
            conn.Open();

            var products = new List<Product>();
            const string query = @"
                SELECT inventory_id, slot_id, type, name, price, stock, flavor_text, calories, volume_ml, image_path
                FROM inventory_items
                ORDER BY slot_id";

            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int slotId = reader.GetInt32("slot_id");
                ProductType type = ParseProductType(reader.GetString("type"));
                decimal price = reader.GetDecimal("price");
                int stock = Math.Clamp(reader.GetInt32("stock"), 0, DataStore.MaxStockPerItem);
                string flavorText = reader.GetString("flavor_text");
                int calories = reader.GetInt32("calories");
                int volumeMl = reader.GetInt32("volume_ml");
                string imagePath = reader.IsDBNull(reader.GetOrdinal("image_path"))
                    ? string.Empty
                    : reader.GetString("image_path");

                var product = Product.Create(type, slotId, reader.GetString("name"), price, stock, flavorText, calories, volumeMl, imagePath);
                product.DbInventoryId = reader.GetInt32("inventory_id");
                products.Add(product);
            }

            return products
                .OrderBy(p => p.Id)
                .Take(DataStore.MaxItemSlots)
                .ToList();
        }

        public void SaveInventory(IEnumerable<Product> products)
        {
            EnsureDatabaseReady();

            var productList = products
                .OrderBy(p => p.Id)
                .Take(DataStore.MaxItemSlots)
                .ToList();

            using var conn = GetConnection();
            conn.Open();
            using var tx = conn.BeginTransaction();

            var existingBySlot = new Dictionary<int, int>();
            using (var loadCmd = new MySqlCommand("SELECT inventory_id, slot_id FROM inventory_items", conn, tx))
            using (var reader = loadCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    existingBySlot[reader.GetInt32("slot_id")] = reader.GetInt32("inventory_id");
                }
            }

            foreach (var product in productList)
            {
                int calories = product is IHasCalories hasCalories ? hasCalories.Calories : 0;
                int volumeMl = product is IHasVolume hasVolume ? hasVolume.VolumeMl : 0;
                int clampedStock = Math.Clamp(product.Stock, 0, DataStore.MaxStockPerItem);

                if (existingBySlot.TryGetValue(product.Id, out int inventoryId))
                {
                    const string updateSql = @"
                        UPDATE inventory_items
                        SET type = @type,
                            name = @name,
                            price = @price,
                            stock = @stock,
                            flavor_text = @flavorText,
                            calories = @calories,
                            volume_ml = @volumeMl,
                            image_path = @imagePath
                        WHERE slot_id = @slotId";

                    using var updateCmd = new MySqlCommand(updateSql, conn, tx);
                    AddInventoryParameters(updateCmd, product, clampedStock, calories, volumeMl);
                    updateCmd.ExecuteNonQuery();
                    product.DbInventoryId = inventoryId;
                }
                else
                {
                    const string insertSql = @"
                        INSERT INTO inventory_items
                            (slot_id, type, name, price, stock, flavor_text, calories, volume_ml, image_path)
                        VALUES
                            (@slotId, @type, @name, @price, @stock, @flavorText, @calories, @volumeMl, @imagePath)";

                    using var insertCmd = new MySqlCommand(insertSql, conn, tx);
                    AddInventoryParameters(insertCmd, product, clampedStock, calories, volumeMl);
                    insertCmd.ExecuteNonQuery();
                    product.DbInventoryId = (int)insertCmd.LastInsertedId;
                }
            }

            DeleteRemovedSlots(conn, tx, productList.Select(p => p.Id).ToList());
            tx.Commit();
        }

        public void RecordSale(int inventoryId, int slotId, string itemName, decimal amountPaid, int quantity = 1)
        {
            EnsureDatabaseReady();
            using var conn = GetConnection();
            conn.Open();

            const string sql = @"
                INSERT INTO sales_transactions (inventory_id, slot_id, item_name, quantity, amount_paid)
                VALUES (@inventoryId, @slotId, @itemName, @quantity, @amountPaid)";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@inventoryId", inventoryId > 0 ? inventoryId : DBNull.Value);
            cmd.Parameters.AddWithValue("@slotId", slotId);
            cmd.Parameters.AddWithValue("@itemName", itemName);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@amountPaid", amountPaid);
            cmd.ExecuteNonQuery();
        }

        public void LogEvent(string eventType, string details, decimal amount = 0m)
        {
            EnsureDatabaseReady();
            using var conn = GetConnection();
            conn.Open();

            const string sql = @"
                INSERT INTO event_logs (timestamp_utc, event_type, details, amount)
                VALUES (@timestampUtc, @eventType, @details, @amount)";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@timestampUtc", DateTime.UtcNow);
            cmd.Parameters.AddWithValue("@eventType", eventType);
            cmd.Parameters.AddWithValue("@details", details);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.ExecuteNonQuery();
        }

        public List<EventLogEntry> GetEventLogs()
        {
            EnsureDatabaseReady();
            using var conn = GetConnection();
            conn.Open();

            var logs = new List<EventLogEntry>();
            const string sql = @"
                SELECT timestamp_utc, event_type, details, amount
                FROM event_logs
                ORDER BY timestamp_utc DESC
                LIMIT 500";

            using var cmd = new MySqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                logs.Add(new EventLogEntry
                {
                    TimestampUtc = DateTime.SpecifyKind(reader.GetDateTime("timestamp_utc"), DateTimeKind.Utc),
                    EventType = reader.GetString("event_type"),
                    Details = reader.GetString("details"),
                    Amount = reader.GetDecimal("amount")
                });
            }

            return logs;
        }

        public void ClearEventLogs()
        {
            EnsureDatabaseReady();
            using var conn = GetConnection();
            conn.Open();
            using var cmd = new MySqlCommand("DELETE FROM event_logs", conn);
            cmd.ExecuteNonQuery();
        }

        private static ProductType ParseProductType(string value)
        {
            if (Enum.TryParse<ProductType>(value, true, out var parsed))
            {
                return parsed;
            }

            return ProductType.Misc;
        }

        private void SeedInventoryIfEmpty(IEnumerable<Product> defaultProducts)
        {
            using var conn = GetConnection();
            conn.Open();

            using var countCmd = new MySqlCommand("SELECT COUNT(*) FROM inventory_items", conn);
            int count = Convert.ToInt32(countCmd.ExecuteScalar(), CultureInfo.InvariantCulture);
            if (count > 0)
            {
                return;
            }

            SaveInventory(defaultProducts);
        }

        private static void AddInventoryParameters(MySqlCommand cmd, Product product, int clampedStock, int calories, int volumeMl)
        {
            cmd.Parameters.AddWithValue("@slotId", product.Id);
            cmd.Parameters.AddWithValue("@type", product.Type.ToString());
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@price", product.Price);
            cmd.Parameters.AddWithValue("@stock", clampedStock);
            cmd.Parameters.AddWithValue("@flavorText", product.FlavorText);
            cmd.Parameters.AddWithValue("@calories", calories);
            cmd.Parameters.AddWithValue("@volumeMl", volumeMl);
            cmd.Parameters.AddWithValue("@imagePath", string.IsNullOrWhiteSpace(product.ImagePath) ? DBNull.Value : product.ImagePath);
        }

        private static void DeleteRemovedSlots(MySqlConnection conn, MySqlTransaction tx, IReadOnlyCollection<int> activeSlotIds)
        {
            if (activeSlotIds.Count == 0)
            {
                using var deleteAll = new MySqlCommand("DELETE FROM inventory_items", conn, tx);
                deleteAll.ExecuteNonQuery();
                return;
            }

            var parameterNames = new List<string>();
            using var deleteCmd = new MySqlCommand();
            deleteCmd.Connection = conn;
            deleteCmd.Transaction = tx;

            int index = 0;
            foreach (int slotId in activeSlotIds)
            {
                string name = $"@slot{index++}";
                parameterNames.Add(name);
                deleteCmd.Parameters.AddWithValue(name, slotId);
            }

            deleteCmd.CommandText = $"DELETE FROM inventory_items WHERE slot_id NOT IN ({string.Join(",", parameterNames)})";
            deleteCmd.ExecuteNonQuery();
        }

        private static void CreateTables(MySqlConnection conn)
        {
            string[] statements =
            {
                @"CREATE TABLE IF NOT EXISTS inventory_items (
                        inventory_id INT AUTO_INCREMENT PRIMARY KEY,
                        slot_id INT NOT NULL UNIQUE,
                        type VARCHAR(20) NOT NULL,
                        name VARCHAR(100) NOT NULL,
                        price DECIMAL(10, 2) NOT NULL,
                        stock INT NOT NULL DEFAULT 0,
                        flavor_text TEXT NOT NULL,
                        calories INT NOT NULL DEFAULT 0,
                        volume_ml INT NOT NULL DEFAULT 0,
                        image_path VARCHAR(255) NULL,
                        created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                        updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
                    )",
                @"CREATE TABLE IF NOT EXISTS sales_transactions (
                        transaction_id INT AUTO_INCREMENT PRIMARY KEY,
                        inventory_id INT NULL,
                        slot_id INT NOT NULL,
                        item_name VARCHAR(100) NOT NULL,
                        quantity INT NOT NULL DEFAULT 1,
                        amount_paid DECIMAL(10, 2) NOT NULL,
                        transaction_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                        FOREIGN KEY (inventory_id) REFERENCES inventory_items(inventory_id) ON DELETE SET NULL
                    )",
                @"CREATE TABLE IF NOT EXISTS event_logs (
                        log_id INT AUTO_INCREMENT PRIMARY KEY,
                        timestamp_utc DATETIME(6) NOT NULL,
                        event_type VARCHAR(50) NOT NULL,
                        details TEXT NOT NULL,
                        amount DECIMAL(10, 2) NOT NULL DEFAULT 0
                    )",
                @"CREATE TABLE IF NOT EXISTS customers (
                        rfid_tag VARCHAR(64) PRIMARY KEY,
                        email VARCHAR(120) NOT NULL UNIQUE,
                        password_hash VARCHAR(255) NOT NULL,
                        eco_credits INT NOT NULL DEFAULT 0,
                        registered_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                    )"
            };

            foreach (string statement in statements)
            {
                using var cmd = new MySqlCommand(statement, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
