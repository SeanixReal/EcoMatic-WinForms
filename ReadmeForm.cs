namespace Eco_Matic_Winforms
{
    public partial class ReadmeForm : Form
    {
        public ReadmeForm()
        {
            InitializeComponent();
            txtContent.SelectionStart = 0;
            txtContent.SelectionLength = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
