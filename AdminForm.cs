

namespace Eco_Matic_Winforms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            RefreshGrid();
            RefreshCombo();
        }


        private void RefreshGrid()
        {
            inventoryGrid.Columns.Clear();
            inventoryGrid.Rows.Clear();

            // add column
            string[] columnHeaders = { "Item Name", "Price (₱)", "Stock" };
            string[] columnNames   = { "Name", "Price", "Stock" };

            for (int c = 0; c < columnHeaders.Length; c++)
            {
                inventoryGrid.Columns.Add(columnNames[c], columnHeaders[c]);
            }

            // 2d array
            int rowCount = DataStore.Products.Count;
            int colCount = columnHeaders.Length;
            string[,] data = new string[rowCount, colCount];

            for (int r = 0; r < rowCount; r++)
            {
                data[r, 0] = DataStore.Products[r].Name;
                data[r, 1] = $"₱{DataStore.Products[r].Price:F2}";
                data[r, 2] = DataStore.Products[r].Stock.ToString();
            }

            // rows
            for (int r = 0; r < rowCount; r++)
            {
                int idx = inventoryGrid.Rows.Add(data[r, 0], data[r, 1], data[r, 2]);

                // red low stock items
                if (DataStore.Products[r].Stock <= 2)
                {
                    inventoryGrid.Rows[idx].Cells[2].Style.ForeColor = Color.Red;
                    inventoryGrid.Rows[idx].Cells[2].Style.Font =
                        new Font("Segoe UI", 10, FontStyle.Bold);
                }
            }
        }

        private void RefreshCombo()
        {
            cboItem.Items.Clear();
            foreach (var p in DataStore.Products)
                cboItem.Items.Add(p.Name);
            if (cboItem.Items.Count > 0)
                cboItem.SelectedIndex = 0;
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cboItem.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an item from the dropdown first.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboItem.SelectedItem is not string selectedName)
            {
                MessageBox.Show("Selected item is invalid. Please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = DataStore.Products.FirstOrDefault(p => p.Name == selectedName);
            if (product == null) return;

            int qty = (int)nudQty.Value;
            product.Stock += qty;

            MessageBox.Show($"{product.Name} restocked by {qty}.\nNew stock: {product.Stock}",
                "Restock Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGrid();
        }

        private void btnBack_Click(object sender, EventArgs e) => this.Close();

        
        private void backMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void adminHelpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "View current stock levels in the grid above.\n\n" +
                "Select an item and quantity, then click UPDATE STOCK to restock.\n\n" +
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
