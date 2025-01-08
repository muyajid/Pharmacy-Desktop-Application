namespace ProjectPASYazid
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CBshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (TXTpassword.Text == string.Empty && TXTconfirmpassword.Text == string.Empty)
            {
                DialogResult dialog = MessageBox.Show("Kamu Belum Memasukan Username || Password", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK)
                {
                    CBshowpassword.Checked = false;
                    return;
                }
            }
            if (CBshowpassword.Checked == true)
            {
                TXTpassword.PasswordChar = '\0';
                TXTconfirmpassword.PasswordChar = '\0';
            }
            else if (CBshowpassword.Checked == false)
            {
                TXTpassword.PasswordChar = '*';
                TXTconfirmpassword.PasswordChar = '*';
            }
        }

        private void BTNclose_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Yakin Ingin Keluar ? ", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            if (TXTusername.Text == "admin" && TXTpassword.Text == "admin123" && TXTconfirmpassword.Text == "admin123")
            {
                this.Hide();
                FormDashboard openDashboard = new FormDashboard(null);
                openDashboard.Show();

            } else if (TXTusername.Text == string.Empty && TXTpassword.Text == string.Empty && TXTconfirmpassword.Text == string.Empty)
            {
                MessageBox.Show("Kamu Belum Memasukan Username || Password", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTusername.Text = string.Empty;
                TXTpassword.Text = string.Empty;
                TXTconfirmpassword.Text = string.Empty;
                return;
            }
            else
            {
                MessageBox.Show("Username || Password Salah", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTusername.Text = string.Empty;
                TXTpassword.Text = string.Empty;
                TXTconfirmpassword.Text = string.Empty;
                return;
            }
        }
    }
}
