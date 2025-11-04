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
            mainPanel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dataMasterToolStripMenuItem, transactionToolStripMenuItem, laporanToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
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
            // mainPanel
            // 
            mainPanel.BackColor = Color.Gray;
            mainPanel.Dock = DockStyle.Bottom;
            mainPanel.Location = new Point(0, 36);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 595);
            mainPanel.TabIndex = 1;
            mainPanel.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 631);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}
