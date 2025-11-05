namespace Car_Wash.Forms
{
    partial class PackageForm
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
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvPackages = new DataGridView();
            groupBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            SuspendLayout();
            // 
            // groupBtn
            // 
            groupBtn.BackColor = SystemColors.ActiveBorder;
            groupBtn.Controls.Add(btnDelete);
            groupBtn.Controls.Add(btnUpdate);
            groupBtn.Controls.Add(btnAdd);
            groupBtn.Location = new Point(504, 126);
            groupBtn.Name = "groupBtn";
            groupBtn.Size = new Size(252, 273);
            groupBtn.TabIndex = 19;
            groupBtn.TabStop = false;
            groupBtn.Text = "Action";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(72, 195);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(72, 116);
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
            // txtDescription
            // 
            txtDescription.Location = new Point(182, 236);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(299, 163);
            txtDescription.TabIndex = 17;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(182, 181);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(299, 31);
            txtPrice.TabIndex = 16;
            // 
            // txtName
            // 
            txtName.Location = new Point(182, 126);
            txtName.Name = "txtName";
            txtName.Size = new Size(299, 31);
            txtName.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(257, 54);
            label5.Name = "label5";
            label5.Size = new Size(256, 32);
            label5.TabIndex = 14;
            label5.Text = "Data Master Package";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 187);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 12;
            label3.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 242);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 11;
            label2.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 132);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 10;
            label1.Text = "Package Name:";
            // 
            // dgvPackages
            // 
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Location = new Point(21, 416);
            dgvPackages.Name = "dgvPackages";
            dgvPackages.RowHeadersWidth = 62;
            dgvPackages.Size = new Size(767, 160);
            dgvPackages.TabIndex = 20;
            // 
            // PackageForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 590);
            Controls.Add(dgvPackages);
            Controls.Add(groupBtn);
            Controls.Add(txtDescription);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PackageForm";
            Text = "PackageForm";
            Load += PackageForm_Load;
            groupBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
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
        private TextBox txtName;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvPackages;
    }
}