using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IwsHub2
{
    public partial class Req_Password : Form
    {
        private int expectedOTP;

        public bool IsOTPVerified { get; private set; } = false;

        public Req_Password(int otp)
        {
            InitializeComponent();

            expectedOTP = otp;
        }
        public Req_Password()
        {
            InitializeComponent();
        }

        private void btncontinue_Click(object sender, EventArgs e)
        {
 
            SqlConnection con = Database.GetConnection();

            try
            {
                con.Open();

                string query = "SELECT FullName FROM Users WHERE StudentNumber=@StudentNumber";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@StudentNumber", txtstudentno.Text.Trim());

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                if (reader.Read())
                {
                    Random rnd = new Random();
                    int otp = rnd.Next(100000, 999999);

                    MessageBox.Show(
                        "Demo OTP: " + otp,
                        "OTP Verification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    OTP_Verify frm = new OTP_Verify(otp);

                    frm.ShowDialog();

                    if (frm.IsOTPVerified)
                    {
                        Password_Reset reset = new Password_Reset(txtstudentno.Text.Trim());

                        reset.Show();

                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Student number not found.");
                }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblback_Click(object sender, EventArgs e)
        {
            Login_Page frm = new Login_Page();
            frm.Show();
            this.Hide();
        }
    }
   
}
