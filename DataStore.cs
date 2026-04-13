using Eco_Matic_Winforms.Data;

namespace Eco_Matic_Winforms
{
    public static class DataStore
    {
        public const int MaxItemSlots = 12;
        public const int MaxStockPerItem = 15;

        public static readonly IReadOnlyDictionary<RecycleMaterial, int> RecycleRates =
            new Dictionary<RecycleMaterial, int>
            {
                [RecycleMaterial.Plastic] = 1,
                [RecycleMaterial.Glass] = 2,
                [RecycleMaterial.Aluminum] = 3
            };

        private static readonly MySqlStore Store = new();

        private static readonly List<Product> DefaultProducts = new()
            {
                Product.Create(ProductType.Snack, 1, "Mr Chips", 30.5m, 10, "Crunchy salted potato chips.", 160, 0, "MrChips.png"),
                Product.Create(ProductType.Snack, 2, "Nova", 40m, 10, "Cheesy square crackers.", 170, 0, "Nova.png"),
                Product.Create(ProductType.Drink, 3, "Coca Cola", 30.5m, 10, "Classic cola refreshment.", 140, 330, "CocaCola.png"),
                Product.Create(ProductType.Drink, 4, "Pepsi", 30m, 10, "Bold cola flavor.", 150, 330, "Pepsi.png"),
                Product.Create(ProductType.Misc, 5, "Bandaid Box", 20m, 10, "Compact first-aid strips.", 0, 0, "BandaidBox.png"),
                Product.Create(ProductType.Misc, 6, "Eco Bag", 30.75m, 10, "Reusable eco-friendly carry bag.", 0, 0, "EcoBag.png"),
                Product.Create(ProductType.Snack, 7, "Piattos", 35m, 10, "Sour cream and onion chips.", 180, 0, "Piattos.png"),
                Product.Create(ProductType.Snack, 8, "Chippy", 32m, 10, "Light and crispy chips.", 175, 0, "Chippy.png"),
                Product.Create(ProductType.Snack, 9, "Roller Coaster", 28.5m, 10, "Ridged chips with barbecue taste.", 165, 0, "RollerCoaster.png"),
                Product.Create(ProductType.Snack, 10, "Fudge Bar", 25m, 10, "Chocolate coated wafer bar.", 150, 0, "KitKat.png"),
                Product.Create(ProductType.Snack, 11, "Cheese Ring", 30m, 10, "Cheesy ring-shaped corn snack.", 170, 0, "CheeseRing.png"),
                Product.Create(ProductType.Drink, 12, "RC Cola", 25m, 10, "Refreshing RC cola.", 135, 330, "RCCola.png"),
            };

        public static List<Product> Products { get; } = new();
        public static List<Transaction> Transactions { get; } = new();
        public static int NextTransactionId { get; set; } = 1;
        public static Transaction? LastTransaction { get; set; }
        public static int PendingPoints { get; set; }
        public static string? ActiveCustomerRfid { get; private set; }

        public static void Initialize()
        {
            Products.Clear();
            Store.EnsureDatabaseReady(DefaultProducts);
            Store.EnsureCustomerTableExists();
            Products.AddRange(Store.LoadInventory(DefaultProducts));
            NextTransactionId = 1;
            LastTransaction = null;
            PendingPoints = 0;
            ActiveCustomerRfid = null;
            Transactions.Clear();
        }

        public static void SaveInventory() => Store.SaveInventory(Products);

        public static void LogEvent(string eventType, string details, decimal amount = 0m)
        {
            Store.LogEvent(eventType, details, amount);
        }

        public static void RecordSale(Product product, int quantity = 1)
        {
            if (product == null)
            {
                return;
            }

            Store.RecordSale(product.DbInventoryId, product.Id, product.Name, product.Price * quantity, quantity);
        }

        public static bool CustomerExists(string rfid) => Store.CustomerExists(rfid);

        public static bool RegisterCustomer(string rfid, string email, string pass) => Store.RegisterCustomer(rfid, email, pass);

        public static (string Email, int EcoCredits) GetCustomerInfo(string rfid) => Store.GetCustomerInfo(rfid);

        public static bool UpdateCustomerCredits(string rfid, int newCredits) => Store.UpdateCustomerCredits(rfid, newCredits);

        public static bool TrySpendCustomerCredits(string rfid, int points) => Store.TrySpendCustomerCredits(rfid, points);

        public static void SetActiveCustomer(string? rfid)
        {
            ActiveCustomerRfid = string.IsNullOrWhiteSpace(rfid) ? null : rfid;
        }

        public static void ClearActiveCustomer() => ActiveCustomerRfid = null;

        public static List<EventLogEntry> ReadLogs() => Store.GetEventLogs();

        public static void ClearLogs() => Store.ClearEventLogs();
    }
}
