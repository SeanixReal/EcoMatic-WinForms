

namespace Eco_Matic_Winforms
{
    public partial class AdminForm : Form
    {
        private sealed class ProductOption
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public override string ToString() => Name;
        }

        public AdminForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            RefreshGrid();
            RefreshSelectors();
            LoadAddTypeSelector();
            UpdateTypeSpecificFields();
            SyncSelectorsFromGridSelection();
        }

        private void RefreshGrid()
        {
            inventoryGrid.Rows.Clear();

            foreach (var product in DataStore.Products.OrderBy(p => p.Id))
            {
                int idx = inventoryGrid.Rows.Add(
                    product.Id,
                    product.Type,
                    product.Name,
                    $"₱{product.Price:F2}",
                    product.Stock,
                    product.FlavorText);

                if (product.Stock <= 2)
                {
                    inventoryGrid.Rows[idx].Cells[colStock.Index].Style.ForeColor = Color.Red;
                    inventoryGrid.Rows[idx].Cells[colStock.Index].Style.Font =
                        new Font("Segoe UI", 10, FontStyle.Bold);
                }
            }

            if (inventoryGrid.Rows.Count > 0)
            {
                inventoryGrid.ClearSelection();
                inventoryGrid.Rows[0].Selected = true;
            }
        }

        private void LoadAddTypeSelector()
        {
            cboAddType.Items.Clear();
            foreach (var value in Enum.GetValues<ProductType>())
            {
                cboAddType.Items.Add(value);
            }

            if (cboAddType.Items.Count > 0)
            {
                cboAddType.SelectedIndex = 0;
            }

            UpdateTypeSpecificFields();
        }

        private void RefreshSelectors()
        {
            int? restockId = (cboItem.SelectedItem as ProductOption)?.Id;
            int? removeId = (cboRemoveItem.SelectedItem as ProductOption)?.Id;

            cboItem.Items.Clear();
            cboRemoveItem.Items.Clear();

            foreach (var p in DataStore.Products.OrderBy(p => p.Id))
            {
                var option = new ProductOption
                {
                    Id = p.Id,
                    Name = $"#{p.Id} - {p.Name}"
                };
                cboItem.Items.Add(option);
                cboRemoveItem.Items.Add(option);
            }

            if (cboItem.Items.Count > 0)
            {
                SelectComboById(cboItem, restockId ?? (cboItem.Items[0] as ProductOption)!.Id);
                SelectComboById(cboRemoveItem, removeId ?? (cboRemoveItem.Items[0] as ProductOption)!.Id);
            }
        }

        private static bool SelectComboById(ComboBox comboBox, int targetId)
        {
            var target = comboBox.Items
                .OfType<ProductOption>()
                .FirstOrDefault(x => x.Id == targetId);

            if (target == null)
            {
                return false;
            }

            comboBox.SelectedItem = target;
            return true;
        }

        private void SelectFromGrid(int productId)
        {
            SelectComboById(cboItem, productId);
            SelectComboById(cboRemoveItem, productId);
        }

        private void SyncSelectorsFromGridSelection()
        {
            if (inventoryGrid.SelectedRows.Count == 0)
            {
                return;
            }

            object? value = inventoryGrid.SelectedRows[0].Cells[colId.Index].Value;
            if (value == null)
            {
                return;
            }

            if (int.TryParse(value.ToString(), out int productId))
            {
                SelectFromGrid(productId);
            }
        }

        private void inventoryGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            object? value = inventoryGrid.Rows[e.RowIndex].Cells[colId.Index].Value;
            if (value == null)
            {
                return;
            }

            if (int.TryParse(value.ToString(), out int productId))
            {
                SelectFromGrid(productId);
            }
        }

        private void inventoryGrid_SelectionChanged(object sender, EventArgs e)
        {
            SyncSelectorsFromGridSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cboItem.SelectedItem is not ProductOption selected)
            {
                MessageBox.Show("Please select an item from the dropdown first.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = DataStore.Products.FirstOrDefault(p => p.Id == selected.Id);
            if (product == null)
            {
                MessageBox.Show("Item was not found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int oldStock = product.Stock;
            product.Stock = DataStore.MaxStockPerItem;
            DataStore.SaveInventory();
            DataStore.LogEvent("ADMIN_RESTOCK", $"{product.Name}: {oldStock} -> {product.Stock}");

            MessageBox.Show($"{product.Name} restocked to max level ({DataStore.MaxStockPerItem}).",
                "Restock Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGrid();
            RefreshSelectors();
            SelectFromGrid(product.Id);
        }

        private void btnRestockAdd_Click(object sender, EventArgs e)
        {
            if (cboItem.SelectedItem is not ProductOption selected)
            {
                MessageBox.Show("Please select an item from the dropdown first.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = DataStore.Products.FirstOrDefault(p => p.Id == selected.Id);
            if (product == null)
            {
                MessageBox.Show("Item was not found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantityToAdd = (int)nudRestockQty.Value;
            int oldStock = product.Stock;
            product.Stock = Math.Clamp(product.Stock + quantityToAdd, 0, DataStore.MaxStockPerItem);

            DataStore.SaveInventory();
            DataStore.LogEvent("ADMIN_RESTOCK_ADD", $"{product.Name}: {oldStock} +{quantityToAdd} -> {product.Stock}");

            MessageBox.Show(
                $"{product.Name} stock updated from {oldStock} to {product.Stock}.",
                "Restock Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            RefreshGrid();
            RefreshSelectors();
            SelectFromGrid(product.Id);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (DataStore.Products.Count >= DataStore.MaxItemSlots)
            {
                MessageBox.Show($"Maximum item slots reached ({DataStore.MaxItemSlots}).",
                    "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtAddName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Item name is required.", "Add Item",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DataStore.Products.Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Item name must be unique.", "Add Item",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboAddType.SelectedItem is not ProductType type)
            {
                MessageBox.Show("Choose a product type.", "Add Item",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal price = nudAddPrice.Value;
            if (price <= 0m)
            {
                MessageBox.Show("Price must be greater than zero.", "Add Item",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int stock = Math.Clamp((int)nudAddStock.Value, 1, DataStore.MaxStockPerItem);
            string flavor = txtAddFlavor.Text.Trim();
            if (string.IsNullOrWhiteSpace(flavor))
            {
                flavor = "No description available.";
            }

            int newId = DataStore.Products.Count == 0 ? 1 : DataStore.Products.Max(p => p.Id) + 1;

            var newProduct = Product.Create(
                type,
                newId,
                name,
                price,
                stock,
                flavor,
                type == ProductType.Snack ? (int)nudAddCalories.Value : 0,
                type == ProductType.Drink ? (int)nudAddVolume.Value : 0);

            DataStore.Products.Add(newProduct);
            DataStore.SaveInventory();
            DataStore.LogEvent("ADMIN_ADD_ITEM", $"{newProduct.Name} ({newProduct.Type})", newProduct.Price);

            MessageBox.Show("Item added successfully.", "Add Item",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtAddName.Clear();
            txtAddFlavor.Clear();
            nudAddPrice.Value = 1;
            nudAddStock.Value = DataStore.MaxStockPerItem;
            nudAddCalories.Value = 0;
            nudAddVolume.Value = 0;
            UpdateTypeSpecificFields();

            RefreshGrid();
            RefreshSelectors();
            SelectFromGrid(newProduct.Id);
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (cboRemoveItem.SelectedItem is not ProductOption selected)
            {
                MessageBox.Show("Select an item to remove.", "Remove Item",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = DataStore.Products.FirstOrDefault(p => p.Id == selected.Id);
            if (product == null)
            {
                MessageBox.Show("Item was not found.", "Remove Item",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show(
                $"Remove {product.Name} from inventory?",
                "Confirm Remove",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            DataStore.Products.Remove(product);
            DataStore.SaveInventory();
            DataStore.LogEvent("ADMIN_REMOVE_ITEM", product.Name);

            RefreshGrid();
            RefreshSelectors();
            SyncSelectorsFromGridSelection();
        }

        private void btnViewLog_Click(object sender, EventArgs e)
        {
            using var logForm = new EventLogForm();
            logForm.ShowDialog(this);
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Clear all event logs? This cannot be undone.",
                "Confirm Clear Log",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            DataStore.ClearLogs();
            MessageBox.Show("Event log cleared.", "Log Cleared",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e) => this.Close();

        private void backMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void cboAddType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTypeSpecificFields();
        }

        private void UpdateTypeSpecificFields()
        {
            if (cboAddType.SelectedItem is not ProductType type)
            {
                return;
            }

            bool showCalories = type == ProductType.Snack;
            bool showVolume = type == ProductType.Drink;

            lblAddCalories.Visible = showCalories;
            nudAddCalories.Visible = showCalories;

            lblAddVolume.Visible = showVolume;
            nudAddVolume.Visible = showVolume;

            if (!showCalories)
            {
                nudAddCalories.Value = 0;
            }

            if (!showVolume)
            {
                nudAddVolume.Value = 0;
            }
        }

        private void adminHelpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Admin tools:\n\n" +
                "1. Restock selected item to max, or add a custom stock quantity.\n" +
                "2. Add and remove items from inventory.\n" +
                "3. Open event logs in a scrollable page and clear them.\n\n" +
                "Low stock items (<= 2) are highlighted in red.",
                "Admin Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openReadmeMenuItem_Click(object sender, EventArgs e)
        {
            using var readmeForm = new ReadmeForm();
            readmeForm.ShowDialog(this);
        }
    }
}
