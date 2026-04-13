using MySql.Data.MySqlClient;

namespace Eco_Matic_Winforms.Data
{
    public partial class MySqlStore
    {
        public void EnsureCustomerTableExists()
        {
            EnsureDatabaseReady();
        }

        public bool CustomerExists(string rfid)
        {
            EnsureDatabaseReady();
            using var conn = GetConnection();
            conn.Open();

            using var cmd = new MySqlCommand("SELECT COUNT(*) FROM customers WHERE rfid_tag = @rfid", conn);
            cmd.Parameters.AddWithValue("@rfid", rfid);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        public bool RegisterCustomer(string rfid, string email, string pass)
        {
            EnsureDatabaseReady();
            using var conn = GetConnection();
            conn.Open();

            const string sql = "INSERT INTO customers (rfid_tag, email, password_hash) VALUES (@rfid, @email, @pass)";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@rfid", rfid);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", pass);

            return cmd.ExecuteNonQuery() > 0;
        }

        public (string Email, int EcoCredits) GetCustomerInfo(string rfid)
        {
            EnsureDatabaseReady();
            using var conn = GetConnection();
            conn.Open();

            const string sql = "SELECT email, eco_credits FROM customers WHERE rfid_tag = @rfid";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@rfid", rfid);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                return (string.Empty, 0);
            }

            return (reader.GetString("email"), reader.GetInt32("eco_credits"));
        }

        public bool UpdateCustomerCredits(string rfid, int newCredits)
        {
            EnsureDatabaseReady();
            using var conn = GetConnection();
            conn.Open();

            const string sql = "UPDATE customers SET eco_credits = @credits WHERE rfid_tag = @rfid";
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@credits", newCredits);
            cmd.Parameters.AddWithValue("@rfid", rfid);

            return cmd.ExecuteNonQuery() > 0;
        }

        public bool TrySpendCustomerCredits(string rfid, int points)
        {
            if (points <= 0)
            {
                return true;
            }

            EnsureDatabaseReady();
            using var conn = GetConnection();
            conn.Open();

            const string sql = @"
                UPDATE customers
                SET eco_credits = eco_credits - @points
                WHERE rfid_tag = @rfid AND eco_credits >= @points";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@rfid", rfid);
            cmd.Parameters.AddWithValue("@points", points);
            return cmd.ExecuteNonQuery() == 1;
        }
    }
}
