namespace AppPerpustakaan
{
    partial class Form1
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

        #region windows forms Designer generated code

        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            btnDashboard = new Button();
            btnMenuUtama = new Button();
            btnsettings = new Button();
            btnAbout = new Button();
            pnlSidebar = new Panel();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 50);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnMenuUtama
            // 
            btnMenuUtama.Dock = DockStyle.Top;
            btnMenuUtama.Location = new Point(0, 50);
            btnMenuUtama.Name = "btnMenuUtama";
            btnMenuUtama.Size = new Size(200, 50);
            btnMenuUtama.TabIndex = 1;
            btnMenuUtama.Text = "Menu Utama";
            btnMenuUtama.UseVisualStyleBackColor = true;
            btnMenuUtama.Click += btnMenuUtama_Click_1;
            // 
            // btnsettings
            // 
            btnsettings.Dock = DockStyle.Top;
            btnsettings.Location = new Point(0, 100);
            btnsettings.Name = "btnsettings";
            btnsettings.Size = new Size(200, 50);
            btnsettings.TabIndex = 2;
            btnsettings.Text = "Pengaturan";
            btnsettings.UseVisualStyleBackColor = true;
            btnsettings.Click += btnsettings_Click_1;
            // 
            // btnAbout
            // 
            btnAbout.Dock = DockStyle.Top;
            btnAbout.Location = new Point(0, 150);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(200, 50);
            btnAbout.TabIndex = 3;
            btnAbout.Text = "Tentang";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click_1;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = SystemColors.ControlDark;
            pnlSidebar.Controls.Add(btnAbout);
            pnlSidebar.Controls.Add(btnsettings);
            pnlSidebar.Controls.Add(btnMenuUtama);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 664);
            pnlSidebar.TabIndex = 3;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = SystemColors.ControlLight;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(200, 0);
            pnlContent.Margin = new Padding(4, 5, 4, 5);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(958, 664);
            pnlContent.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 664);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplikasi Perpustakaan Pribadi";
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Button btnDashboard;
        private Button btnMenuUtama;
        private Button btnsettings;
        private Button btnAbout;
        private Panel pnlSidebar;
        private Panel pnlContent;
    }
}