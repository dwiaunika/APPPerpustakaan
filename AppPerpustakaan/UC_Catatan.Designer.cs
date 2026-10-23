namespace AppPerpustakaan
{
    partial class UC_Catatan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtJudulCatatan = new TextBox();
            txtIsiCatatan = new TextBox();
            btnSimpanCatatan = new Button();
            dgvCatatan = new DataGridView();
            colJudul = new DataGridViewTextBoxColumn();
            colIsi = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCatatan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(220, 45);
            label1.TabIndex = 0;
            label1.Text = "Catatan Buku";
            // 
            // txtJudulCatatan
            // 
            txtJudulCatatan.Location = new Point(20, 70);
            txtJudulCatatan.Name = "txtJudulCatatan";
            txtJudulCatatan.Size = new Size(300, 31);
            txtJudulCatatan.TabIndex = 1;
            txtJudulCatatan.Text = "Judul Catatan";
            // 
            // txtIsiCatatan
            // 
            txtIsiCatatan.BorderStyle = BorderStyle.FixedSingle;
            txtIsiCatatan.Font = new Font("Segoe UI", 9.7F);
            txtIsiCatatan.Location = new Point(20, 110);
            txtIsiCatatan.Multiline = true;
            txtIsiCatatan.Name = "txtIsiCatatan";
            txtIsiCatatan.Size = new Size(300, 180);
            txtIsiCatatan.TabIndex = 2;
            txtIsiCatatan.Text = "Isi Catatan";
            // 
            // btnSimpanCatatan
            // 
            btnSimpanCatatan.BackColor = Color.FromArgb(0, 122, 255);
            btnSimpanCatatan.FlatAppearance.BorderSize = 0;
            btnSimpanCatatan.FlatStyle = FlatStyle.Flat;
            btnSimpanCatatan.Font = new Font("Segoe UI", 9.7F, FontStyle.Bold);
            btnSimpanCatatan.ForeColor = Color.White;
            btnSimpanCatatan.Location = new Point(20, 300);
            btnSimpanCatatan.Name = "btnSimpanCatatan";
            btnSimpanCatatan.Size = new Size(300, 40);
            btnSimpanCatatan.TabIndex = 3;
            btnSimpanCatatan.Text = "Simpan Catatan";
            btnSimpanCatatan.UseVisualStyleBackColor = false;
            btnSimpanCatatan.Click += btnSimpanCatatan_Click;
            // 
            // dgvCatatan
            // 
            dgvCatatan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCatatan.BackgroundColor = Color.White;
            dgvCatatan.BorderStyle = BorderStyle.None;
            dgvCatatan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatatan.Columns.AddRange(new DataGridViewColumn[] { colJudul, colIsi });
            dgvCatatan.EnableHeadersVisualStyles = false;
            dgvCatatan.Location = new Point(340, 74);
            dgvCatatan.Name = "dgvCatatan";
            dgvCatatan.RowHeadersWidth = 62;
            dgvCatatan.Size = new Size(400, 270);
            dgvCatatan.TabIndex = 4;
            dgvCatatan.KeyDown += dgvCatatan_KeyDown;
            // 
            // colJudul
            // 
            colJudul.HeaderText = "Judul Catatan";
            colJudul.MinimumWidth = 8;
            colJudul.Name = "colJudul";
            // 
            // colIsi
            // 
            colIsi.HeaderText = "Isi Catatan";
            colIsi.MinimumWidth = 8;
            colIsi.Name = "colIsi";
            // 
            // UC_Catatan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvCatatan);
            Controls.Add(btnSimpanCatatan);
            Controls.Add(txtIsiCatatan);
            Controls.Add(txtJudulCatatan);
            Controls.Add(label1);
            Name = "UC_Catatan";
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)dgvCatatan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtJudulCatatan;
        private Button btnSimpanCatatan;
        private DataGridView dgvCatatan;
        private DataGridViewTextBoxColumn colJudul;
        private DataGridViewTextBoxColumn colIsi;
        protected internal TextBox txtIsiCatatan;
    }
}