

namespace Eco_Matic_Winforms
{
    public partial class MainForm : Form
    {
        private const string AdminPassword = "admin123";
        private readonly Data.ArduinoService _arduino;
        private bool _isHandlingScan;

        public MainForm()
        {
            InitializeComponent();
            UpdateExitButton();

            _arduino = new Data.ArduinoService("COM5", 9600);
            _arduino.OnCardScanned += Arduino_OnCardScanned;
            _arduino.Start();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _arduino.Stop();
            base.OnFormClosed(e);
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
            _arduino.SendStateCommand("STATE:ACTIVE");
            var customerForm = new CustomerForm(DataStore.ActiveCustomerRfid);
            customerForm.FormClosed += (s, args) =>
            {
                _arduino.SendStateCommand("STATE:AFK");
                DataStore.ClearActiveCustomer();
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

        private void Arduino_OnCardScanned(object? sender, string rfid)
        {
            if (_isHandlingScan || IsDisposed)
            {
                return;
            }

            _isHandlingScan = true;

            try
            {
                BeginInvoke(new Action(() =>
                {
                    try
                    {
                        if (DataStore.CustomerExists(rfid))
                        {
                            _arduino.SendResponse(true);
                            DataStore.SetActiveCustomer(rfid);
                            using var dashboard = new CustomerDashboardForm(rfid);
                            dashboard.ShowDialog(this);
                        }
                        else
                        {
                            _arduino.SendResponse(false);
                            using var register = new CustomerRegistrationForm(rfid);
                            if (register.ShowDialog(this) == DialogResult.OK)
                            {
                                DataStore.SetActiveCustomer(rfid);
                                using var dashboard = new CustomerDashboardForm(rfid);
                                dashboard.ShowDialog(this);
                            }
                            else
                            {
                                DataStore.ClearActiveCustomer();
                            }
                        }

                        UpdateExitButton();
                    }
                    finally
                    {
                        _isHandlingScan = false;
                    }
                }));
            }
            catch
            {
                _isHandlingScan = false;
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
