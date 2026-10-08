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
    public partial class upload_and_browseForm4 : Form
    {
        public upload_and_browseForm4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Upload_Papers frm = new Upload_Papers();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Past_Papers_Library frm = new Past_Papers_Library();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard(UserData.fullname);
            frm.Show();
            this.Hide();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard(UserData.fullname);
            frm.Show();
            this.Hide();
        }

        private void lblPastPapers_Click(object sender, EventArgs e)
        {
            upload_and_browseForm4 frm = new upload_and_browseForm4();
            frm.Show();
            this.Hide();
        }

        private void lblGroupmates_Click(object sender, EventArgs e)
        {
            Find_Groupmates frm = new Find_Groupmates();
            frm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Myprofile frm = new Myprofile();
            frm.Show();
            this.Hide();
        }
    }
}
