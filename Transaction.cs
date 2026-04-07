namespace Eco_Matic_Winforms
{
	public class TransactionItem
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; } = string.Empty;
		public int Quantity { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal LineTotal => Quantity * UnitPrice;
	}

	public class Transaction
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public List<TransactionItem> Items { get; set; } = new();
		public decimal TotalAmount { get; set; }
		public decimal AmountPaid { get; set; }
		public decimal Change { get; set; }
	}
}
