namespace AppPerpustakaan
{
    partial class UC_Grafik
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
            lblFilter = new Label();
            cmbPriode = new ComboBox();
            pnlChartContainer = new Panel();
            lblPlaceholderGrafik = new Label();
            pnlChartContainer.SuspendLayout();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(30, 25);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(407, 45);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Grafik Aktivitas Membaca";
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(554, 37);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(72, 25);
            lblFilter.TabIndex = 1;
            lblFilter.Text = "Priode :";
            // 
            // cmbPriode
            // 
            cmbPriode.FormattingEnabled = true;
            cmbPriode.Items.AddRange(new object[] { "Bulan Ini ", "Tahun Ini", "Semua Ini" });
            cmbPriode.Location = new Point(626, 34);
            cmbPriode.Name = "cmbPriode";
            cmbPriode.Size = new Size(240, 33);
            cmbPriode.TabIndex = 2;
            // 
            // pnlChartContainer
            // 
            pnlChartContainer.BackColor = Color.LightGray;
            pnlChartContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlChartContainer.Controls.Add(lblPlaceholderGrafik);
            pnlChartContainer.Location = new Point(35, 90);
            pnlChartContainer.Name = "pnlChartContainer";
            pnlChartContainer.Size = new Size(895, 560);
            pnlChartContainer.TabIndex = 3;
            // 
            // lblPlaceholderGrafik
            // 
            lblPlaceholderGrafik.AutoSize = true;
            lblPlaceholderGrafik.ForeColor = Color.DimGray;
            lblPlaceholderGrafik.Location = new Point(337, 223);
            lblPlaceholderGrafik.Name = "lblPlaceholderGrafik";
            lblPlaceholderGrafik.Size = new Size(203, 25);
            lblPlaceholderGrafik.TabIndex = 0;
            lblPlaceholderGrafik.Text = "[ Area Visualisasi Grafik ]";
            // 
            // UC_Grafik
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlChartContainer);
            Controls.Add(cmbPriode);
            Controls.Add(lblFilter);
            Controls.Add(lblJudul);
            Name = "UC_Grafik";
            Size = new Size(960, 680);
            Load += UC_Grafik_Load;
            pnlChartContainer.ResumeLayout(false);
            pnlChartContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblFilter;
        private ComboBox cmbPriode;
        private Panel pnlChartContainer;
        private Label lblPlaceholderGrafik;
    }
}
