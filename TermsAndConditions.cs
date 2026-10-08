using System;
using System.Windows.Forms;

namespace IwsHub2
{
    public partial class TermsAndConditionsForm4 : Form
    {
        public TermsAndConditionsForm4()
        {
            InitializeComponent();

            // Load the Terms and Conditions
            LoadTermsAndConditions();

            // Start with Accept disabled
            btnaccept.Enabled = false;
        }

        // =========================================================
        // LOAD TERMS AND CONDITIONS
        // =========================================================

        private void LoadTermsAndConditions()
        {
            rtbTerms.Clear();

            rtbTerms.AppendText(
                "IWS HUB - TERMS AND CONDITIONS\r\n" +
                "========================================\r\n\r\n");

            rtbTerms.AppendText(
                "1. ACCEPTANCE OF TERMS\r\n\r\n" +
                "By creating and using an IWS Hub account, you agree to " +
                "follow these Terms and Conditions. If you do not agree " +
                "to these terms, you should not create or use an account.\r\n\r\n");

            rtbTerms.AppendText(
                "2. PURPOSE OF IWS HUB\r\n\r\n" +
                "IWS Hub is a student-focused academic system designed " +
                "to help students access academic resources, share " +
                "relevant information and find students for academic " +
                "group work.\r\n\r\n");

            rtbTerms.AppendText(
                "3. ACCOUNT INFORMATION\r\n\r\n" +
                "Students are responsible for providing accurate " +
                "information when creating an account. Students must " +
                "keep their login information private.\r\n\r\n");

            rtbTerms.AppendText(
                "4. ACADEMIC MATERIALS\r\n\r\n" +
                "Users should only upload academic materials that they " +
                "are permitted to share. Materials uploaded to IWS Hub " +
                "should be relevant to the academic purpose of the system.\r\n\r\n");

            rtbTerms.AppendText(
                "5. GROUP FINDER\r\n\r\n" +
                "Information posted through the Group Finder should be " +
                "used for legitimate academic purposes. Users must " +
                "communicate respectfully with other students.\r\n\r\n");

            rtbTerms.AppendText(
                "6. PROHIBITED CONTENT\r\n\r\n" +
                "Users must not upload or post abusive, threatening, " +
                "discriminatory, inappropriate, misleading or unrelated " +
                "content.\r\n\r\n");

            rtbTerms.AppendText(
                "7. REPORTING CONTENT\r\n\r\n" +
                "Users should report inappropriate or incorrect content " +
                "to the system administrator. Administrators may review " +
                "and remove content that violates these terms.\r\n\r\n");

            rtbTerms.AppendText(
                "8. ADMINISTRATION\r\n\r\n" +
                "Administrators may manage student accounts, academic " +
                "resources and posts to maintain appropriate use of " +
                "the system.\r\n\r\n");

            rtbTerms.AppendText(
                "9. PRIVACY\r\n\r\n" +
                "Users should only provide information necessary for " +
                "the operation of the system. Users should not share " +
                "another person's private information without permission.\r\n\r\n");

            rtbTerms.AppendText(
                "10. RESPONSIBLE USE\r\n\r\n" +
                "IWS Hub must be used responsibly and for its intended " +
                "academic purpose. Users are responsible for the information " +
                "they submit or upload.\r\n\r\n");

            rtbTerms.AppendText(
                "11. SYSTEM AVAILABILITY\r\n\r\n" +
                "IWS Hub is a student-developed academic project. " +
                "System availability may depend on the application's " +
                "environment and database configuration.\r\n\r\n");

            rtbTerms.AppendText(
                "12. CHANGES TO THESE TERMS\r\n\r\n" +
                "These Terms and Conditions may be updated when necessary " +
                "to improve the system or its functionality.\r\n\r\n");

            rtbTerms.AppendText(
                "13. AGREEMENT\r\n\r\n" +
                "By selecting 'I Accept', you confirm that you have read " +
                "and understood these Terms and Conditions and agree to " +
                "use IWS Hub responsibly.\r\n\r\n");

            // Put the cursor at the beginning
            rtbTerms.SelectionStart = 0;
            rtbTerms.SelectionLength = 0;
        }

        // =========================================================
        // CHECKBOX
        // =========================================================

        private void chkAccept_CheckedChanged(object sender, EventArgs e)
        {
            // Accept button only becomes available when checkbox is ticked
            btnaccept.Enabled = chkAccept.Checked;
        }

        // =========================================================
        // ACCEPT BUTTON
        // =========================================================

        private void btnaccept_Click(object sender, EventArgs e)
        {
            if (!chkAccept.Checked)
            {
                MessageBox.Show(
                    "Please tick 'I Accept' before continuing.",
                    "Terms and Conditions",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            MessageBox.Show(
                "Terms and Conditions accepted.",
                "Accepted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Open your actual Sign Up form
            Sign_Up signup = new Sign_Up();

            signup.Show();

            this.Hide();
        }

        // =========================================================
        // DECLINE BUTTON
        // =========================================================

        private void btndecline_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "You must accept the Terms and Conditions " +
                "to create an account.\r\n\r\n" +
                "Do you want to leave this page?",
                "Terms and Conditions",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // =========================================================
        // EMPTY DESIGNER EVENTS
        // =========================================================

        private void lbltitle_Click(object sender, EventArgs e)
        {
            this.lbltitle.Text = "IWS HUB - Terms and Conditions";
        }

        private void rtbTerms_TextChanged(object sender, EventArgs e)
        {
            // Nothing required here
        }

        private void TermsAndConditionsForm4_Load(object sender, EventArgs e)
        {

        }
    }
}