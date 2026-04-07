

namespace Eco_Matic_Winforms
{
    public partial class MainForm : Form
    {
        private const string AdminPassword = "admin123";

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateExitButton()
        {
            if (DataStore.LastTransaction != null)
            {
                btnExit.Text = "GET RECEIPT && EXIT";
                btnExit.BackColor = Color.FromArgb(41, 128, 185);
            }
            else
            {
                btnExit.Text = "EXIT";
                btnExit.BackColor = Color.FromArgb(192, 57, 43);
            }
        }

        
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            var customerForm = new CustomerForm();
            customerForm.FormClosed += (s, args) =>
            {
                this.Show();
                UpdateExitButton();
            };
            customerForm.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            using var login = new LoginForm();
            if (login.ShowDialog(this) == DialogResult.OK)
            {
                if (login.Password == AdminPassword)
                {
                    this.Hide();
                    var adminForm = new AdminForm();
                    adminForm.FormClosed += (s, args) => this.Show();
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect password!", "Access Denied",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (DataStore.LastTransaction != null)
            {
                using var receipt = new ReceiptForm(DataStore.LastTransaction);
                receipt.ShowDialog(this);
                DataStore.LastTransaction = null;
                Application.Exit();
            }
            else
            {
                var result = MessageBox.Show("Are you sure you want to exit?", "Exit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    Application.Exit();
            }
        }



        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eco-Matic Vending Machine\nVersion 1.0\n\n\u00a9 2026 Seanix",
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openReadmeMenuItem_Click(object sender, EventArgs e)
        {
            using var readmeForm = new ReadmeForm();
            readmeForm.ShowDialog(this);
        }
    }
}
