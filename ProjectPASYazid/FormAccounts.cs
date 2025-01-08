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
    public partial class FormAccounts : Form
    {
        public FormAccounts(string counterImageAccounts)
        {
            InitializeComponent();
            TXTcounterAccounts.Text = counterImageAccounts;
        }

        private void CMBswicthprofile_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (CMBswicthprofile.Text == "FotoUser1")
            {
                PCuser1.Visible = true;
                PCuser2.Visible = false;
                PCuser3.Visible = false;
            }
            else if (CMBswicthprofile.Text == "FotoUser2")
            {
                PCuser1.Visible = false;
                PCuser2.Visible = true;
                PCuser3.Visible = false;
            }
            else if (CMBswicthprofile.Text == "FotoUser3")
            {
                PCuser1.Visible = false;
                PCuser2.Visible = false;
                PCuser3.Visible = true;
            }
        }

        private void BTNdashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard openForms = new FormDashboard(CMBswicthprofile.Text);
            openForms.Show();
        }

        private void BTNdaftarobat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDaftarObat openForms = new FormDaftarObat(CMBswicthprofile.Text);
            openForms.Show();
        }

        private void BTNpesanobat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPesanObat openForms = new FormPesanObat(CMBswicthprofile.Text);
            openForms.Show();
        }

        private void BTNdaftarpasien_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDaftarPasien openForms = new FormDaftarPasien(CMBswicthprofile.Text);
            openForms.Show();
        }

        private void TXTcounterAccounts_TextChanged(object sender, EventArgs e)
        {
            if (TXTcounterAccounts.Text == "FotoUser1")
            {
                PCuser1.Visible = true;
                PCuser2.Visible = false;
                PCuser3.Visible = false;
            }
            else if (TXTcounterAccounts.Text == "FotoUser2")
            {
                PCuser1.Visible = false;
                PCuser2.Visible = true;
                PCuser3.Visible = false;
            }
            else if (TXTcounterAccounts.Text == "FotoUser3")
            {
                PCuser1.Visible = false;
                PCuser2.Visible = false;
                PCuser3.Visible = true;
            }
        }
        private void ShowAccount()
        {
            MessageBox.Show("Ingin Ganti Foto Profile?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return;
        }
        private void PCuser1_Click(object sender, EventArgs e)
        {
            ShowAccount();
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

        private void FormAccounts_Load(object sender, EventArgs e)
        {





        }

        private void BTNstock_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockObat openForm = new StockObat(CMBswicthprofile.Text);
            openForm.Show();
        }

        private void PCuser3_Click(object sender, EventArgs e)
        {
            ShowAccount();
        }

        private void PCuser2_Click(object sender, EventArgs e)
        {
            ShowAccount();
        }
    }
}
