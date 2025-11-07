using Car_Wash.Database;
using Car_Wash.Model;
using Car_Wash.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        // ✅ Saat form pertama kali dibuka
        private async void PackageForm_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();

            dgvPackages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPackages.MultiSelect = false;
        }

        // ✅ Load semua data dari database
        private async Task LoadDataAsync()
        {
            var data = await _packageService.GetAllAsync();

            var list = data.Select((x, index) => new
            {
                No = index + 1,
                x.PackageId,
                x.PackageName,
                x.Price,
                x.Description,
                CreatedAt = x.CreatedAt.ToString("dd-MM-yyyy HH:mm"),
                UpdatedAt = x.UpdatedAt.HasValue ? x.UpdatedAt.Value.ToString("dd-MM-yyyy HH:mm") : "-"
            }).ToList();

            dgvPackages.DataSource = list;

            if (dgvPackages.Columns.Contains("PackageId"))
                dgvPackages.Columns["PackageId"].Visible = false;

            dgvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ✅ Tambah data baru
        private async void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Nama paket dan harga harus diisi!");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Harga harus berupa angka!");
                return;
            }

            var package = new Package
            {
                PackageName = txtName.Text.Trim(),
                Price = price,
                Description = txtDescription.Text.Trim(),
                CreatedAt = DateTime.UtcNow
            };

            await _packageService.AddAsync(package);
            MessageBox.Show("Data berhasil ditambahkan!");
            await LoadDataAsync();
            ClearInputs();
        }

        // ✅ Update data
        private async void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvPackages.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang ingin diupdate!");
                return;
            }

            int id = Convert.ToInt32(dgvPackages.CurrentRow.Cells["PackageId"].Value);
            var package = await _packageService.FindByIdAsync(id);

            if (package == null)
            {
                MessageBox.Show("Data tidak ditemukan!");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Harga harus berupa angka!");
                return;
            }

            package.PackageName = txtName.Text.Trim();
            package.Price = price;
            package.Description = txtDescription.Text.Trim();
            package.UpdatedAt = DateTime.UtcNow;

            await _packageService.UpdateAsync(package);
            MessageBox.Show("Data berhasil diperbarui!");
            await LoadDataAsync();
            ClearInputs();
        }

        // ✅ Hapus data
        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvPackages.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang ingin dihapus!");
                return;
            }

            int id = Convert.ToInt32(dgvPackages.CurrentRow.Cells["PackageId"].Value);
            var confirm = MessageBox.Show("Apakah yakin ingin menghapus paket ini?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                await _packageService.DeleteAsync(id);
                MessageBox.Show("Data berhasil dihapus!");
                await LoadDataAsync();
                ClearInputs();
            }
        }

        // ✅ Klik baris di DataGridView → isi textbox otomatis
        private void dgvPackages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPackages.Rows[e.RowIndex];

                txtName.Text = row.Cells["PackageName"].Value?.ToString() ?? string.Empty;
                txtPrice.Text = row.Cells["Price"].Value?.ToString() ?? string.Empty;
                txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? string.Empty;
            }
        }

        // ✅ Bersihkan input
        private void ClearInputs()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Nama paket dan harga harus diisi!");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Harga harus berupa angka!");
                return;
            }

            var package = new Package
            {
                PackageName = txtName.Text.Trim(),
                Price = price,
                Description = txtDescription.Text.Trim(),
                CreatedAt = DateTime.UtcNow
            };

            await _packageService.AddAsync(package);
            MessageBox.Show("Data berhasil ditambahkan!");
            await LoadDataAsync();
            ClearInputs();
        }



        private async void btnUpdate_Click_2(object sender, EventArgs e)
        {
            if (dgvPackages.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang ingin diupdate!");
                return;
            }

            int id = Convert.ToInt32(dgvPackages.CurrentRow.Cells["PackageId"].Value);
            var package = await _packageService.FindByIdAsync(id);

            if (package == null)
            {
                MessageBox.Show("Data tidak ditemukan!");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Harga harus berupa angka!");
                return;
            }

            package.PackageName = txtName.Text.Trim();
            package.Price = price;
            package.Description = txtDescription.Text.Trim();
            package.UpdatedAt = DateTime.UtcNow;

            await _packageService.UpdateAsync(package);
            MessageBox.Show("Data berhasil diperbarui!");
            await LoadDataAsync();
            ClearInputs();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPackages.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang ingin dihapus!");
                return;
            }

            int id = Convert.ToInt32(dgvPackages.CurrentRow.Cells["PackageId"].Value);
            var confirm = MessageBox.Show("Apakah yakin ingin menghapus paket ini?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                await _packageService.DeleteAsync(id);
                MessageBox.Show("Data berhasil dihapus!");
                await LoadDataAsync();
                ClearInputs();
            }
        }
    }
}
