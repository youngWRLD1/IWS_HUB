using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IwsHub2
{
    public partial class Dashboard : Form
    {
        public Dashboard(string studentname)
        {
            InitializeComponent();
            // CHANGED: Logout button had no Click event in the designer.
            btnback.Click += btnback_Click;

            lblWelcome.Text = studentname;

            // Register painting hooks to inject the Figma edge paths
            HookUpFigmaStyles();
        }

        private void btnpaper_Click(object sender, EventArgs e)
        {
            upload_and_browseForm4 frm = new upload_and_browseForm4();
            frm.Show();
            this.Hide();
        }

        private void btnfinder_Click(object sender, EventArgs e)
        {
            Find_Groupmates frm = new Find_Groupmates();
            frm.Show();
            this.Hide();
        }

        private void HookUpFigmaStyles()
        {
            // Connect controls directly to our centralized rounding logic
            pnlPastPapersCard.Paint += (s, e) => ApplyFigmaRounding(pnlPastPapersCard, e.Graphics, 16);
            pnlGroupmatesCard.Paint += (s, e) => ApplyFigmaRounding(pnlGroupmatesCard, e.Graphics, 16);

            picPastPapersIcon.Paint += (s, e) => ApplyFigmaRounding(picPastPapersIcon, e.Graphics, 16);
            picGroupmatesIcon.Paint += (s, e) => ApplyFigmaRounding(picGroupmatesIcon, e.Graphics, 16);

            btnpaper.Paint += (s, e) => ApplyFigmaButtonRounding(btnpaper, e.Graphics, 8);
            btnfinder.Paint += (s, e) => ApplyFigmaButtonRounding(btnfinder, e.Graphics, 8);
        }
        private void ApplyFigmaRounding(Control ctrl, Graphics g, int radius)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, ctrl.Width, ctrl.Height);

            using (GraphicsPath path = GetRoundedRectanglePath(rect, radius))
            {
                ctrl.Region = new Region(path);
            }
        }

        private void ApplyFigmaButtonRounding(Button btn, Graphics g, int radius)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);

            using (GraphicsPath path = GetRoundedRectanglePath(rect, radius))
            {
                btn.Region = new Region(path);

                // Redraw internal button text cleanly over custom surface
                TextRenderer.DrawText(g, btn.Text, btn.Font, rect, btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            UserData.Clear();
            Home_Page home = new Home_Page();
            home.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {
            Myprofile frm = new Myprofile();
            frm.Show();
            this.Hide();
        }
    }
}
