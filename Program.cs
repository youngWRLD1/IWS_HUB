using System;
using System.Windows.Forms;

namespace IwsHub2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                // Verify the selected SQL Server database and create missing tables.
                Database.Initialize();
                Application.Run(new Home_Page());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "IWS Hub could not connect to the database.\n\n" + ex.Message +
                    "\n\nCheck App.config, SQL Server, and make sure the IWS Hub database exists.",
                    "Database Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
