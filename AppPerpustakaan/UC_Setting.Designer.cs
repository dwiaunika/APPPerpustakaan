namespace AppPerpustakaan
{
    partial class UC_Setting
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
            txtNamaTag = new GroupBox();
            lblKategoriBaru = new Label();
            textnamaTag = new TextBox();
            btnTambahTag = new Button();
            lblDaftarKategori = new Label();
            lstDaftarTag = new ListBox();
            btnHapusTag = new Button();
            txtNamaTag.SuspendLayout();
            SuspendLayout();
            // 
            // txtNamaTag
            // 
            txtNamaTag.Controls.Add(btnHapusTag);
            txtNamaTag.Controls.Add(lstDaftarTag);
            txtNamaTag.Controls.Add(lblDaftarKategori);
            txtNamaTag.Controls.Add(btnTambahTag);
            txtNamaTag.Controls.Add(textnamaTag);
            txtNamaTag.Controls.Add(lblKategoriBaru);
            txtNamaTag.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNamaTag.Location = new Point(21, 57);
            txtNamaTag.Name = "txtNamaTag";
            txtNamaTag.Size = new Size(320, 280);
            txtNamaTag.TabIndex = 0;
            txtNamaTag.TabStop = false;
            txtNamaTag.Text = "Kategori";
            // 
            // lblKategoriBaru
            // 
            lblKategoriBaru.AutoSize = true;
            lblKategoriBaru.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKategoriBaru.Location = new Point(15, 30);
            lblKategoriBaru.Name = "lblKategoriBaru";
            lblKategoriBaru.Size = new Size(127, 25);
            lblKategoriBaru.TabIndex = 0;
            lblKategoriBaru.Text = "Kategori Baru :";
            // 
            // textnamaTag
            // 
            textnamaTag.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textnamaTag.Location = new Point(15, 58);
            textnamaTag.Name = "textnamaTag";
            textnamaTag.Size = new Size(190, 31);
            textnamaTag.TabIndex = 1;
            // 
            // btnTambahTag
            // 
            btnTambahTag.BackColor = Color.DodgerBlue;
            btnTambahTag.FlatAppearance.BorderSize = 0;
            btnTambahTag.FlatStyle = FlatStyle.Flat;
            btnTambahTag.ForeColor = Color.White;
            btnTambahTag.Location = new Point(215, 58);
            btnTambahTag.Name = "btnTambahTag";
            btnTambahTag.Size = new Size(99, 31);
            btnTambahTag.TabIndex = 2;
            btnTambahTag.Text = "Tambah";
            btnTambahTag.UseVisualStyleBackColor = false;
            // 
            // lblDaftarKategori
            // 
            lblDaftarKategori.AutoSize = true;
            lblDaftarKategori.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDaftarKategori.Location = new Point(15, 90);
            lblDaftarKategori.Name = "lblDaftarKategori";
            lblDaftarKategori.Size = new Size(141, 25);
            lblDaftarKategori.TabIndex = 3;
            lblDaftarKategori.Text = "Daftar Kategori :";
            // 
            // lstDaftarTag
            // 
            lstDaftarTag.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstDaftarTag.FormattingEnabled = true;
            lstDaftarTag.ItemHeight = 25;
            lstDaftarTag.Location = new Point(15, 117);
            lstDaftarTag.Name = "lstDaftarTag";
            lstDaftarTag.Size = new Size(285, 104);
            lstDaftarTag.TabIndex = 4;
            // 
            // btnHapusTag
            // 
            btnHapusTag.BackColor = Color.Crimson;
            btnHapusTag.FlatAppearance.BorderSize = 0;
            btnHapusTag.FlatStyle = FlatStyle.Flat;
            btnHapusTag.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapusTag.ForeColor = Color.White;
            btnHapusTag.Location = new Point(15, 239);
            btnHapusTag.Name = "btnHapusTag";
            btnHapusTag.Size = new Size(285, 35);
            btnHapusTag.TabIndex = 5;
            btnHapusTag.Text = "Hapus Kategori";
            btnHapusTag.UseVisualStyleBackColor = false;
            // 
            // UC_Setting
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtNamaTag);
            Name = "UC_Setting";
            Size = new Size(960, 680);
            txtNamaTag.ResumeLayout(false);
            txtNamaTag.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox txtNamaTag;
        private Label lblKategoriBaru;
        private Button btnTambahTag;
        private TextBox textnamaTag;
        private Label lblDaftarKategori;
        private Button btnHapusTag;
        private ListBox lstDaftarTag;
    }
}
