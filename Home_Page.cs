using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IwsHub2
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            // Initialises the UI elements configured in your Designer properties
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            // Launch the unified Student Login/Sign-Up portal
            Login_Page ftm = new Login_Page();
            ftm.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Launch the standalone Administration entry point
            Admin_Login ftm = new Admin_Login();
            ftm.Show();
            this.Hide();
        }

        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {
            // Keep this block open for your custom Figma corner rounding injection
        }
    }
}
