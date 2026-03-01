

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

            RefreshGridUsingArray();   
            // RefreshGridUsingList();
            RefreshCombo();
        }


        private void RefreshGridUsingArray()
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

        private void RefreshGridUsingList()
        {
            inventoryGrid.Columns.Clear();
            inventoryGrid.Rows.Clear();

            // add columns
            List<string[]> columnDefs = new List<string[]>
            {
                new string[] { "Name",  "Item Name"  },
                new string[] { "Price", "Price (₱)"  },
                new string[] { "Stock", "Stock"      }
            };

            foreach (string[] col in columnDefs)
            {
                inventoryGrid.Columns.Add(col[0], col[1]);
            }

            // row
            List<object[]> rows = new List<object[]>();

            foreach (Product p in DataStore.Products)
            {
                rows.Add(new object[] { p.Name, $"₱{p.Price:F2}", p.Stock });
            }

            // add rows
            for (int i = 0; i < rows.Count; i++)
            {
                int idx = inventoryGrid.Rows.Add(rows[i]);

                // low stock item red
                if (DataStore.Products[i].Stock <= 2)
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
                MessageBox.Show("Please select an item.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedName = cboItem.SelectedItem.ToString();
            var product = DataStore.Products.FirstOrDefault(p => p.Name == selectedName);
            if (product == null) return;

            int qty = (int)nudQty.Value;
            product.Stock += qty;

            MessageBox.Show($"{product.Name} restocked by {qty}.\nNew stock: {product.Stock}",
                "Restock Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGridUsingArray(); // Use the same method as OnLoad
        }

        private void btnBack2_Click(object sender, EventArgs e) => this.Close();

        
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
