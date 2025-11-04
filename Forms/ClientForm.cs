using Car_Wash.Database;
using Car_Wash.Model;
using Car_Wash.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Wash.Forms
{
    public partial class ClientForm : Form
    {
        private readonly ClientService _clientService;

        public ClientForm()
        {
            InitializeComponent();
            var db = new AppDbContext();
            _clientService = new ClientService(db);
        }

        private async void ClientForm_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            var data = await _clientService.GetAllAsync();

            var dataWithNumber = data.Select((x, index) => new
            {
                No = index + 1,
                x.ClientId,
                x.Name,
                x.Phone,
                x.Email,
                x.Address,
                x.CreatedAt,
                x.UpdatedAt
            }).ToList();

            dgvClients.DataSource = dataWithNumber;

            if (dgvClients.Columns.Contains("ClientId"))
                dgvClients.Columns["ClientId"].Visible = false;

            dgvClients.Columns["No"].Width = 50;
            dgvClients.Columns["Name"].Width = 150;
            dgvClients.Columns["Phone"].Width = 120;
            dgvClients.Columns["Email"].Width = 150;
            dgvClients.Columns["Address"].Width = 200;

            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            // ✅ Validasi input
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email harus berisi tanda '@'!");
                return;
            }

            var client = new Client
            {
                Name = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                CreatedAt = DateTime.UtcNow
            };

            await _clientService.AddAsync(client);
            MessageBox.Show("Data berhasil ditambahkan!");
            await LoadDataAsync();
            ClearInputs();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvClients.CurrentRow.Cells["ClientId"].Value);
                var client = await _clientService.FindByIdAsync(id);

                if (client != null)
                {
                    // ✅ Validasi input
                    if (string.IsNullOrWhiteSpace(txtName.Text))
                    {
                        MessageBox.Show("Nama tidak boleh kosong!");
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
                    {
                        MessageBox.Show("Email harus berisi tanda '@'!");
                        return;
                    }

                    client.Name = txtName.Text.Trim();
                    client.Phone = txtPhone.Text.Trim();
                    client.Email = txtEmail.Text.Trim();
                    client.Address = txtAddress.Text.Trim();
                    client.UpdatedAt = DateTime.UtcNow;

                    await _clientService.UpdateAsync(client);
                    MessageBox.Show("Data berhasil diperbarui!");
                    await LoadDataAsync();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan!");
                }
            }
            else
            {
                MessageBox.Show("Pilih data terlebih dahulu untuk diperbarui!");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvClients.CurrentRow.Cells["ClientId"].Value);
                var confirm = MessageBox.Show("Apakah kamu yakin ingin menghapus data ini?",
                    "Konfirmasi Hapus", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    await _clientService.DeleteAsync(id);
                    MessageBox.Show("Data berhasil dihapus!");
                    await LoadDataAsync();
                    ClearInputs();
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu!");
            }
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvClients.Rows[e.RowIndex].Cells["ClientId"].Value != null)
            {
                var row = dgvClients.Rows[e.RowIndex];

                txtName.Text = row.Cells["Name"].Value?.ToString() ?? "";
                txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }
    }
}
