using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPerpustakaan
{
    public partial class UC_MenuUtama : UserControl
    {
        public UC_MenuUtama()
        {
            InitializeComponent();
            MuatSemuaModul();
        }

        private void MuatSemuaModul()
        {
            // Masukkan UC_Koleksi ke Tab 1 (Koleksi Buku)
            UC_Koleksi ucKoleksi = new UC_Koleksi { Dock = DockStyle.Fill };
            tabPage1.Controls.Add(ucKoleksi);

            // Masukkan UC_Catatan ke Tab 2 (Catatan Membaca)
            UC_Catatan ucCatatan = new UC_Catatan { Dock = DockStyle.Fill };
            tabPage2.Controls.Add(ucCatatan);

            // Masukkan UC_Target ke Tab 3 (Target Membaca)
            UC_Target ucTarget = new UC_Target { Dock = DockStyle.Fill };
            tabPage3.Controls.Add(ucTarget);

            // Masukkan UC_Grafik ke Tab 4 (Grafik Statistik)
            UC_Grafik ucGrafik = new UC_Grafik { Dock = DockStyle.Fill };
            tabPage4.Controls.Add(ucGrafik);
        }
    }
}


