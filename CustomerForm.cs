namespace Eco_Matic_Winforms
{
    public partial class CustomerForm : Form
    {
        private readonly Dictionary<int, int> _cart = new();
        private decimal _insertedMoney = 0;

        public CustomerForm()
        {
            InitializeComponent();

            CreateMoneyButtons();
            RefreshProducts();
            UpdateCartDisplay();
        }

        
        private void CreateMoneyButtons()
        {
            int[] denominations = { 20, 50, 100, 200, 500, 1000 };
            foreach (int d in denominations)
            {
                var btn = CreateMoneyButton(d);
                btn.Click += btnMoney_Click;
                moneyFlow.Controls.Add(btn);
            }
        }

        private static Button CreateMoneyButton(int amount)
        {
            var button = new Button
            {
                Text = $"₱{amount}",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Size = new Size(100, 33),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(241, 196, 15),
                ForeColor = Color.FromArgb(40, 40, 40),
                Cursor = Cursors.Hand,
                Tag = amount,
                Margin = new Padding(2)
            };

            button.FlatAppearance.BorderSize = 0;
            return button;
        }

        private void RefreshProducts()
        {
            productPanel.Controls.Clear();
            foreach (var p in DataStore.Products)
            {
                var card = new Button
                {
                    Size = new Size(120, 65),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    Cursor = Cursors.Hand,
                    Tag = p.Id,
                    Margin = new Padding(4),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                card.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
                card.FlatAppearance.BorderSize = 1;

                if (p.Stock > 0)
                {
                    card.Text = $"{p.Name}\n₱{p.Price:F2}";
                    card.BackColor = Color.White;
                    card.ForeColor = Color.FromArgb(40, 40, 40);
                    card.Click += ProductCard_Click;
                }
                else
                {
                    card.Text = $"{p.Name}\nSOLD OUT";
                    card.BackColor = Color.FromArgb(220, 220, 220);
                    card.ForeColor = Color.Gray;
                    card.Enabled = false;
                }

                productPanel.Controls.Add(card);
            }
        }

        
        private void ProductCard_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int productId)
            {
                var product = DataStore.Products.FirstOrDefault(p => p.Id == productId);
                if (product == null || product.Stock <= 0) return;

                int currentQty = _cart.ContainsKey(productId) ? _cart[productId] : 0;
                if (currentQty >= product.Stock)
                {
                    MessageBox.Show($"Not enough stock for {product.Name}!",
                        "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_cart.ContainsKey(productId))
                    _cart[productId]++;
                else
                    _cart[productId] = 1;

                UpdateCartDisplay();
            }
        }

        private void btnMoney_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int amount)
            {
                _insertedMoney += amount;
                UpdatePaymentDisplay();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _cart.Clear();
            _insertedMoney = 0;
            UpdateCartDisplay();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add at least one item.", "Cart Empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal total = GetCartTotal();
            if (_insertedMoney < total)
            {
                MessageBox.Show("Insufficient payment!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal change = _insertedMoney - total;

            var transaction = new Transaction
            {
                Id = DataStore.NextTransactionId++,
                Date = DateTime.Now,
                TotalAmount = total,
                AmountPaid = _insertedMoney,
                Change = change
            };

            foreach (var kvp in _cart)
            {
                var product = DataStore.Products.First(p => p.Id == kvp.Key);
                transaction.Items.Add(new TransactionItem
                {
                    ProductId = product.Id,
                    ProductName = product.Name,
                    Quantity = kvp.Value,
                    UnitPrice = product.Price
                });
                product.Stock -= kvp.Value;
            }

            DataStore.Transactions.Add(transaction);
            DataStore.LastTransaction = transaction;

            MessageBox.Show(
                $"Purchase successful!\nChange: ₱{change:F2}\n\nGet your receipt from the main menu.",
                "Purchase Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        
        private void removeItemMenuItem_Click(object sender, EventArgs e)
        {
            if (cartList.SelectedIndex < 0)
            {
                MessageBox.Show("Select an item in the cart first.", "Remove",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idx = cartList.SelectedIndex;
            var keys = _cart.Keys.ToList();
            if (idx < keys.Count)
            {
                int productId = keys[idx];
                _cart[productId]--;
                if (_cart[productId] <= 0)
                    _cart.Remove(productId);
                UpdateCartDisplay();
            }
        }

        private void clearAllMenuItem_Click(object sender, EventArgs e)
        {
            _cart.Clear();
            _insertedMoney = 0;
            UpdateCartDisplay();
        }

        
        private void backMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void howToBuyMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "1. Click a product to add it to your cart\n" +
                "2. Right-click the cart to remove items\n" +
                "3. Insert money using the bill buttons\n" +
                "4. Click PURCHASE when ready",
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openReadmeMenuItem_Click(object sender, EventArgs e)
        {
            using var readmeForm = new ReadmeForm();
            readmeForm.ShowDialog(this);
        }

        
        private decimal GetCartTotal()
        {
            decimal total = 0;
            foreach (var kvp in _cart)
            {
                var product = DataStore.Products.FirstOrDefault(p => p.Id == kvp.Key);
                if (product != null)
                    total += product.Price * kvp.Value;
            }
            return total;
        }

        private void UpdateCartDisplay()
        {
            cartList.Items.Clear();
            foreach (var kvp in _cart)
            {
                var product = DataStore.Products.FirstOrDefault(p => p.Id == kvp.Key);
                if (product != null)
                {
                    decimal lineTotal = product.Price * kvp.Value;
                    cartList.Items.Add($" {kvp.Value}x {product.Name,-20} ₱{lineTotal:F2}");
                }
            }

            decimal total = GetCartTotal();
            lblTotal.Text = $"Total:  ₱{total:F2}";
            UpdatePaymentDisplay();
        }

        private void UpdatePaymentDisplay()
        {
            decimal total = GetCartTotal();
            lblInserted.Text = $"Inserted: ₱{_insertedMoney:F2}";
            decimal change = Math.Max(0, _insertedMoney - total);
            lblChange.Text = $"Change:  ₱{change:F2}";
            btnPurchase.Enabled = _cart.Count > 0;
        }
    }
}
