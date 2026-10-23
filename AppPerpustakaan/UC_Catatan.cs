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
    public partial class UC_Catatan : UserControl
    {
        public UC_Catatan()
        {
            InitializeComponent();
        }

        private void btnSimpanCatatan_Click(object sender, EventArgs e)
        {
            string judul = txtJudulCatatan.Text.Trim();
            string isi = txtIsiCatatan.Text.Trim();

            if (string.IsNullOrEmpty(judul) || string.IsNullOrEmpty(isi))
            {
                MessageBox.Show("Judul dan isi catatan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvCatatan.Rows.Add(judul, isi);

            txtJudulCatatan.Clear();
            txtIsiCatatan.Clear();
            txtJudulCatatan.Focus();
        }

        private void dgvCatatan_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back) && dgvCatatan.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin menghapus catatan ini?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvCatatan.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            dgvCatatan.Rows.Remove(row);
                        }
                    }
                }
            }   
        }
    }
}
