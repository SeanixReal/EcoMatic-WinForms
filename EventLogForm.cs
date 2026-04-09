namespace Eco_Matic_Winforms
{
    public partial class EventLogForm : Form
    {
        public EventLogForm()
        {
            InitializeComponent();
            LoadLogs();
        }

        private void LoadLogs()
        {
            var logs = DataStore.ReadLogs();
            if (logs.Count == 0)
            {
                txtLog.Text = "No logs found.";
                return;
            }

            txtLog.Lines = logs
                .Select(x => $"[{x.TimestampUtc:yyyy-MM-dd HH:mm:ss} UTC] {x.EventType} | {x.Details} | ₱{x.Amount:F2}")
                .ToArray();
            txtLog.SelectionStart = 0;
            txtLog.SelectionLength = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
