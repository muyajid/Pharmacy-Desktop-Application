using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPASYazid
{
    public partial class FormDashboard : Form
    {
        public FormDashboard(string counterImageDB)
        {
            InitializeComponent();
            TXTcounterDashboard.Text = counterImageDB;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNdashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard openForm = new FormDashboard(TXTcounterDashboard.Text);
            openForm.Show();
        }

        private void BTNclose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Yakin Ingin Keluar", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                FormLogin openLogin = new FormLogin();
                openLogin.Show();
            }
        }
        private void ShowAccount()
        {
            DialogResult dialog = MessageBox.Show("Ingin Ganti Foto Profile?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                FormAccounts openForm = new FormAccounts(TXTcounterDashboard.Text);
                openForm.Show();
            }
        }
        private void PCuser1_Click(object sender, EventArgs e)
        {
            ShowAccount();
        }

        private void PCuser2_Click(object sender, EventArgs e)
        {
            ShowAccount();
        }

        private void PCuser3_Click(object sender, EventArgs e)
        {
            ShowAccount();
        }

        private void BTNdaftarobat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDaftarObat openForm = new FormDaftarObat(TXTcounterDashboard.Text);
            openForm.Show();
        }

        private void BTNpesanobat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPesanObat openForm = new FormPesanObat(TXTcounterDashboard.Text);
            openForm.Show();
        }

        private void TXTcounterDashboard_TextChanged(object sender, EventArgs e)
        {
            if (TXTcounterDashboard.Text == "FotoUser1")
            {
                PCuser2.Visible = false;
                PCuser3.Visible = false;
                PCuser1.Visible = true;

            }
            else if (TXTcounterDashboard.Text == "FotoUser2")
            {
                PCuser2.Visible = true;
                PCuser3.Visible = false;
                PCuser1.Visible = false;

            }
            else if (TXTcounterDashboard.Text == "FotoUser3")
            {
                PCuser2.Visible = false;
                PCuser3.Visible = true;
                PCuser1.Visible = false;

            }
        }

        private void BTNaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAccounts openForms = new FormAccounts(TXTcounterDashboard.Text);
            openForms.Show();
        }

        private void BTNdaftarpasien_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDaftarPasien open = new FormDaftarPasien(TXTcounterDashboard.Text);
            open.Show();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BTNstock_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockObat openForm = new StockObat(TXTcounterDashboard.Text);
            openForm.Show();
        }
    }
}
