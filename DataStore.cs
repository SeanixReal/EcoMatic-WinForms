namespace Eco_Matic_Winforms
{
    public static class DataStore
    {
        public static List<Product> Products { get; } = new()
            {
                new Product { Id = 1,  Name = "Mr Chips", Price = 30.5m, Stock = 10 },
                new Product { Id = 2,  Name = "Nova", Price = 40m, Stock = 10 },
                new Product { Id = 3,  Name = "Coca Cola", Price = 30.5m, Stock = 10 },
                new Product { Id = 4,  Name = "Pepsi", Price = 30m,Stock = 10 },
                new Product { Id = 5,  Name = "Bandaid Box", Price = 20m, Stock = 10 },
                new Product { Id = 6,  Name = "Eco Bag", Price = 30.75m, Stock = 10 },
                new Product { Id = 7,  Name = "Piattos", Price = 35m, Stock = 10 },
                new Product { Id = 8,  Name = "Chippy", Price = 32m, Stock = 10 },
                new Product { Id = 9,  Name = "Roller Coaster", Price = 28.5m, Stock = 10 },
                new Product { Id = 10, Name = "Fudge Bar", Price = 25m, Stock = 10 },
                new Product { Id = 11, Name = "Cheese Ring", Price = 30m, Stock = 10 },
                new Product { Id = 12, Name = "RC Cola", Price = 25m, Stock = 10 },
                new Product { Id = 13, Name = "Sting", Price = 27.5m, Stock = 10 },
                new Product { Id = 14, Name = "Zest-O Orange", Price = 15m, Stock = 10 },
                new Product { Id = 15, Name = "Del Monte Pineapple Juice", Price = 22.5m, Stock = 10 }
            };

        public static List<Transaction> Transactions { get; } = new();
        public static int NextTransactionId { get; set; } = 1;
        public static Transaction? LastTransaction { get; set; }
    }
}
