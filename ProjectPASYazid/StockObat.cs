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
    public partial class StockObat : Form
    {                   
        public StockObat(string counterImageStock)
        {
            InitializeComponent();
            TXTcounterStock.Text = counterImageStock;
            NMRCstockproduk.Minimum = 1;
        }

        private void BTNdashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDashboard openForm = new FormDashboard(TXTcounterStock.Text);
            openForm.Show();
        }

        private void BTNdaftarobat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDaftarObat openForm = new FormDaftarObat(TXTcounterStock.Text);
            openForm.Show();
        }

        private void BTNpesanobat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPesanObat openForm = new FormPesanObat(TXTcounterStock.Text);
            openForm.Show();
        }

        private void BTNdaftarpasien_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDaftarPasien openForm = new FormDaftarPasien(TXTcounterStock.Text);
            openForm.Show();
        }

        private void BTNaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAccounts openForm = new FormAccounts(TXTcounterStock.Text);
            openForm.Show();
        }

        private void BTNclose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Yakin Ingin Keluar", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                FormLogin openForm = new FormLogin();
                openForm.Show();
            }
        }
        private void ShowAccount()
        {
            DialogResult dialog = MessageBox.Show("Ingin Ganti Foto Profile?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                FormAccounts openForms = new FormAccounts(TXTcounterStock.Text);
                openForms.Show();
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

        private void TXTcounterStock_TextChanged(object sender, EventArgs e)
        {
            if (TXTcounterStock.Text == "FotoUser1")
            {
                PCuser1.Visible = true;
                PCuser2.Visible = false;
                PCuser3.Visible = false;
            }
            else if (TXTcounterStock.Text == "FotoUser2")
            {
                PCuser1.Visible = false;
                PCuser2.Visible = true;
                PCuser3.Visible = false;
            }
            else if (TXTcounterStock.Text == "FotoUser3")
            {
                PCuser1.Visible = false;
                PCuser2.Visible = false;
                PCuser3.Visible = true;
            }
        }

        private void BTNtambahobat_Click(object sender, EventArgs e)
        {
            if (TXTnamaobat.Text == string.Empty || TXThargaproduct.Text == string.Empty || NMRCstockproduk.Value < 1)
            {
                MessageBox.Show("Isi Data Terlebih Dahulu !!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RemoveAll();
                return;
            }

            DialogResult dialog = MessageBox.Show("Ingin Tambah Produk", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                DGobat.Rows.Add(TXTnamaobat.Text, TXThargaproduct.Text, NMRCstockproduk.Value);
                RemoveAll();
            }
        }

        private void TXThargaproduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void RemoveData()
        {
            if (DGobat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih Bari Yang Ingin Dihapus !!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialog = MessageBox.Show("Yakin Ingin Hapus Data ?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                for (int h = DGobat.Rows.Count - 1; h >= 0; h--)
                {
                    if (DGobat.Rows[h].Selected)
                    {
                        DGobat.Rows.RemoveAt(h);
                    }
                }
            }
        }
        private void BTNhapusobat_Click(object sender, EventArgs e)
        {
            RemoveData();
        }
        private void RemoveAll()
        {
            TXTnamaobat.Text = string.Empty;
            TXThargaproduct.Text = string.Empty;
            NMRCstockproduk.Value = 1;
        }

        private void BTNupdateobat_Click(object sender, EventArgs e)
        {
            if (TXTnamaobat.Text == string.Empty || TXThargaproduct.Text == string.Empty || NMRCstockproduk.Value < 1)
            {
                MessageBox.Show("Pastikan Isi Data Dulu", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                RemoveAll();
                return;
            }

            DialogResult dialog = MessageBox.Show("Ingin Update Data?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                DataGridViewRow AmbilRow = DGobat.SelectedRows[0];

                AmbilRow.Cells["NamaProduk"].Value = TXTnamaobat.Text;
                AmbilRow.Cells["HargaProduck"].Value = TXThargaproduct.Text;
                AmbilRow.Cells["StockProduk"].Value = NMRCstockproduk.Value;

                RemoveAll();
            }
            else if (dialog == DialogResult.No)
            {
                RemoveAll();
                return;
            }
        }

        private void StockObat_Load(object sender, EventArgs e)
        {


        }
    }
}
