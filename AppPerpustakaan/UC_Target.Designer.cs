namespace AppPerpustakaan
{
    partial class UC_Target
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
            lblJudul = new Label();
            lblTargetBuku = new Label();
            txtTargetBuku = new TextBox();
            btnSimpanTarget = new Button();
            progressBarTarget = new ProgressBar();
            lblPersen = new Label();
            lblProgres = new Label();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.FromArgb(33, 33, 33);
            lblJudul.Location = new Point(20, 20);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(356, 45);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Target Membaca Buku";
            // 
            // lblTargetBuku
            // 
            lblTargetBuku.AutoSize = true;
            lblTargetBuku.Font = new Font("Segoe UI", 10F);
            lblTargetBuku.ForeColor = Color.FromArgb(64, 64, 64);
            lblTargetBuku.Location = new Point(35, 100);
            lblTargetBuku.Name = "lblTargetBuku";
            lblTargetBuku.Size = new Size(189, 28);
            lblTargetBuku.TabIndex = 1;
            lblTargetBuku.Text = "Target Jumlah Buku :";
            // 
            // txtTargetBuku
            // 
            txtTargetBuku.Location = new Point(236, 100);
            txtTargetBuku.Name = "txtTargetBuku";
            txtTargetBuku.Size = new Size(150, 31);
            txtTargetBuku.TabIndex = 2;
            // 
            // btnSimpanTarget
            // 
            btnSimpanTarget.BackColor = Color.FromArgb(0, 122, 255);
            btnSimpanTarget.FlatAppearance.BorderSize = 0;
            btnSimpanTarget.FlatStyle = FlatStyle.Flat;
            btnSimpanTarget.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSimpanTarget.ForeColor = Color.White;
            btnSimpanTarget.Location = new Point(413, 100);
            btnSimpanTarget.Name = "btnSimpanTarget";
            btnSimpanTarget.Size = new Size(130, 35);
            btnSimpanTarget.TabIndex = 3;
            btnSimpanTarget.Text = "Simpan";
            btnSimpanTarget.UseVisualStyleBackColor = false;
            // 
            // progressBarTarget
            // 
            progressBarTarget.Location = new Point(20, 189);
            progressBarTarget.Name = "progressBarTarget";
            progressBarTarget.Size = new Size(500, 25);
            progressBarTarget.TabIndex = 4;
            // 
            // lblPersen
            // 
            lblPersen.AutoSize = true;
            lblPersen.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersen.ForeColor = Color.FromArgb(33, 33, 33);
            lblPersen.Location = new Point(530, 183);
            lblPersen.Name = "lblPersen";
            lblPersen.Size = new Size(148, 28);
            lblPersen.TabIndex = 5;
            lblPersen.Text = "0/0 Buku (0%)";
            // 
            // lblProgres
            // 
            lblProgres.AutoSize = true;
            lblProgres.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgres.ForeColor = Color.FromArgb(64, 64, 64);
            lblProgres.Location = new Point(20, 152);
            lblProgres.Name = "lblProgres";
            lblProgres.Size = new Size(224, 30);
            lblProgres.TabIndex = 6;
            lblProgres.Text = "Progres Pencapaian:";
            // 
            // UC_Target
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblProgres);
            Controls.Add(lblPersen);
            Controls.Add(progressBarTarget);
            Controls.Add(btnSimpanTarget);
            Controls.Add(txtTargetBuku);
            Controls.Add(lblTargetBuku);
            Controls.Add(lblJudul);
            Name = "UC_Target";
            Size = new Size(960, 680);
            Load += UC_Target_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblTargetBuku;
        private TextBox txtTargetBuku;
        private Button btnSimpanTarget;
        private ProgressBar progressBarTarget;
        private Label lblPersen;
        private Label lblProgres;
    }
}
