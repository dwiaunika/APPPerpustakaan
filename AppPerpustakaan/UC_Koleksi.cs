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
    public partial class UC_Koleksi : UserControl
    {
        public UC_Koleksi()
        {
            InitializeComponent();
        }

        private void dgvBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTambahBuku_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                openFileDialog.Title = "Pilih Buku PDF";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileName = System.IO.Path.GetFileNameWithoutExtension(filePath);

                    dgvBuku.Rows.Add(fileName, filePath);
                    MessageBox.Show("Buku berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvBuku_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgvBuku.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin menghapus buku ini dari daftar?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvBuku.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            dgvBuku.Rows.Remove(row);
                        }
                    }
                }
            }
        }
    }
}
