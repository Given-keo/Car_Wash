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

            dgvClients.DataSource = data
                .Select((x, i) => new
                {
                    No = i + 1,
                    x.ClientId,
                    x.Name,
                    x.Phone,
                    x.Email,
                    x.Address
                }).ToList();

            if (dgvClients.Columns.Contains("ClientId"))
                dgvClients.Columns["ClientId"].Visible = false;

            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClients.ScrollBars = ScrollBars.Both;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email tidak valid!");
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
            if (dgvClients.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang akan diubah!");
                return;
            }

            int id = Convert.ToInt32(dgvClients.CurrentRow.Cells["ClientId"].Value);
            var client = await _clientService.FindByIdAsync(id);

            if (client != null)
            {
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
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang akan dihapus!");
                return;
            }

            int id = Convert.ToInt32(dgvClients.CurrentRow.Cells["ClientId"].Value);
            var confirm = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                await _clientService.DeleteAsync(id);
                MessageBox.Show("Data berhasil dihapus!");
                await LoadDataAsync();
                ClearInputs();
            }
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvClients.Rows[e.RowIndex];
                txtName.Text = row.Cells["Name"].Value?.ToString() ?? "";
                txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
            }
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
