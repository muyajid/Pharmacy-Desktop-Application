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
    public partial class FormDaftarObat : Form
    {
        public FormDaftarObat(string counterImageDF)
        {
            InitializeComponent();
            TXTcounterDaftarObat.Text = counterImageDF;
        }



        private void BTNdashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard openForm = new FormDashboard(TXTcounterDaftarObat.Text);
            openForm.Show();
        }
        private void ShowAccount()
        {
            DialogResult dialog = MessageBox.Show("Ingin Ganti Profile", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                FormAccounts openForm = new FormAccounts(TXTcounterDaftarObat.Text);
                openForm.Show();
            }
        }

        private void PCuser1_Click(object sender, EventArgs e)
        {
            ShowAccount();
        }
        private void PCuser3_Click(object sender, EventArgs e)
        {
            ShowAccount();
        }

        private void PCuser2_Click(object sender, EventArgs e)
        {
            ShowAccount();
        }

        private void BTNpesanobat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPesanObat openForm = new FormPesanObat(TXTcounterDaftarObat.Text);
            openForm.Show();
        }

        private void TXTcounterDaftarObat_TextChanged(object sender, EventArgs e)
        {
            if (TXTcounterDaftarObat.Text == "FotoUser1")
            {
                PCuser1.Visible = true;
                PCuser2.Visible = false;
                PCuser3.Visible = false;
            }
            else if (TXTcounterDaftarObat.Text == "FotoUser2")
            {
                PCuser1.Visible = false;
                PCuser2.Visible = true;
                PCuser3.Visible = false;
            }
            else if (TXTcounterDaftarObat.Text == "FotoUser3")
            {
                PCuser1.Visible = false;
                PCuser2.Visible = false;
                PCuser3.Visible = true;
            }
        }

        private void BTNaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAccounts openForms = new FormAccounts(TXTcounterDaftarObat.Text);
            openForms.Show();
        }

        private void BTNdaftarpasien_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDaftarPasien open = new FormDaftarPasien(TXTcounterDaftarObat.Text);
            open.Show();
        }

        private void BTNclose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Yakin Ingin Keluar?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                FormLogin openLogin = new FormLogin();
                openLogin.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void GBardium_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void TXTcariobat_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormDaftarObat_Load(object sender, EventArgs e)
        {

        }
        private void Search()
        {
            if (TXTcariobat.Text == "sanmol")
            {
                GroupBoxArdium.Visible = false;
                GroupBoxBodrex.Visible = false;
                GroupBoxPromagh.Visible = false;
                GroupBoxSanmol.Visible = true;
            }
            else if (TXTcariobat.Text == "ardium")
            {
                GroupBoxArdium.Visible = true;
                GroupBoxBodrex.Visible = false;
                GroupBoxPromagh.Visible = false;
                GroupBoxSanmol.Visible = false;
            }
            else if (TXTcariobat.Text == "bodrex")
            {
                GroupBoxArdium.Visible = false;
                GroupBoxBodrex.Visible = true;
                GroupBoxPromagh.Visible = false;
                GroupBoxSanmol.Visible = false;
            }
            else if (TXTcariobat.Text == "promagh")
            {
                GroupBoxArdium.Visible = false;
                GroupBoxBodrex.Visible = false;
                GroupBoxPromagh.Visible = true;
                GroupBoxSanmol.Visible = false;
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string[] daftarObat = { "sanmol", "promagh", "bodrex", "ardium" };
            if (!daftarObat.Contains(TXTcariobat.Text))
            {
                MessageBox.Show("Obat Tidak Ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTcariobat.Text = string.Empty;
            }
            Search();
        }

        private void TXTcariobat_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void TXTcariobat_TextChanged_1(object sender, EventArgs e)
        {
            if (TXTcariobat.Text == string.Empty)
            {
                GroupBoxArdium.Visible = false;
                GroupBoxBodrex.Visible = false;
                GroupBoxPromagh.Visible = false;
                GroupBoxSanmol.Visible = false;
            }
        }

        private void BTNstock_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockObat openForm = new StockObat(TXTcounterDaftarObat.Text);
            openForm.Show();
        }
    }
}