namespace Eco_Matic_Winforms
{
    public partial class CustomerForm : Form
    {
        private readonly Dictionary<int, int> _cart = new();
        private readonly List<RecycleEntry> _recycleEntries = new();
        private decimal _insertedMoney = 0;

        public CustomerForm()
        {
            InitializeComponent();

            InitializeProductButtons();
            InitializeSelectors();
            RefreshProducts();
            UpdateCartDisplay();
        }

        private sealed class ProductOption
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public override string ToString() => Name;
        }

        private void InitializeProductButtons()
        {
            Button[] buttons =
            {
                btnProd1, btnProd2, btnProd3, btnProd4, btnProd5,
                btnProd6, btnProd7, btnProd8, btnProd9, btnProd10,
                btnProd11, btnProd12, btnProd13, btnProd14, btnProd15
            };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Tag = i + 1;
                buttons[i].Click -= ProductCard_Click;
                buttons[i].Click += ProductCard_Click;
            }

            btnMoney20.Tag = 20;
            btnMoney50.Tag = 50;
            btnMoney100.Tag = 100;
            btnMoney200.Tag = 200;
            btnMoney500.Tag = 500;
            btnMoney1000.Tag = 1000;
        }

        private void InitializeSelectors()
        {
            cboRecycleType.Items.Clear();
            foreach (var material in Enum.GetValues<RecycleMaterial>())
            {
                cboRecycleType.Items.Add(material);
            }

            if (cboRecycleType.Items.Count > 0)
            {
                cboRecycleType.SelectedIndex = 0;
            }

            nudRecycleQty.Value = 1;
            RefreshExamineOptions();
        }

        private void RefreshExamineOptions()
        {
            var selectedId = (cboExamineItem.SelectedItem as ProductOption)?.Id;
            cboExamineItem.Items.Clear();

            foreach (var p in DataStore.Products.OrderBy(p => p.Id))
            {
                cboExamineItem.Items.Add(new ProductOption { Id = p.Id, Name = p.Name });
            }

            if (selectedId.HasValue)
            {
                var same = cboExamineItem.Items
                    .OfType<ProductOption>()
                    .FirstOrDefault(x => x.Id == selectedId.Value);
                if (same != null)
                {
                    cboExamineItem.SelectedItem = same;
                    return;
                }
            }

            if (cboExamineItem.Items.Count > 0)
            {
                cboExamineItem.SelectedIndex = 0;
            }
        }

        private void RefreshProducts()
        {
            foreach (var control in productPanel.Controls.OfType<Button>())
            {
                if (!int.TryParse(control.Tag?.ToString(), out int productId))
                {
                    continue;
                }

                var product = DataStore.Products.FirstOrDefault(p => p.Id == productId);
                if (product == null)
                {
                    control.Text = "EMPTY\nN/A";
                    control.Enabled = false;
                    control.BackColor = Color.FromArgb(220, 220, 220);
                    control.ForeColor = Color.Gray;
                    continue;
                }

                if (product.Stock > 0)
                {
                    control.Text = $"{product.Name}\n₱{product.Price:F2} (x{product.Stock})";
                    control.BackColor = Color.White;
                    control.ForeColor = Color.FromArgb(40, 40, 40);
                    control.Enabled = true;
                }
                else
                {
                    control.Text = $"{product.Name}\nSOLD OUT";
                    control.BackColor = Color.FromArgb(220, 220, 220);
                    control.ForeColor = Color.Gray;
                    control.Enabled = false;
                }
            }

            RefreshExamineOptions();
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
            if (sender is Button btn && int.TryParse(btn.Tag?.ToString(), out int amount))
            {
                _insertedMoney += amount;
                UpdatePaymentDisplay();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _cart.Clear();
            _insertedMoney = 0;
            _recycleEntries.Clear();
            lblRecycleStatus.Text = "";
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

            foreach (var recycle in _recycleEntries)
            {
                transaction.RecycledItems.Add(new RecycleEntry
                {
                    Material = recycle.Material,
                    WeightKg = recycle.WeightKg,
                    CreditPerKg = recycle.CreditPerKg
                });
            }

            DataStore.Transactions.Add(transaction);
            DataStore.LastTransaction = transaction;
            DataStore.SaveInventory();

            string purchaseDetails = string.Join(", ", transaction.Items.Select(x => $"{x.Quantity}x {x.ProductName}"));
            DataStore.LogEvent("PURCHASE", purchaseDetails, transaction.TotalAmount);

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
            _recycleEntries.Clear();
            lblRecycleStatus.Text = "";
            UpdateCartDisplay();
        }

        private void btnExamine_Click(object sender, EventArgs e)
        {
            if (cboExamineItem.SelectedItem is not ProductOption option)
            {
                MessageBox.Show("Select an item to examine.", "Examine Item",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var product = DataStore.Products.FirstOrDefault(p => p.Id == option.Id);
            if (product == null)
            {
                MessageBox.Show("Item is no longer available.", "Examine Item",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RefreshProducts();
                return;
            }

            MessageBox.Show(
                $"{product.Name}\nType: {product.Type}\nPrice: ₱{product.Price:F2}\nStock: {product.Stock}\n\n{product.Examine()}",
                "Item Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRecycle_Click(object sender, EventArgs e)
        {
            if (cboRecycleType.SelectedItem is not RecycleMaterial material)
            {
                MessageBox.Show("Select a recycle material first.", "Recycle for Credit",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal weightKg = nudRecycleQty.Value;
            if (weightKg <= 0)
            {
                MessageBox.Show("Weight must be greater than 0.", "Recycle for Credit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal rate = DataStore.RecycleRates[material];
            decimal credit = rate * weightKg;
            _insertedMoney += credit;

            var existing = _recycleEntries.FirstOrDefault(x => x.Material == material);
            if (existing == null)
            {
                _recycleEntries.Add(new RecycleEntry
                {
                    Material = material,
                    WeightKg = weightKg,
                    CreditPerKg = rate
                });
            }
            else
            {
                existing.WeightKg += weightKg;
            }

            DataStore.LogEvent("RECYCLE", $"{weightKg:F2} kg {material}", credit);

            lblRecycleStatus.Text = $"Added ₱{credit:F2} credit";
            UpdatePaymentDisplay();
        }

        private void backMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void howToBuyMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "1. Click a product to add it to your cart\n" +
                "2. Right-click the cart to remove items\n" +
                "3. Insert money using the bill buttons\n" +
                "4. Examine products before buying (optional)\n" +
                "5. Recycle plastic, glass, or aluminum by weight in kg for credit (optional)\n" +
                "6. Click PURCHASE when ready",
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
            foreach (var kvp in _cart.OrderBy(k => k.Key))
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
            btnPurchase.Enabled = _cart.Count > 0 && _insertedMoney >= total;
        }
    }
}
