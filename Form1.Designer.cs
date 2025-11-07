namespace Car_Wash
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            dataMasterToolStripMenuItem = new ToolStripMenuItem();
            clientToolStripMenuItem = new ToolStripMenuItem();
            packageToolStripMenuItem = new ToolStripMenuItem();
            transactionToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dataMasterToolStripMenuItem, transactionToolStripMenuItem, homeToolStripMenuItem });
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
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(77, 29);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.ButtonHighlight;
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(pictureBox2);
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
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(423, 255);
            label2.Name = "label2";
            label2.Size = new Size(446, 21);
            label2.TabIndex = 5;
            label2.Text = "Kelola Pelanggan, Layanan, dan Transaksi Anda dengan mudah.";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_car_wash;
            pictureBox1.Location = new Point(153, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Image = Properties.Resources.pattern;
            pictureBox2.Location = new Point(0, 266);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(957, 377);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(396, 155);
            label1.Name = "label1";
            label1.Size = new Size(458, 117);
            label1.TabIndex = 0;
            label1.Text = "CAR WASH";
            label1.Click += label1_Click_1;
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
            Text = "Car Wash Management";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dataMasterToolStripMenuItem;
        private ToolStripMenuItem clientToolStripMenuItem;
        private ToolStripMenuItem packageToolStripMenuItem;
        private ToolStripMenuItem transactionToolStripMenuItem;
        private Panel mainPanel;
        private Label label1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
