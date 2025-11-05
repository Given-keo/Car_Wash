namespace Car_Wash.Forms
{
    partial class TransactionForm
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
            groupBtn = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            cmbClient = new ComboBox();
            cmbPackage = new ComboBox();
            dateTimePickerTransaction = new DateTimePicker();
            dgvTransactions = new DataGridView();
            label7 = new Label();
            cmbPayment = new ComboBox();
            txtPrice = new TextBox();
            groupBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // groupBtn
            // 
            groupBtn.BackColor = SystemColors.ActiveBorder;
            groupBtn.Controls.Add(btnDelete);
            groupBtn.Controls.Add(btnUpdate);
            groupBtn.Controls.Add(btnAdd);
            groupBtn.Location = new Point(352, 43);
            groupBtn.Margin = new Padding(2);
            groupBtn.Name = "groupBtn";
            groupBtn.Padding = new Padding(2);
            groupBtn.Size = new Size(187, 165);
            groupBtn.TabIndex = 27;
            groupBtn.TabStop = false;
            groupBtn.Text = "Action";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(50, 106);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 20);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(50, 60);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 20);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
           // btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaptionText;
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(50, 23);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 20);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(234, 14);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 21);
            label5.TabIndex = 23;
            label5.Text = "Transaction";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 103);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 22;
            label3.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 158);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 21;
            label2.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 76);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 20;
            label1.Text = "Package:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 47);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 28;
            label4.Text = "Client:";
            // 
            // cmbClient
            // 
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(142, 43);
            cmbClient.Margin = new Padding(2);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(196, 23);
            cmbClient.TabIndex = 32;
            // 
            // cmbPackage
            // 
            cmbPackage.FormattingEnabled = true;
            cmbPackage.Location = new Point(142, 72);
            cmbPackage.Margin = new Padding(2);
            cmbPackage.Name = "cmbPackage";
            cmbPackage.Size = new Size(196, 23);
            cmbPackage.TabIndex = 33;
            // 
            // dateTimePickerTransaction
            // 
            dateTimePickerTransaction.Location = new Point(142, 158);
            dateTimePickerTransaction.Margin = new Padding(2);
            dateTimePickerTransaction.Name = "dateTimePickerTransaction";
            dateTimePickerTransaction.Size = new Size(196, 23);
            dateTimePickerTransaction.TabIndex = 34;
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(8, 221);
            dgvTransactions.Margin = new Padding(2);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 62;
            dgvTransactions.Size = new Size(543, 122);
            dgvTransactions.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 130);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 36;
            label7.Text = "Payment Method:";
            // 
            // cmbPayment
            // 
            cmbPayment.FormattingEnabled = true;
            cmbPayment.Location = new Point(142, 128);
            cmbPayment.Margin = new Padding(2);
            cmbPayment.Name = "cmbPayment";
            cmbPayment.Size = new Size(196, 23);
            cmbPayment.TabIndex = 37;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(142, 100);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(196, 23);
            txtPrice.TabIndex = 38;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(560, 398);
            Controls.Add(txtPrice);
            Controls.Add(cmbPayment);
            Controls.Add(label7);
            Controls.Add(dgvTransactions);
            Controls.Add(dateTimePickerTransaction);
            Controls.Add(cmbPackage);
            Controls.Add(cmbClient);
            Controls.Add(label4);
            Controls.Add(groupBtn);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "TransactionForm";
            Text = "TransactionForm";
            Load += TransactionForm_Load;
            groupBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBtn;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtDescription;
        private TextBox txtPackageName;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private ComboBox cmbClient;
        private ComboBox cmbPackage;
        private DateTimePicker dateTimePickerTransaction;
        private DataGridView dgvTransactions;
        private Label label7;
        private ComboBox cmbPayment;
        private TextBox txtPrice;
    }
}