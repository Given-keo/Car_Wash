namespace Car_Wash.Forms
{
    partial class TransactionForm
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
            cmbClient = new ComboBox();
            cmbPackage = new ComboBox();
            cmbPayment = new ComboBox();
            txtPrice = new TextBox();
            dgvTransactions = new DataGridView();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // cmbClient
            // 
            cmbClient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(131, 89);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(372, 33);
            cmbClient.TabIndex = 0;
            // 
            // cmbPackage
            // 
            cmbPackage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPackage.FormattingEnabled = true;
            cmbPackage.Location = new Point(131, 143);
            cmbPackage.Name = "cmbPackage";
            cmbPackage.Size = new Size(372, 33);
            cmbPackage.TabIndex = 1;
            // 
            // cmbPayment
            // 
            cmbPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPayment.FormattingEnabled = true;
            cmbPayment.Location = new Point(131, 209);
            cmbPayment.Name = "cmbPayment";
            cmbPayment.Size = new Size(372, 33);
            cmbPayment.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(131, 266);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(372, 31);
            txtPrice.TabIndex = 3;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.BackgroundColor = Color.White;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(31, 326);
            dgvTransactions.Margin = new Padding(4, 5, 4, 5);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersWidth = 51;
            dgvTransactions.RowTemplate.Height = 24;
            dgvTransactions.Size = new Size(908, 291);
            dgvTransactions.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(51, 153, 255);
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(534, 80);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 50);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Tambah";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(31, 89);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 8;
            label1.Text = "Client:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(31, 148);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 9;
            label2.Text = "Package:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(31, 209);
            label3.Name = "label3";
            label3.Size = new Size(91, 28);
            label3.TabIndex = 10;
            label3.Text = "Payment:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(31, 266);
            label4.Name = "label4";
            label4.Size = new Size(58, 28);
            label4.TabIndex = 11;
            label4.Text = "Price:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(30, 60, 114);
            lblTitle.Location = new Point(31, 22);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(167, 45);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Transaksi ";
            // 
            // TransactionForm
            // 
            ClientSize = new Size(1246, 661);
            Controls.Add(lblTitle);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btnAdd);
            Controls.Add(dgvTransactions);
            Controls.Add(txtPrice);
            Controls.Add(cmbPayment);
            Controls.Add(cmbPackage);
            Controls.Add(cmbClient);
            Name = "TransactionForm";
            Text = "Transaction Form";
            Load += TransactionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.ComboBox cmbPackage;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Label lblTitle;
    }
}
