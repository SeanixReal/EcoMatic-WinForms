namespace Eco_Matic_Winforms
{
    public partial class CustomerRegistrationForm : Form
    {
        private readonly string _rfid;

        public CustomerRegistrationForm(string rfid)
        {
            InitializeComponent();
            _rfid = rfid;
            txtRfid.Text = _rfid;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string pass = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Please enter both email and password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DataStore.RegisterCustomer(_rfid, email, pass))
            {
                MessageBox.Show("Registration successful. You can now save Eco-Points to this RFID card.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            MessageBox.Show("Registration failed. This email may already be used.", "Database Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
