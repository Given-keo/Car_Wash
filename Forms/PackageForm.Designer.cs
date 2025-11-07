namespace Car_Wash.Forms
{
    partial class PackageForm
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
            lblTitle = new Label();
            lblName = new Label();
            lblPrice = new Label();
            lblDescription = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            dgvPackages = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(30, 60, 114);
            lblTitle.Location = new Point(36, 33);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(359, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manajemen Paket Cuci";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(43, 117);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(125, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Nama Paket :";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10F);
            lblPrice.Location = new Point(43, 183);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(74, 28);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Harga :";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.Location = new Point(43, 250);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(100, 28);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Deskripsi :";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(214, 112);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(313, 34);
            txtName.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10F);
            txtPrice.Location = new Point(214, 178);
            txtPrice.Margin = new Padding(4, 5, 4, 5);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(313, 34);
            txtPrice.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(214, 245);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(313, 97);
            txtDescription.TabIndex = 6;
            // 
            // dgvPackages
            // 
            dgvPackages.AllowUserToAddRows = false;
            dgvPackages.AllowUserToDeleteRows = false;
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Location = new Point(30, 383);
            dgvPackages.Margin = new Padding(4, 5, 4, 5);
            dgvPackages.MultiSelect = false;
            dgvPackages.Name = "dgvPackages";
            dgvPackages.ReadOnly = true;
            dgvPackages.RowHeadersWidth = 62;
            dgvPackages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPackages.Size = new Size(900, 223);
            dgvPackages.TabIndex = 10;
            dgvPackages.CellClick += dgvPackages_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(51, 153, 255);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(581, 110);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 43);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Tambah";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 204, 0);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(581, 174);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 43);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Ubah";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_2;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 77, 77);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(581, 235);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 43);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Hapus";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // PackageForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1074, 800);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgvPackages);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            Name = "PackageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manajemen Paket Cuci";
            Load += PackageForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView dgvPackages;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
