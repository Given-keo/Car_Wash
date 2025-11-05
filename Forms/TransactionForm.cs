using Car_Wash.Database;
using Car_Wash.Model;
using Car_Wash.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Wash.Forms
{
    public partial class TransactionForm : Form
    {
        private readonly TransactionService _transactionService;
        private readonly ClientService _clientService;
        private readonly PackageService _packageService;

        private int selectedTransactionId = 0;

        public TransactionForm()
        {
            InitializeComponent();
            var db = new AppDbContext();
            _transactionService = new TransactionService(db);
            _clientService = new ClientService(db);
            _packageService = new PackageService(db);
        }

        private async void TransactionForm_Load(object sender, EventArgs e)
        {
            await LoadDropdownsAsync();
            await LoadDataAsync();

            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.MultiSelect = false;
            dgvTransactions.CellClick += dgvTransactions_CellClick;
        }

        private async Task LoadDropdownsAsync()
        {
            var clients = await _clientService.GetAllAsync();
            cmbClient.DataSource = clients;
            cmbClient.DisplayMember = "Name";
            cmbClient.ValueMember = "ClientId";
            cmbClient.SelectedIndex = -1;

            var packages = await _packageService.GetAllAsync();
            cmbPackage.DataSource = packages;
            cmbPackage.DisplayMember = "PackageName";
            cmbPackage.ValueMember = "PackageId";
            cmbPackage.SelectedIndex = -1;

            cmbPackage.SelectedIndexChanged += cmbPackage_SelectedIndexChanged;

            cmbPayment.Items.Clear();
            cmbPayment.Items.Add("Cash");
            cmbPayment.Items.Add("Transfer");
            cmbPayment.Items.Add("QRIS");
            cmbPayment.SelectedIndex = -1;
        }

        private async void cmbPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPackage.SelectedValue == null || !(cmbPackage.SelectedValue is int))
            {
                txtPrice.Text = string.Empty;
                return;
            }

            int packageId = (int)cmbPackage.SelectedValue;
            var package = await _packageService.FindByIdAsync(packageId);
            txtPrice.Text = package != null ? package.Price.ToString("N0") : string.Empty;
        }

        private async Task LoadDataAsync()
        {
            var data = await _transactionService.GetAllAsync();

            dgvTransactions.DataSource = data.Select((x, i) => new
            {
                No = i + 1,
                x.TransactionId,
                Client = x.Client?.Name,
                Package = x.Package?.PackageName,
                x.PaymentMethod,
                Price = x.TotalPrice,
                Date = x.TransactionDate.ToLocalTime().ToString("dd-MM-yyyy HH:mm")
            }).ToList();

            if (dgvTransactions.Columns.Contains("TransactionId"))
                dgvTransactions.Columns["TransactionId"].Visible = false;

            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTransactions.Rows[e.RowIndex].Cells["TransactionId"].Value != null)
            {
                var row = dgvTransactions.Rows[e.RowIndex];
                selectedTransactionId = Convert.ToInt32(row.Cells["TransactionId"].Value);
                cmbClient.Text = row.Cells["Client"].Value?.ToString();
                cmbPackage.Text = row.Cells["Package"].Value?.ToString();
                cmbPayment.Text = row.Cells["PaymentMethod"].Value?.ToString();
                txtPrice.Text = row.Cells["Price"].Value?.ToString();
            }
        }

        private void ClearInputs()
        {
            cmbClient.SelectedIndex = -1;
            cmbPackage.SelectedIndex = -1;
            cmbPayment.SelectedIndex = -1;
            txtPrice.Clear();
            selectedTransactionId = 0;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClient.SelectedValue == null || !(cmbClient.SelectedValue is int) ||
                    cmbPackage.SelectedValue == null || !(cmbPackage.SelectedValue is int))
                {
                    MessageBox.Show("Pilih client dan package terlebih dahulu!");
                    return;
                }

                var selectedPackage = await _packageService.FindByIdAsync((int)cmbPackage.SelectedValue);
                if (selectedPackage == null)
                {
                    MessageBox.Show("Package tidak ditemukan!");
                    return;
                }

                var transaction = new Transaction
                {
                    ClientId = (int)cmbClient.SelectedValue,
                    PackageId = (int)cmbPackage.SelectedValue,
                    PaymentMethod = cmbPayment.Text,
                    TotalPrice = selectedPackage.Price,
                    TransactionDate = DateTime.UtcNow
                };

                await _transactionService.AddAsync(transaction);
                MessageBox.Show("Transaksi berhasil ditambahkan!");
                await LoadDataAsync();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menambahkan transaksi: {ex.Message}");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedTransactionId == 0)
                {
                    MessageBox.Show("Pilih transaksi yang ingin diupdate!");
                    return;
                }

                var transaction = await _transactionService.FindByIdAsync(selectedTransactionId);
                if (transaction == null)
                {
                    MessageBox.Show("Transaksi tidak ditemukan!");
                    return;
                }

                if (cmbClient.SelectedValue == null || !(cmbClient.SelectedValue is int) ||
                    cmbPackage.SelectedValue == null || !(cmbPackage.SelectedValue is int))
                {
                    MessageBox.Show("Pilih client dan package terlebih dahulu!");
                    return;
                }

                var selectedPackage = await _packageService.FindByIdAsync((int)cmbPackage.SelectedValue);

                transaction.ClientId = (int)cmbClient.SelectedValue;
                transaction.PackageId = (int)cmbPackage.SelectedValue;
                transaction.PaymentMethod = cmbPayment.Text;
                transaction.TotalPrice = selectedPackage.Price;
                transaction.TransactionDate = DateTime.UtcNow;

                await _transactionService.UpdateAsync(transaction);
                MessageBox.Show("Transaksi berhasil diperbarui!");
                await LoadDataAsync();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal update transaksi: {ex.Message}");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedTransactionId == 0)
                {
                    MessageBox.Show("Pilih transaksi yang ingin dihapus!");
                    return;
                }

                var confirm = MessageBox.Show("Apakah yakin ingin menghapus transaksi ini?",
                    "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    await _transactionService.DeleteAsync(selectedTransactionId);
                    MessageBox.Show("Transaksi berhasil dihapus!");
                    await LoadDataAsync();
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menghapus transaksi: {ex.Message}");
            }
        }
    }
}
