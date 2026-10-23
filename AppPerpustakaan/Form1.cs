using System;
using System.Runtime;
using System.Windows.Forms;

namespace AppPerpustakaan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Memastikan pnlSidebar terkunci di kiri dan pnlContent memenuhi sisa layar
            pnlSidebar.Dock = DockStyle.Left;
            pnlContent.Dock = DockStyle.Fill;

            // Tampilan awal langsung ke Dashboard
            ShowUserControl(new UC_Dashbord());
        }

        private void ShowUserControl(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_Dashbord());
        }

        private void btnMenuUtama_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_MenuUtama());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_Setting());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ShowUserControl(new UC_About());
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenuUtama_Click_1(object sender, EventArgs e)
        {
            ShowUserControl(new UC_MenuUtama());
        }

        private void btnsettings_Click_1(object sender, EventArgs e)
        {
            ShowUserControl(new UC_Setting());
        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            ShowUserControl(new UC_About());
        }
    }
}