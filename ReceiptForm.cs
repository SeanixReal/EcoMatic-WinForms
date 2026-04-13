namespace Eco_Matic_Winforms
{
    public partial class ReceiptForm : Form
    {
        private Transaction? _transaction;

        public ReceiptForm()
        {
            InitializeComponent();
        }

        public ReceiptForm(Transaction transaction) : this()
        {
            _transaction = transaction;
            PopulateReceipt();
        }

        private void PopulateReceipt()
        {
            if (_transaction == null)
            {
                lblTotal.Text = "Total:  ₱0.00";
                lblPaid.Text = "Paid:   ₱0.00";
                lblChange.Text = "Change: ₱0.00";
                return;
            }

            int y = 5;
            foreach (var item in _transaction.Items)
            {
                string line = $"{item.Quantity}x  {item.ProductName,-20} ₱{item.LineTotal:F2}";
                var lbl = new Label
                {
                    Text = line,
                    Font = new Font("Consolas", 10),
                    ForeColor = Color.FromArgb(40, 40, 40),
                    AutoSize = false,
                    Size = new Size(330, 22),
                    Location = new Point(5, y)
                };
                itemsPanel.Controls.Add(lbl);
                y += 24;
            }

            foreach (var recycle in _transaction.RecycledItems)
            {
                string line = $"Recycle {recycle.Material,-8} {recycle.Pieces,4}pc +{recycle.TotalPoints} PTS";
                var lbl = new Label
                {
                    Text = line,
                    Font = new Font("Consolas", 10),
                    ForeColor = Color.FromArgb(39, 174, 96),
                    AutoSize = false,
                    Size = new Size(330, 22),
                    Location = new Point(5, y)
                };
                itemsPanel.Controls.Add(lbl);
                y += 24;
            }

            lblTotal.Text = $"Total:  ₱{_transaction.TotalAmount:F2}";
            lblPaid.Text = $"Paid:   ₱{_transaction.AmountPaid:F2}";
            lblChange.Text = $"Change: ₱{_transaction.Change:F2}";
        }
    }
}
