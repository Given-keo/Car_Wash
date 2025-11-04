using Car_Wash.Database;
using Car_Wash.Model;
using Car_Wash.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Car_Wash.Forms
{
    public partial class PackageForm : Form
    {
        private readonly PackageService _packageService;
        public PackageForm()
        {
            InitializeComponent();
            var db = new AppDbContext();
            _packageService = new PackageService(db);
        }

        private async void PackageForm_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            var data = await _packageService.GetAllAsync();
            dgvPackages.DataSource = data;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var package = new Package
            {
                PackageName = txtName.Text.Trim(),
                Price = decimal.TryParse(txtPrice.Text, out var price) ? price : 0,
                Description = txtDescription.Text.Trim()
            };

            await _packageService.AddAsync(package);
            MessageBox.Show("Paket berhasil ditambahkan!");
            await LoadDataAsync();
            ClearInputs();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPackages.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvPackages.CurrentRow.Cells["PackageId"].Value);
                var package = await _packageService.FindByIdAsync(id);
                if (package != null)
                {
                    package.PackageName = txtName.Text.Trim();
                    package.Price = decimal.TryParse(txtPrice.Text, out var price) ? price : 0;
                    package.Description = txtDescription.Text.Trim();
                    package.UpdatedAt = DateTime.Now;

                    await _packageService.UpdateAsync(package);
                    MessageBox.Show("Paket berhasil diperbarui!");
                    await LoadDataAsync();
                    ClearInputs();
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPackages.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvPackages.CurrentRow.Cells["PackageId"].Value);
                await _packageService.DeleteAsync(id);
                MessageBox.Show("Paket berhasil dihapus!");
                await LoadDataAsync();
                ClearInputs();
            }
        }

        private void dgvPackages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPackages.Rows[e.RowIndex];
                txtName.Text = row.Cells["PackageName"].Value?.ToString();
                txtPrice.Text = row.Cells["Price"].Value?.ToString();
                txtDescription.Text = row.Cells["Description"].Value?.ToString();
            }
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
        }
    }
}
