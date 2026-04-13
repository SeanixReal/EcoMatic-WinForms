

namespace Eco_Matic_Winforms
{
    public partial class AdminForm : Form
    {
        private string? _selectedImagePath = null;

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

        #region ── Dark Theme ──

        private void ApplyDarkTheme()
        {
            // Form
            this.BackColor = Color.FromArgb(18, 18, 36);
            this.ForeColor = Color.FromArgb(200, 210, 225);

            // Menu strip
            if (menuStrip != null)
            {
                menuStrip.BackColor = Color.FromArgb(12, 12, 26);
                menuStrip.ForeColor = Color.FromArgb(160, 175, 195);
                menuStrip.RenderMode = ToolStripRenderMode.Professional;
                menuStrip.Renderer = new ToolStripProfessionalRenderer(new DarkMenuColors());

                foreach (ToolStripItem item in menuStrip.Items)
                    StyleMenuItem(item);
            }

            // Inventory grid
            inventoryGrid.BackgroundColor = Color.FromArgb(14, 14, 30);
            inventoryGrid.GridColor = Color.FromArgb(35, 35, 60);
            inventoryGrid.DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 40);
            inventoryGrid.DefaultCellStyle.ForeColor = Color.FromArgb(200, 210, 225);
            inventoryGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 100, 150);
            inventoryGrid.DefaultCellStyle.SelectionForeColor = Color.White;
            inventoryGrid.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            inventoryGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(10, 40, 80);
            inventoryGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 210, 255);
            inventoryGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            inventoryGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(10, 40, 80);
            inventoryGrid.EnableHeadersVisualStyles = false;
            inventoryGrid.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(14, 14, 30);
            inventoryGrid.RowHeadersDefaultCellStyle.ForeColor = Color.FromArgb(100, 110, 130);
            inventoryGrid.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 100, 150);
            inventoryGrid.BorderStyle = BorderStyle.None;

            // Recursively style all controls
            ApplyDarkRecursive(this);
        }

        private void ApplyDarkRecursive(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                switch (ctrl)
                {
                    case GroupBox gb:
                        gb.BackColor = Color.FromArgb(22, 22, 42);
                        gb.ForeColor = Color.FromArgb(0, 190, 230);
                        gb.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                        break;

                    case Button btn when btn != btnBrowseImage:
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.Cursor = Cursors.Hand;
                        // Preserve existing button colors for action buttons
                        if (btn.BackColor == Color.FromArgb(245, 250, 245) ||
                            btn.BackColor == SystemColors.Control)
                        {
                            btn.BackColor = Color.FromArgb(42, 42, 65);
                            btn.ForeColor = Color.White;
                        }
                        break;

                    case TextBox tb:
                        tb.BackColor = Color.FromArgb(14, 14, 32);
                        tb.ForeColor = Color.FromArgb(200, 220, 240);
                        tb.BorderStyle = BorderStyle.FixedSingle;
                        break;

                    case ComboBox cbo:
                        cbo.BackColor = Color.FromArgb(14, 14, 32);
                        cbo.ForeColor = Color.FromArgb(200, 220, 240);
                        cbo.FlatStyle = FlatStyle.Flat;
                        break;

                    case NumericUpDown nud:
                        nud.BackColor = Color.FromArgb(14, 14, 32);
                        nud.ForeColor = Color.FromArgb(200, 220, 240);
                        break;

                    case Label lbl:
                        // Only re-color labels that haven't been explicitly colored
                        if (lbl.ForeColor == Color.FromArgb(52, 73, 94) ||
                            lbl.ForeColor == SystemColors.ControlText ||
                            lbl.ForeColor == Color.Black)
                        {
                            lbl.ForeColor = Color.FromArgb(180, 195, 215);
                        }
                        lbl.Font = new Font("Segoe UI", lbl.Font.Size, lbl.Font.Style);
                        break;

                    case PictureBox pb:
                        pb.BackColor = Color.FromArgb(14, 14, 32);
                        break;

                    case Panel pnl:
                        if (pnl.BackColor == Color.FromArgb(245, 250, 245) ||
                            pnl.BackColor == SystemColors.Control)
                        {
                            pnl.BackColor = Color.FromArgb(18, 18, 36);
                        }
                        break;
                }

                if (ctrl.HasChildren && ctrl is not DataGridView)
                    ApplyDarkRecursive(ctrl);
            }
        }

        private static void StyleMenuItem(ToolStripItem item)
        {
            item.ForeColor = Color.FromArgb(180, 195, 215);
            if (item is ToolStripMenuItem menuItem)
            {
                foreach (ToolStripItem sub in menuItem.DropDownItems)
                    StyleMenuItem(sub);
            }
        }

        /// <summary>Custom dark color table for menu strip rendering.</summary>
        private class DarkMenuColors : ProfessionalColorTable
        {
            public override Color MenuBorder => Color.FromArgb(35, 35, 60);
            public override Color MenuItemBorder => Color.FromArgb(0, 140, 200);
            public override Color MenuItemSelected => Color.FromArgb(30, 30, 55);
            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(30, 30, 55);
            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(30, 30, 55);
            public override Color MenuItemPressedGradientBegin => Color.FromArgb(0, 80, 120);
            public override Color MenuItemPressedGradientEnd => Color.FromArgb(0, 80, 120);
            public override Color MenuStripGradientBegin => Color.FromArgb(12, 12, 26);
            public override Color MenuStripGradientEnd => Color.FromArgb(12, 12, 26);
            public override Color ToolStripDropDownBackground => Color.FromArgb(20, 20, 40);
            public override Color ImageMarginGradientBegin => Color.FromArgb(20, 20, 40);
            public override Color ImageMarginGradientMiddle => Color.FromArgb(20, 20, 40);
            public override Color ImageMarginGradientEnd => Color.FromArgb(20, 20, 40);
            public override Color SeparatorDark => Color.FromArgb(40, 40, 65);
            public override Color SeparatorLight => Color.FromArgb(40, 40, 65);
        }

        #endregion

        #region ── Grid & Selectors ──

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
                    inventoryGrid.Rows[idx].Cells[colStock.Index].Style.ForeColor = Color.FromArgb(255, 80, 80);
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
                cboAddType.Items.Add(value);
            if (cboAddType.Items.Count > 0) cboAddType.SelectedIndex = 0;
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
                var option = new ProductOption { Id = p.Id, Name = $"#{p.Id} - {p.Name}" };
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
            var target = comboBox.Items.OfType<ProductOption>().FirstOrDefault(x => x.Id == targetId);
            if (target == null) return false;
            comboBox.SelectedItem = target;
            return true;
        }

        private void SelectFromGrid(int productId)
        {
            SelectComboById(cboItem, productId);
            SelectComboById(cboRemoveItem, productId);
            LoadEditorFromProduct(productId);
        }

        private void SyncSelectorsFromGridSelection()
        {
            if (inventoryGrid.SelectedRows.Count == 0) return;
            object? value = inventoryGrid.SelectedRows[0].Cells[colId.Index].Value;
            if (value == null) return;
            if (int.TryParse(value.ToString(), out int productId))
                SelectFromGrid(productId);
        }

        private void inventoryGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            object? value = inventoryGrid.Rows[e.RowIndex].Cells[colId.Index].Value;
            if (value == null) return;
            if (int.TryParse(value.ToString(), out int productId))
                SelectFromGrid(productId);
        }

        private void inventoryGrid_SelectionChanged(object sender, EventArgs e)
        {
            SyncSelectorsFromGridSelection();
        }

        private Product? GetSelectedProductFromGrid()
        {
            if (inventoryGrid.SelectedRows.Count == 0) return null;
            object? value = inventoryGrid.SelectedRows[0].Cells[colId.Index].Value;
            if (value == null) return null;
            if (!int.TryParse(value.ToString(), out int productId)) return null;
            return DataStore.Products.FirstOrDefault(p => p.Id == productId);
        }

        private void LoadEditorFromProduct(int productId)
        {
            var product = DataStore.Products.FirstOrDefault(p => p.Id == productId);
            if (product == null) return;

            txtAddName.Text = product.Name;
            cboAddType.SelectedItem = product.Type;
            nudAddPrice.Value = Math.Clamp(product.Price, nudAddPrice.Minimum, nudAddPrice.Maximum);
            nudAddStock.Value = Math.Clamp(product.Stock, (int)nudAddStock.Minimum, (int)nudAddStock.Maximum);
            txtAddFlavor.Text = product.FlavorText;
            nudEditSlotId.Value = Math.Clamp(product.Id, (int)nudEditSlotId.Minimum, (int)nudEditSlotId.Maximum);

            nudAddCalories.Value = product is IHasCalories hasCalories
                ? Math.Clamp(hasCalories.Calories, (int)nudAddCalories.Minimum, (int)nudAddCalories.Maximum)
                : 0;

            nudAddVolume.Value = product is IHasVolume hasVolume
                ? Math.Clamp(hasVolume.VolumeMl, (int)nudAddVolume.Minimum, (int)nudAddVolume.Maximum)
                : 0;

            _selectedImagePath = null;
            lblImagePath.Text = string.IsNullOrWhiteSpace(product.ImagePath) ? "No image selected" : product.ImagePath;
            LoadPreviewImage(CsvStorage.GetImageFullPath(product.ImagePath, product.Name));
            UpdateTypeSpecificFields();
        }

        private void LoadPreviewImage(string fullPath)
        {
            if (picImagePreview.Image != null)
            {
                picImagePreview.Image.Dispose();
                picImagePreview.Image = null;
            }

            if (!File.Exists(fullPath)) return;

            try
            {
                using var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
                picImagePreview.Image = Image.FromStream(stream);
            }
            catch
            {
                picImagePreview.Image = null;
            }
        }

        #endregion

        #region ── Restock ──

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cboItem.SelectedItem is not ProductOption selected)
            {
                MessageBox.Show("Please select an item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = DataStore.Products.FirstOrDefault(p => p.Id == selected.Id);
            if (product == null) return;

            int oldStock = product.Stock;
            product.Stock = DataStore.MaxStockPerItem;
            DataStore.SaveInventory();
            DataStore.LogEvent("ADMIN_RESTOCK", $"{product.Name}: {oldStock} -> {product.Stock}");

            MessageBox.Show($"{product.Name} restocked to {DataStore.MaxStockPerItem}.",
                "Restock", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGrid(); RefreshSelectors(); SelectFromGrid(product.Id);
        }

        private void btnRestockAdd_Click(object sender, EventArgs e)
        {
            if (cboItem.SelectedItem is not ProductOption selected) return;
            var product = DataStore.Products.FirstOrDefault(p => p.Id == selected.Id);
            if (product == null) return;

            int qty = (int)nudRestockQty.Value;
            int oldStock = product.Stock;
            product.Stock = Math.Clamp(product.Stock + qty, 0, DataStore.MaxStockPerItem);
            DataStore.SaveInventory();
            DataStore.LogEvent("ADMIN_RESTOCK_ADD", $"{product.Name}: {oldStock} +{qty} -> {product.Stock}");

            MessageBox.Show($"{product.Name}: {oldStock} → {product.Stock}.",
                "Restock", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGrid(); RefreshSelectors(); SelectFromGrid(product.Id);
        }

        #endregion

        #region ── Add Item ──

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int? nextSlotId = Enumerable.Range(1, DataStore.MaxItemSlots)
                .FirstOrDefault(id => DataStore.Products.All(p => p.Id != id));

            if (nextSlotId == 0)
            {
                MessageBox.Show($"Max slots ({DataStore.MaxItemSlots}) reached.", "Add Item",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtAddName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DataStore.Products.Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Name must be unique.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboAddType.SelectedItem is not ProductType type) return;
            decimal price = nudAddPrice.Value;
            if (price <= 0m) return;

            int stock = Math.Clamp((int)nudAddStock.Value, 1, DataStore.MaxStockPerItem);
            string flavor = string.IsNullOrWhiteSpace(txtAddFlavor.Text) ? "No description available." : txtAddFlavor.Text.Trim();
            int newId = nextSlotId.Value;

            var newProduct = Product.Create(type, newId, name, price, stock, flavor,
                type == ProductType.Snack ? (int)nudAddCalories.Value : 0,
                type == ProductType.Drink ? (int)nudAddVolume.Value : 0);

            // Copy image if selected
            if (!string.IsNullOrWhiteSpace(_selectedImagePath) && File.Exists(_selectedImagePath))
            {
                try
                {
                    string relName = CsvStorage.CopyProductImage(_selectedImagePath, newId);
                    newProduct.ImagePath = relName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Image error: {ex.Message}", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            DataStore.Products.Add(newProduct);
            DataStore.SaveInventory();
            DataStore.LogEvent("ADMIN_ADD_ITEM", $"{newProduct.Name} ({newProduct.Type})", newProduct.Price);

            MessageBox.Show("Item added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset fields
            txtAddName.Clear();
            txtAddFlavor.Clear();
            nudAddPrice.Value = 1;
            nudAddStock.Value = DataStore.MaxStockPerItem;
            nudAddCalories.Value = 0;
            nudAddVolume.Value = 0;
            _selectedImagePath = null;
            lblImagePath.Text = "No image selected";
            if (picImagePreview.Image != null) { picImagePreview.Image.Dispose(); picImagePreview.Image = null; }
            UpdateTypeSpecificFields();

            RefreshGrid(); RefreshSelectors(); SelectFromGrid(newProduct.Id);
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            var selectedProduct = GetSelectedProductFromGrid();
            if (selectedProduct == null)
            {
                MessageBox.Show("Select an item from the grid to update.", "Update Item",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int targetId = (int)nudEditSlotId.Value;
            if (targetId < 1 || targetId > DataStore.MaxItemSlots)
            {
                MessageBox.Show($"Slot ID must be between 1 and {DataStore.MaxItemSlots}.", "Update Item",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (targetId != selectedProduct.Id && DataStore.Products.Any(p => p.Id == targetId))
            {
                MessageBox.Show($"Slot #{targetId} is already occupied.", "Update Item",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtAddName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DataStore.Products.Any(p => p.Id != selectedProduct.Id && p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Name must be unique.", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboAddType.SelectedItem is not ProductType type) return;
            decimal price = nudAddPrice.Value;
            if (price <= 0m)
            {
                MessageBox.Show("Price must be greater than zero.", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int stock = Math.Clamp((int)nudAddStock.Value, 0, DataStore.MaxStockPerItem);
            string flavor = string.IsNullOrWhiteSpace(txtAddFlavor.Text) ? "No description available." : txtAddFlavor.Text.Trim();

            string imagePath = selectedProduct.ImagePath;
            if (!string.IsNullOrWhiteSpace(_selectedImagePath) && File.Exists(_selectedImagePath))
            {
                try
                {
                    imagePath = CsvStorage.CopyProductImage(_selectedImagePath, targetId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Image error: {ex.Message}", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            var updatedProduct = Product.Create(type, targetId, name, price, stock, flavor,
                type == ProductType.Snack ? (int)nudAddCalories.Value : 0,
                type == ProductType.Drink ? (int)nudAddVolume.Value : 0,
                imagePath);
            updatedProduct.DbInventoryId = selectedProduct.DbInventoryId;

            int index = DataStore.Products.IndexOf(selectedProduct);
            if (index < 0) return;

            int oldId = selectedProduct.Id;
            DataStore.Products[index] = updatedProduct;
            DataStore.SaveInventory();
            DataStore.LogEvent("ADMIN_UPDATE_ITEM", $"{selectedProduct.Name} updated (slot {oldId} -> {updatedProduct.Id})", updatedProduct.Price);

            MessageBox.Show("Item updated.", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _selectedImagePath = null;
            RefreshGrid();
            RefreshSelectors();
            SelectFromGrid(updatedProduct.Id);
        }

        #endregion

        #region ── Remove / Log ──

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (cboRemoveItem.SelectedItem is not ProductOption selected) return;
            var product = DataStore.Products.FirstOrDefault(p => p.Id == selected.Id);
            if (product == null) return;

            if (MessageBox.Show($"Remove {product.Name}?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            DataStore.Products.Remove(product);
            DataStore.SaveInventory();
            DataStore.LogEvent("ADMIN_REMOVE_ITEM", product.Name);
            RefreshGrid(); RefreshSelectors(); SyncSelectorsFromGridSelection();
        }

        private void btnViewLog_Click(object sender, EventArgs e)
        {
            using var logForm = new EventLogForm();
            logForm.ShowDialog(this);
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear all logs?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            DataStore.ClearLogs();
            MessageBox.Show("Log cleared.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region ── Navigation ──

        private void btnBack_Click(object sender, EventArgs e) => this.Close();
        private void backMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            if (dlgOpenImage.ShowDialog(this) == DialogResult.OK)
            {
                _selectedImagePath = dlgOpenImage.FileName;
                lblImagePath.Text = Path.GetFileName(_selectedImagePath);
                LoadPreviewImage(_selectedImagePath);

                if (picImagePreview.Image == null)
                {
                    lblImagePath.Text = "Invalid image";
                    _selectedImagePath = null;
                }
            }
        }

        private void cboAddType_SelectedIndexChanged(object sender, EventArgs e) => UpdateTypeSpecificFields();

        private void UpdateTypeSpecificFields()
        {
            if (cboAddType.SelectedItem is not ProductType type) return;
            bool showCal = type == ProductType.Snack;
            bool showVol = type == ProductType.Drink;
            lblAddCalories.Visible = showCal; nudAddCalories.Visible = showCal;
            lblAddVolume.Visible = showVol; nudAddVolume.Visible = showVol;
            if (!showCal) nudAddCalories.Value = 0;
            if (!showVol) nudAddVolume.Value = 0;
        }

        private void adminHelpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Admin Tools:\n\n" +
                "• Restock items to max or add custom quantities\n" +
                "• Add/remove products with images\n" +
                "• View and clear event logs\n\n" +
                "Low stock items (≤2) shown in red.",
                "Admin Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openReadmeMenuItem_Click(object sender, EventArgs e)
        {
            using var readmeForm = new ReadmeForm();
            readmeForm.ShowDialog(this);
        }

        #endregion
    }
}
