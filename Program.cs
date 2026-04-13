namespace Eco_Matic_Winforms
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            try
            {
                DataStore.Initialize();

                if (args.Any(a => a.Equals("--migrate", StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show(
                        "Database migration completed successfully.",
                        "Eco-Matic Migration",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to initialize Eco-Matic database.\n\n" + ex.Message,
                    "Startup Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Application.Run(new MainForm());
        }
    }
}