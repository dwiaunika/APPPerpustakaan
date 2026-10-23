namespace AppPerpustakaan
{
    partial class UC_Koleksi
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            btnTambahBuku = new Button();
            dgvBuku = new DataGridView();
            colJudul = new DataGridViewTextBoxColumn();
            colPath = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBuku).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(33, 33, 33);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(284, 45);
            label1.TabIndex = 0;
            label1.Text = "Koleksi Buku PDF";
            // 
            // btnTambahBuku
            // 
            btnTambahBuku.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTambahBuku.BackColor = Color.RoyalBlue;
            btnTambahBuku.FlatAppearance.BorderSize = 0;
            btnTambahBuku.FlatStyle = FlatStyle.Flat;
            btnTambahBuku.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahBuku.ForeColor = Color.White;
            btnTambahBuku.Location = new Point(690, 47);
            btnTambahBuku.Name = "btnTambahBuku";
            btnTambahBuku.Size = new Size(130, 35);
            btnTambahBuku.TabIndex = 1;
            btnTambahBuku.Text = "+ Tambah Buku";
            btnTambahBuku.UseVisualStyleBackColor = false;
            btnTambahBuku.Click += btnTambahBuku_Click;
            // 
            // dgvBuku
            // 
            dgvBuku.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBuku.BackgroundColor = Color.White;
            dgvBuku.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBuku.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuku.Columns.AddRange(new DataGridViewColumn[] { colJudul, colPath });
            dgvBuku.EnableHeadersVisualStyles = false;
            dgvBuku.Location = new Point(20, 110);
            dgvBuku.Name = "dgvBuku";
            dgvBuku.RowHeadersWidth = 62;
            dgvBuku.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuku.Size = new Size(816, 560);
            dgvBuku.TabIndex = 2;
            dgvBuku.KeyDown += dgvBuku_KeyDown;
            // 
            // colJudul
            // 
            colJudul.HeaderText = "Judul Buku";
            colJudul.MinimumWidth = 8;
            colJudul.Name = "colJudul";
            // 
            // colPath
            // 
            colPath.HeaderText = "Path File";
            colPath.MinimumWidth = 8;
            colPath.Name = "colPath";
            // 
            // UC_Koleksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvBuku);
            Controls.Add(btnTambahBuku);
            Controls.Add(label1);
            Name = "UC_Koleksi";
            Size = new Size(960, 680);
            ((System.ComponentModel.ISupportInitialize)dgvBuku).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnTambahBuku;
        private DataGridView dgvBuku;
        private DataGridViewTextBoxColumn colJudul;
        private DataGridViewTextBoxColumn colPath;
    }
}
