namespace Eco_Matic_Winforms
{
    public partial class CustomerDashboardForm : Form
    {
        private readonly string _rfid;

        public CustomerDashboardForm(string rfid)
        {
            InitializeComponent();
            _rfid = rfid;
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            DataStore.SetActiveCustomer(_rfid);

            var info = DataStore.GetCustomerInfo(_rfid);

            if (DataStore.PendingPoints > 0)
            {
                int pointsToSave = DataStore.PendingPoints;
                int updatedBalance = info.EcoCredits + pointsToSave;

                if (DataStore.UpdateCustomerCredits(_rfid, updatedBalance))
                {
                    DataStore.LogEvent("POINTS_SAVED", $"{pointsToSave} points saved via RFID ({_rfid})", pointsToSave);
                    MessageBox.Show($"Saved {pointsToSave} points to this RFID account.", "Points Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataStore.PendingPoints = 0;
                }
                else
                {
                    MessageBox.Show("Could not save recycled points right now. Please tap again.", "Points Save Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // Re-read from storage so the UI always reflects the latest saved total.
            var refreshedInfo = DataStore.GetCustomerInfo(_rfid);

            lblRfidValue.Text = _rfid;
            lblEmailValue.Text = string.IsNullOrWhiteSpace(refreshedInfo.Email) ? "Guest" : refreshedInfo.Email;
            lblPointsValue.Text = refreshedInfo.EcoCredits.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
