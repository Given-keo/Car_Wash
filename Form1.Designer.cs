namespace Car_Wash
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            dataMasterToolStripMenuItem = new ToolStripMenuItem();
            clientToolStripMenuItem = new ToolStripMenuItem();
            packageToolStripMenuItem = new ToolStripMenuItem();
            transactionToolStripMenuItem = new ToolStripMenuItem();
            laporanToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dataMasterToolStripMenuItem, transactionToolStripMenuItem, laporanToolStripMenuItem, homeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(957, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dataMasterToolStripMenuItem
            // 
            dataMasterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientToolStripMenuItem, packageToolStripMenuItem });
            dataMasterToolStripMenuItem.Name = "dataMasterToolStripMenuItem";
            dataMasterToolStripMenuItem.Size = new Size(124, 29);
            dataMasterToolStripMenuItem.Text = "Data Master";
            dataMasterToolStripMenuItem.Click += dataMasterToolStripMenuItem_Click;
            // 
            // clientToolStripMenuItem
            // 
            clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            clientToolStripMenuItem.Size = new Size(178, 34);
            clientToolStripMenuItem.Text = "Client";
            clientToolStripMenuItem.Click += clientToolStripMenuItem_Click;
            // 
            // packageToolStripMenuItem
            // 
            packageToolStripMenuItem.Name = "packageToolStripMenuItem";
            packageToolStripMenuItem.Size = new Size(178, 34);
            packageToolStripMenuItem.Text = "Package";
            packageToolStripMenuItem.Click += packageToolStripMenuItem_Click;
            // 
            // transactionToolStripMenuItem
            // 
            transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            transactionToolStripMenuItem.Size = new Size(98, 29);
            transactionToolStripMenuItem.Text = "Transaksi";
            transactionToolStripMenuItem.Click += transactionToolStripMenuItem_Click;
            // 
            // laporanToolStripMenuItem
            // 
            laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            laporanToolStripMenuItem.Size = new Size(92, 29);
            laporanToolStripMenuItem.Text = "Laporan";
            laporanToolStripMenuItem.Click += laporanToolStripMenuItem_Click;
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(77, 29);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.Control;
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(label1);
            mainPanel.Dock = DockStyle.Bottom;
            mainPanel.Location = new Point(0, 36);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(957, 643);
            mainPanel.TabIndex = 1;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(197, 81);
            label2.Name = "label2";
            label2.Size = new Size(671, 56);
            label2.TabIndex = 2;
            label2.Text = "Kelola pelanggan, layanan, dan transaksi Anda dengan mudah.\nJalankan bisnis cuci mobil Anda dengan lancar hanya dengan beberapa klik!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_car_wash;
            pictureBox1.Location = new Point(30, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(186, 29);
            label1.Name = "label1";
            label1.Size = new Size(139, 38);
            label1.TabIndex = 0;
            label1.Text = "Car Wash";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 679);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dataMasterToolStripMenuItem;
        private ToolStripMenuItem clientToolStripMenuItem;
        private ToolStripMenuItem packageToolStripMenuItem;
        private ToolStripMenuItem transactionToolStripMenuItem;
        private ToolStripMenuItem laporanToolStripMenuItem;
        private Panel mainPanel;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private ToolStripMenuItem homeToolStripMenuItem;
    }
}
