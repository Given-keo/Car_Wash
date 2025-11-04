namespace Car_Wash.Forms
{
    partial class ClientForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            groupBtn = new GroupBox();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvClients = new DataGridView();
            groupBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 102);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 212);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 157);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "Phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 270);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 3;
            label4.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(255, 30);
            label5.Name = "label5";
            label5.Size = new Size(230, 32);
            label5.TabIndex = 4;
            label5.Text = "Data Master Client";
            // 
            // txtName
            // 
            txtName.Location = new Point(194, 96);
            txtName.Name = "txtName";
            txtName.Size = new Size(299, 31);
            txtName.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(194, 151);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(299, 31);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(194, 206);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(299, 31);
            txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(194, 264);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(299, 96);
            txtAddress.TabIndex = 8;
            // 
            // groupBtn
            // 
            groupBtn.BackColor = SystemColors.ActiveBorder;
            groupBtn.Controls.Add(btnDelete);
            groupBtn.Controls.Add(btnRefresh);
            groupBtn.Controls.Add(btnUpdate);
            groupBtn.Controls.Add(btnAdd);
            groupBtn.Location = new Point(516, 96);
            groupBtn.Name = "groupBtn";
            groupBtn.Size = new Size(252, 264);
            groupBtn.TabIndex = 9;
            groupBtn.TabStop = false;
            groupBtn.Text = "Action";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(72, 193);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // btnDelete.Click += btnDelete_Click_1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Coral;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.Control;
            btnRefresh.Location = new Point(72, 142);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(72, 90);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
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
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(12, 386);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 62;
            dgvClients.Size = new Size(776, 212);
            dgvClients.TabIndex = 10;
            //dgvClients.CellContentClick += dgvClients_CellContentClick;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 610);
            Controls.Add(dgvClients);
            Controls.Add(groupBtn);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClientForm";
            Text = "ClientForm";
            Load += ClientForm_Load;
            groupBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private GroupBox groupBtn;
        private Button btnRefresh;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dgvClients;
    }
}