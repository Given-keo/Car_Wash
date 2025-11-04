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
            btnRefresh = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtPrice = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtTotal = new TextBox();
            label6 = new Label();
            cmbClient = new ComboBox();
            cmbPackage = new ComboBox();
            dateTimePickerTransaction = new DateTimePicker();
            dgvTransactions = new DataGridView();
            label7 = new Label();
            cmbPayment = new ComboBox();
            groupBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // groupBtn
            // 
            groupBtn.BackColor = SystemColors.ActiveBorder;
            groupBtn.Controls.Add(btnRefresh);
            groupBtn.Controls.Add(btnDelete);
            groupBtn.Controls.Add(btnUpdate);
            groupBtn.Controls.Add(btnAdd);
            groupBtn.Location = new Point(503, 71);
            groupBtn.Name = "groupBtn";
            groupBtn.Size = new Size(267, 275);
            groupBtn.TabIndex = 27;
            groupBtn.TabStop = false;
            groupBtn.Text = "Action";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Tomato;
            btnRefresh.ForeColor = SystemColors.ButtonHighlight;
            btnRefresh.Location = new Point(72, 128);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.RightToLeft = RightToLeft.No;
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(72, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(72, 79);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaptionText;
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(72, 39);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(203, 169);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(278, 31);
            txtPrice.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(334, 23);
            label5.Name = "label5";
            label5.Size = new Size(147, 32);
            label5.TabIndex = 23;
            label5.Text = "Transaction";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 172);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 22;
            label3.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 263);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 21;
            label2.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 126);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 20;
            label1.Text = "Package:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 79);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 28;
            label4.Text = "Client:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(203, 312);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(278, 31);
            txtTotal.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 321);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 30;
            label6.Text = "Total:";
            // 
            // cmbClient
            // 
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(203, 71);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(278, 33);
            cmbClient.TabIndex = 32;
            // 
            // cmbPackage
            // 
            cmbPackage.FormattingEnabled = true;
            cmbPackage.Location = new Point(203, 120);
            cmbPackage.Name = "cmbPackage";
            cmbPackage.Size = new Size(278, 33);
            cmbPackage.TabIndex = 33;
            // 
            // dateTimePickerTransaction
            // 
            dateTimePickerTransaction.Location = new Point(203, 263);
            dateTimePickerTransaction.Name = "dateTimePickerTransaction";
            dateTimePickerTransaction.Size = new Size(279, 31);
            dateTimePickerTransaction.TabIndex = 34;
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(12, 368);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 62;
            dgvTransactions.Size = new Size(776, 204);
            dgvTransactions.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 216);
            label7.Name = "label7";
            label7.Size = new Size(152, 25);
            label7.TabIndex = 36;
            label7.Text = "Payment Method:";
            // 
            // cmbPayment
            // 
            cmbPayment.FormattingEnabled = true;
            cmbPayment.Location = new Point(203, 213);
            cmbPayment.Name = "cmbPayment";
            cmbPayment.Size = new Size(279, 33);
            cmbPayment.TabIndex = 37;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 663);
            Controls.Add(cmbPayment);
            Controls.Add(label7);
            Controls.Add(dgvTransactions);
            Controls.Add(dateTimePickerTransaction);
            Controls.Add(cmbPackage);
            Controls.Add(cmbClient);
            Controls.Add(txtTotal);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(groupBtn);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private TextBox txtPrice;
        private TextBox txtPackageName;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private TextBox txtTotal;
        private Label label6;
        private ComboBox cmbClient;
        private ComboBox cmbPackage;
        private DateTimePicker dateTimePickerTransaction;
        private Button btnRefresh;
        private DataGridView dgvTransactions;
        private Label label7;
        private ComboBox cmbPayment;
    }
}