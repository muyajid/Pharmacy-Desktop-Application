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
    public partial class FormPesanObat : Form
    {
        public FormPesanObat(string counterImagePS)
        {
            InitializeComponent();
            TXTcounterPesanObat.Text = counterImagePS;
            NMRjumlahobat.Minimum = 1;
        }
        private void RemoveAll()
        {
            TXTnamaobat.Text = string.Empty;
            TXThargaobat.Text = string.Empty;
            NMRjumlahobat.Value = 1;
            CMBmetode.Text = string.Empty;
            checkBox1.Checked = false;
            TXTmembership.Text = string.Empty;
        }
        private void SendData()
        {
            int convertJumlah = (int)NMRjumlahobat.Value;

            string namaObat = TXTnamaobat.Text;
            string hargaObat = TXThargaobat.Text;
            int jumlahObat = convertJumlah;

            int number1 = (int)NMRjumlahobat.Value;
            int number2 = int.Parse(TXThargaobat.Text);
            int sum = number1 * number2;

            string metodePembayaran = CMBmetode.Text;
            string nomerMembership = TXTmembership.Text;

            DGpesanobat.Rows.Add(namaObat, hargaObat, jumlahObat, sum, metodePembayaran, nomerMembership);
        }
        private void ShowAccount()
        {
            DialogResult dialog = MessageBox.Show("Ingin Ganti Foto Profile", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                FormAccounts openForm = new FormAccounts(TXTcounterPesanObat.Text);
                openForm.Show();
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

        private void BTNdaftarobat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDaftarObat openForm = new FormDaftarObat(TXTcounterPesanObat.Text);
            openForm.ShowDialog();
        }

        private void BTNdashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard openForm = new FormDashboard(TXTcounterPesanObat.Text);
            openForm.Show();
        }

        private void TXTcounterPesanObat_TextChanged(object sender, EventArgs e)
        {
            if (TXTcounterPesanObat.Text == "FotoUser1")
            {
                PCuser2.Visible = false;
                PCuser3.Visible = false;
                PCuser1.Visible = true;

            }
            else if (TXTcounterPesanObat.Text == "FotoUser2")
            {
                PCuser2.Visible = true;
                PCuser3.Visible = false;
                PCuser1.Visible = false;

            }
            else if (TXTcounterPesanObat.Text == "FotoUser3")
            {
                PCuser2.Visible = false;
                PCuser3.Visible = true;
                PCuser1.Visible = false;

            }
        }

        private void BTNdaftarpasien_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDaftarPasien openForms = new FormDaftarPasien(TXTcounterPesanObat.Text);
            openForms.Show();
        }

        private void BTNaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAccounts open = new FormAccounts(TXTcounterPesanObat.Text);
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

        private void FormPesanObat_Load(object sender, EventArgs e)
        {


        }

        private void GBorderobat_Enter(object sender, EventArgs e)
        {

        }

        private void TXTnamaobat_TextChanged(object sender, EventArgs e)
        {

            if (TXTnamaobat.Text == "sanmol")
            {
                PCsanmol.Visible = true;
                PCpromagh.Visible = false;
                PCbodrex.Visible = false;
                PCardium.Visible = false;
            }
            else if (TXTnamaobat.Text == "promagh")
            {
                PCpromagh.Visible = true;
                PCsanmol.Visible = false;
                PCbodrex.Visible = false;
                PCardium.Visible = false;
            }
            else if (TXTnamaobat.Text == "bodrex")
            {
                PCbodrex.Visible = true;
                PCpromagh.Visible = false;
                PCsanmol.Visible = false;
                PCardium.Visible = false;
            }
            else if (TXTnamaobat.Text == "ardium")
            {
                PCardium.Visible = true;
                PCbodrex.Visible = false;
                PCpromagh.Visible = false;
                PCsanmol.Visible = false;
            }
            else if (TXTnamaobat.Text == string.Empty)
            {
                PCardium.Visible = false;
                PCbodrex.Visible = false;
                PCpromagh.Visible = false;
                PCsanmol.Visible = false;
            }

            if (TXTnamaobat.Text == "sanmol")
            {
                TXThargaobat.Text = "25000";
            }
            else if (TXTnamaobat.Text == "promagh")
            {
                TXThargaobat.Text = "10000";
            }
            else if (TXTnamaobat.Text == "bodrex")
            {
                TXThargaobat.Text = "5000";
            }
            else if (TXTnamaobat.Text == "ardium")
            {
                TXThargaobat.Text = "75000";
            }
            else if (TXTnamaobat.Text == string.Empty)
            {
                TXThargaobat.Text = string.Empty;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                DialogResult dialog = MessageBox.Show("Punya Membership?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    TXTmembership.Visible = true;
                }
                else if (dialog == DialogResult.No)
                {
                    checkBox1.Checked = false;
                }
            }

            if (checkBox1.Checked == false)
            {
                TXTmembership.Visible = false;
            }
        }
        private void BTNbeli_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXTnamaobat.Text) || string.IsNullOrEmpty(CMBmetode.Text)
                || string.IsNullOrEmpty(TXThargaobat.Text))
            {
                MessageBox.Show("Kamu Belum Input Data !!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RemoveAll();
                return;
            }

            string[] daftarObat = { "sanmol", "promagh", "bodrex", "ardium" };
            if (!daftarObat.Contains(TXTnamaobat.Text))
            {
                DialogResult dialog = MessageBox.Show("Obat Tidak Ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK)
                {
                    RemoveAll();
                    TXTmembership.Visible = false;

                    LSTnota.Items.Clear();
                }
            }
            else if (daftarObat.Contains(TXTnamaobat.Text))
            {
                DialogResult dialog = MessageBox.Show("Order Obat", "Pemberitahuan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    LSTnota.Items.Clear();

                    LSTnota.Items.Add("\n=========== Nota : ==========\n");
                    LSTnota.Items.Add("Nama Obat   : " + TXTnamaobat.Text);
                    LSTnota.Items.Add("Harga Obat  : " + TXThargaobat.Text);
                    LSTnota.Items.Add("Jumlah Obat : " + NMRjumlahobat.Value);
                    LSTnota.Items.Add("Metode Pembayaran : " + CMBmetode.Text);

                    if (checkBox1.Checked == true)
                    {
                        LSTnota.Items.Add("Nomer Member : " + TXTmembership.Text);
                    }

                    GBorderobat.Visible = false;
                    GBtampilnota.Visible = true;
                }
                else if (dialog == DialogResult.No)
                {
                    RemoveAll();
                    return;
                }
            }

        }
        private void BTNbayar_Click(object sender, EventArgs e)
        {
            SendData();

            int number1 = (int)NMRjumlahobat.Value;
            int number2 = int.Parse(TXThargaobat.Text);
            int totalHarga = number1 * number2;

            FormQRIS openFormQRIS = new FormQRIS();

            if (CMBmetode.Text == "QRIS")
            {
                openFormQRIS.Show();
            }
            DialogResult dialog = MessageBox.Show("Total Yang Harus Dibayar = " + totalHarga, "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                openFormQRIS.Close();
            }

            LSTnota.Items.Add("Total =  " + totalHarga);
            LSTnota.Items.Add("\n================================\n");
            BTNbayar.Enabled = false;
        }
        private void BTNpesanlagi_Click(object sender, EventArgs e)
        {
            if (!LSTnota.Items.Contains("\n================================\n"))
            {
                MessageBox.Show("Kamu Belum Bayar", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BTNbayar.Enabled = true;
            GBtampilnota.Visible = false;
            GBorderobat.Visible = true;

            TXTmembership.Visible = false;
            RemoveAll();

        }

        private void BTNpenjualan_Click(object sender, EventArgs e)
        {
            if (GBorderobat.Visible || GBtampilnota.Visible)
            {
                GBdatapenjualan.Visible = true;
                GBorderobat.Visible = false;
                GBtampilnota.Visible = false;
            }
        }

        private void BTNback_Click(object sender, EventArgs e)
        {
            GBorderobat.Visible = true;
            GBtampilnota.Visible = false;
            GBdatapenjualan.Visible = false;
            BTNbayar.Enabled = true;

            RemoveAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNhapusdata_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Yakin Ingin Hapus Data?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                for (int i = DGpesanobat.Rows.Count - 1; i >= 0; i--)
                {
                    if (DGpesanobat.Rows[i].Selected)
                    {
                        DGpesanobat.Rows.RemoveAt(i);
                    }
                }
            }
        }

        private void TXTmembership_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GBfotoobat_Enter(object sender, EventArgs e)
        {

        }

        private void TXTmembership_TextChanged(object sender, EventArgs e)
        {
            if (TXTmembership.TextLength > 4)
            {
                MessageBox.Show("No Member Tidak Valid", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTmembership.Text = string.Empty;
                checkBox1.Checked = false;
            }
        }

        private void BTNstock_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockObat openForm = new StockObat(TXTcounterPesanObat.Text);
            openForm.Show();
        }

        private void TXThargaobat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
