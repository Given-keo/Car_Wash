using Car_Wash.Database;
using Car_Wash.Model;
using Car_Wash.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Wash.Forms
{
    public partial class TransactionForm : Form
    {
        private readonly TransactionService _transactionService;
        private readonly ClientService _clientService;
        private readonly PackageService _packageService;
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
        }

        private async Task LoadDropdownsAsync()
        {
            var clients = await _clientService.GetAllAsync();
            cmbClient.DataSource = clients;
            cmbClient.DisplayMember = "Name";
            cmbClient.ValueMember = "ClientId";

            var packages = await _packageService.GetAllAsync();
            cmbPackage.DataSource = packages;
            cmbPackage.DisplayMember = "PackageName";
            cmbPackage.ValueMember = "PackageId";
        }

        private async Task LoadDataAsync()
        {
            var data = await _transactionService.GetAllAsync();
            dgvTransactions.DataSource = data;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbClient.SelectedValue == null || cmbPackage.SelectedValue == null)
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
                TransactionDate = DateTime.Now
            };

            await _transactionService.AddAsync(transaction);
            MessageBox.Show("Transaksi berhasil ditambahkan!");
            await LoadDataAsync();
            ClearInputs();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvTransactions.CurrentRow.Cells["TransactionId"].Value);
                await _transactionService.DeleteAsync(id);
                MessageBox.Show("Transaksi berhasil dihapus!");
                await LoadDataAsync();
            }
        }

        private void ClearInputs()
        {
            cmbClient.SelectedIndex = -1;
            cmbPackage.SelectedIndex = -1;
            cmbPayment.SelectedIndex = -1;
        }
    }
}
