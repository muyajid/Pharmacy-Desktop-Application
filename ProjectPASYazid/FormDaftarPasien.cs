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
    public partial class FormDaftarPasien : Form
    {
        public FormDaftarPasien(string counterImagePasien)
        {
            InitializeComponent();
            TXTcounterDaftarPasien.Text = counterImagePasien;
            NMRCumur.Minimum = 5;
        }
        private void RemoveAll()
        {
            TXTnama.Text = string.Empty;
            TXTalamatpasien.Text = string.Empty;
            TXTcodemember.Text = string.Empty;
            TXTnoHP.Text = string.Empty;
            NMRCumur.Value = 5;

            RBlakilaki.Checked = false;
            RBwanita.Checked = false;
        }

        private void TXTcounterDaftarPasien_TextChanged(object sender, EventArgs e)
        {
            
            if (TXTcounterDaftarPasien.Text == "FotoUser1")
            {
                PCuser1.Visible = true;
                PCuser2.Visible = false;
                PCuser3.Visible = false;
            }
            else if (TXTcounterDaftarPasien.Text == "FotoUser2")
            {
                PCuser1.Visible = false;
                PCuser2.Visible = true;
                PCuser3.Visible = false;
            }
            else if (TXTcounterDaftarPasien.Text == "FotoUser3")
            {
                PCuser1.Visible = false;
                PCuser2.Visible = false;
                PCuser3.Visible = true;
            }
        }

        private void BTNpesanobat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPesanObat openForms = new FormPesanObat(TXTcounterDaftarPasien.Text);
            openForms.Show();
        }

        private void BTNdaftarobat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDaftarObat openForms = new FormDaftarObat(TXTcounterDaftarPasien.Text);
            openForms.Show();
        }

        private void BTNdashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard openForms = new FormDashboard(TXTcounterDaftarPasien.Text);
            openForms.Show();
        }

        private void BTNaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAccounts openForms = new FormAccounts(TXTcounterDaftarPasien.Text);
            openForms.Show();
        }
        private void ShowAccount()
        {
            DialogResult dialog = MessageBox.Show("Ingin Ganti Foto Profile?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                FormAccounts openForms = new FormAccounts(TXTcounterDaftarPasien.Text);
                openForms.Show();
            }
        }
        private void PCuser3_Click(object sender, EventArgs e)
        {
            ShowAccount();
        }

        private void PCuser2_Click(object sender, EventArgs e)
        {
            ShowAccount();
        }

        private void PCuser1_Click(object sender, EventArgs e)
        {
            ShowAccount();
        }

        private void BTNclose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Yakin Ingin Keluar?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                FormLogin openLogin = new FormLogin();
                openLogin.Show();
            }
        }

        private void FormDaftarPasien_Load(object sender, EventArgs e)
        {



        }

        private void GBinputdata_Enter(object sender, EventArgs e)
        {



        }

        private void GBtampildata_Enter(object sender, EventArgs e)
        {


        }

        private void BTNmembership_Click(object sender, EventArgs e)
        {
        }

        private void BTNhapusdata_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Yakin Ingin Hapus Data?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                for (int i = DGmembership.RowCount - 1; i >= 0; i--)
                {
                    if (DGmembership.Rows[i].Selected)
                    {
                        DGmembership.Rows.RemoveAt(i);
                    }
                }
            }
        }

        private void BTNmembership_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXTnama.Text) || string.IsNullOrEmpty(TXTalamatpasien.Text))
            {
                MessageBox.Show("Silakan lengkapi data terlebih dahulu.", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Random randomNumber = new Random();
            int randomNumberForMember = randomNumber.Next(5, 100);
            int finalRandomNumber = (randomNumberForMember * 100) + 5;

            TXTcodemember.Text = finalRandomNumber.ToString();

            MessageBox.Show("Kode Membership Anda adalah: " + TXTcodemember.Text, "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            BTNmembership.Enabled = false;
        }
        private void SendToCard()
        {
            Membership_Card.Items.Clear();
            Membership_Card.Items.Add("\n  Nama Pasien  :  " + TXTnama.Text);
            Membership_Card.Items.Add("  Umur Pasien  :  " + NMRCumur.Value);

            string gender = RBlakilaki.Checked ? "Laki - Laki" : RBwanita.Checked ? "Wanita" : "";

            Membership_Card.Items.Add("  Jenis Kelamin : " + gender);
            Membership_Card.Items.Add("  Alamat Pasien : " + TXTalamatpasien.Text);
            Membership_Card.Items.Add("  Nomer Hp      : " + TXTnoHP.Text);
            Membership_Card.Items.Add("\n  Kode Membership : \n" + TXTcodemember.Text);
        }
        private void BTNinputdata_Click(object sender, EventArgs e)
        {
            if (TXTnama.Text == string.Empty || TXTalamatpasien.Text == string.Empty || TXTcodemember.Text == string.Empty)
            {
                MessageBox.Show("Silahkan Lengkapi Data Terlebih Dahulu", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RemoveAll();
                return;
            }

            DialogResult dialog = MessageBox.Show("Input Data Baru?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                string namaPasien = TXTnama.Text;
                string alamatPasien = TXTalamatpasien.Text;
                string codePasien = TXTcodemember.Text;
                string nomorHP = TXTnoHP.Text;

                string gender = RBlakilaki.Checked ? "Laki - Laki" : RBwanita.Checked ? "Wanita" : "";
                int umurPasien = (int)NMRCumur.Value;

                DGmembership.Rows.Add(namaPasien, umurPasien, gender, alamatPasien, nomorHP, codePasien);

                MessageBox.Show("Input Data Berhasil", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SendToCard();
                RemoveAll();
                BTNmembership.Enabled = true;
            }
            else if (dialog == DialogResult.No)
            {
                RemoveAll();
            }
        }

        private void BTNviewsdata_Click(object sender, EventArgs e)
        {
            if (GBinputdata.Visible)
            {
                GBinputdata.Visible = false;
                GBtampildata.Visible = true;
                BTNviewsdata.Text = "Input Data";
                BTNmembership.Enabled = true;
            }
            else
            {
                GBtampildata.Visible = false;
                GBinputdata.Visible = true;
                BTNviewsdata.Text = "Lihat Data";
                Membership_Card.Items.Clear();
            }
        }

        private void TXTnoHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TXTnoHP_TextChanged(object sender, EventArgs e)
        {
            if (TXTnoHP.TextLength > 12)
            {
                MessageBox.Show("Nomor HP Tidak Valid", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTnoHP.Text = string.Empty;
            }
        }

        private void BTNstock_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockObat openForm = new StockObat(TXTcounterDaftarPasien.Text);
            openForm.Show();
        }

        private void TXTnama_TextChanged(object sender, EventArgs e)
        {
        }

        private void TXTnama_Click(object sender, EventArgs e)
        {
            Membership_Card.Items.Clear();
        }
    }
}
