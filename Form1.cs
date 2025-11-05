using System;
using System.Windows.Forms;
using Car_Wash.Forms;


namespace Car_Wash
{
    public partial class Form1 : Form
    {
        private Control[] _homeControls;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Simpan kontrol default panel utama (Home)
            _homeControls = mainPanel.Controls.Cast<Control>().ToArray();
        }

        private void LoadForm(Form form)
        {
          
            mainPanel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.AddRange(_homeControls);
        }
    }
}
