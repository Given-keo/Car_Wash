using System;
using System.Windows.Forms;
using Car_Wash.Forms;

namespace Car_Wash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Car Wash Management System";
        }

        private void LoadForm(Form form)
        {
            // Bersihkan panel dulu
            mainPanel.Controls.Clear();

            // Siapkan form untuk ditampilkan di panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Tambahkan ke panel
            mainPanel.Controls.Add(form);
            form.Show();
        }



        private void dataMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new ClientForm());
        }

        private void packageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new PackageForm());
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new TransactionForm());
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new ReportForm());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
