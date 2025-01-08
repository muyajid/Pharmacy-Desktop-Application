namespace ProjectPASYazid
{
    partial class FormAccounts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccounts));
            panel1 = new Panel();
            BTNstock = new Button();
            BTNclose = new Button();
            BTNaccount = new Button();
            BTNdaftarpasien = new Button();
            BTNpesanobat = new Button();
            BTNdaftarobat = new Button();
            BTNdashboard = new Button();
            PCuser2 = new PictureBox();
            PCuser1 = new PictureBox();
            PCuser3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            CMBswicthprofile = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            TXTcounterAccounts = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PCuser2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PCuser1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PCuser3).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BTNstock);
            panel1.Controls.Add(BTNclose);
            panel1.Controls.Add(BTNaccount);
            panel1.Controls.Add(BTNdaftarpasien);
            panel1.Controls.Add(BTNpesanobat);
            panel1.Controls.Add(BTNdaftarobat);
            panel1.Controls.Add(BTNdashboard);
            panel1.Controls.Add(PCuser2);
            panel1.Controls.Add(PCuser1);
            panel1.Controls.Add(PCuser3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 664);
            panel1.TabIndex = 2;
            // 
            // BTNstock
            // 
            BTNstock.BackColor = Color.DarkGreen;
            BTNstock.FlatStyle = FlatStyle.Flat;
            BTNstock.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNstock.ForeColor = Color.White;
            BTNstock.Location = new Point(39, 316);
            BTNstock.Name = "BTNstock";
            BTNstock.Size = new Size(164, 49);
            BTNstock.TabIndex = 18;
            BTNstock.Text = "Stock Obat";
            BTNstock.UseVisualStyleBackColor = false;
            BTNstock.Click += BTNstock_Click;
            // 
            // BTNclose
            // 
            BTNclose.BackColor = Color.DarkGreen;
            BTNclose.FlatStyle = FlatStyle.Flat;
            BTNclose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNclose.ForeColor = Color.White;
            BTNclose.Location = new Point(39, 510);
            BTNclose.Name = "BTNclose";
            BTNclose.Size = new Size(164, 49);
            BTNclose.TabIndex = 5;
            BTNclose.Text = "Close";
            BTNclose.UseVisualStyleBackColor = false;
            BTNclose.Click += BTNclose_Click;
            // 
            // BTNaccount
            // 
            BTNaccount.BackColor = Color.SeaGreen;
            BTNaccount.FlatStyle = FlatStyle.Flat;
            BTNaccount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNaccount.ForeColor = Color.White;
            BTNaccount.Location = new Point(39, 455);
            BTNaccount.Name = "BTNaccount";
            BTNaccount.Size = new Size(164, 49);
            BTNaccount.TabIndex = 4;
            BTNaccount.Text = "Account";
            BTNaccount.UseVisualStyleBackColor = false;
            // 
            // BTNdaftarpasien
            // 
            BTNdaftarpasien.BackColor = Color.DarkGreen;
            BTNdaftarpasien.FlatStyle = FlatStyle.Flat;
            BTNdaftarpasien.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNdaftarpasien.ForeColor = Color.White;
            BTNdaftarpasien.Location = new Point(39, 371);
            BTNdaftarpasien.Name = "BTNdaftarpasien";
            BTNdaftarpasien.Size = new Size(164, 49);
            BTNdaftarpasien.TabIndex = 3;
            BTNdaftarpasien.Text = "Daftar Pasien";
            BTNdaftarpasien.UseVisualStyleBackColor = false;
            BTNdaftarpasien.Click += BTNdaftarpasien_Click;
            // 
            // BTNpesanobat
            // 
            BTNpesanobat.BackColor = Color.DarkGreen;
            BTNpesanobat.FlatStyle = FlatStyle.Flat;
            BTNpesanobat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNpesanobat.ForeColor = Color.White;
            BTNpesanobat.Location = new Point(39, 256);
            BTNpesanobat.Name = "BTNpesanobat";
            BTNpesanobat.Size = new Size(164, 49);
            BTNpesanobat.TabIndex = 2;
            BTNpesanobat.Text = "Pesan Obat";
            BTNpesanobat.UseVisualStyleBackColor = false;
            BTNpesanobat.Click += BTNpesanobat_Click;
            // 
            // BTNdaftarobat
            // 
            BTNdaftarobat.BackColor = Color.DarkGreen;
            BTNdaftarobat.FlatStyle = FlatStyle.Flat;
            BTNdaftarobat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNdaftarobat.ForeColor = Color.White;
            BTNdaftarobat.Location = new Point(39, 201);
            BTNdaftarobat.Name = "BTNdaftarobat";
            BTNdaftarobat.Size = new Size(164, 49);
            BTNdaftarobat.TabIndex = 1;
            BTNdaftarobat.Text = "Info Obat";
            BTNdaftarobat.UseVisualStyleBackColor = false;
            BTNdaftarobat.Click += BTNdaftarobat_Click;
            // 
            // BTNdashboard
            // 
            BTNdashboard.BackColor = Color.DarkGreen;
            BTNdashboard.FlatStyle = FlatStyle.Flat;
            BTNdashboard.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNdashboard.ForeColor = Color.White;
            BTNdashboard.Location = new Point(39, 146);
            BTNdashboard.Name = "BTNdashboard";
            BTNdashboard.Size = new Size(164, 49);
            BTNdashboard.TabIndex = 0;
            BTNdashboard.Text = "Dashboard";
            BTNdashboard.UseVisualStyleBackColor = false;
            BTNdashboard.Click += BTNdashboard_Click;
            // 
            // PCuser2
            // 
            PCuser2.Image = (Image)resources.GetObject("PCuser2.Image");
            PCuser2.Location = new Point(71, 32);
            PCuser2.Name = "PCuser2";
            PCuser2.Size = new Size(98, 89);
            PCuser2.SizeMode = PictureBoxSizeMode.StretchImage;
            PCuser2.TabIndex = 7;
            PCuser2.TabStop = false;
            PCuser2.Visible = false;
            PCuser2.Click += PCuser2_Click;
            // 
            // PCuser1
            // 
            PCuser1.Image = (Image)resources.GetObject("PCuser1.Image");
            PCuser1.Location = new Point(71, 32);
            PCuser1.Name = "PCuser1";
            PCuser1.Size = new Size(98, 89);
            PCuser1.SizeMode = PictureBoxSizeMode.StretchImage;
            PCuser1.TabIndex = 6;
            PCuser1.TabStop = false;
            PCuser1.Click += PCuser1_Click;
            // 
            // PCuser3
            // 
            PCuser3.Image = (Image)resources.GetObject("PCuser3.Image");
            PCuser3.Location = new Point(71, 32);
            PCuser3.Name = "PCuser3";
            PCuser3.Size = new Size(98, 89);
            PCuser3.SizeMode = PictureBoxSizeMode.StretchImage;
            PCuser3.TabIndex = 8;
            PCuser3.TabStop = false;
            PCuser3.Visible = false;
            PCuser3.Click += PCuser3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 56);
            label1.Name = "label1";
            label1.Size = new Size(240, 38);
            label1.TabIndex = 3;
            label1.Text = "Accounts Setting";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 131);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 4;
            label2.Text = "Ganti Foto Profile : ";
            // 
            // CMBswicthprofile
            // 
            CMBswicthprofile.DropDownStyle = ComboBoxStyle.DropDownList;
            CMBswicthprofile.FormattingEnabled = true;
            CMBswicthprofile.Items.AddRange(new object[] { "", "FotoUser1", "FotoUser2", "FotoUser3" });
            CMBswicthprofile.Location = new Point(212, 128);
            CMBswicthprofile.Name = "CMBswicthprofile";
            CMBswicthprofile.Size = new Size(244, 33);
            CMBswicthprofile.TabIndex = 5;
            CMBswicthprofile.SelectedIndexChanged += CMBswicthprofile_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 178);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 6;
            label3.Text = "Username : ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(212, 178);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(244, 31);
            textBox1.TabIndex = 7;
            textBox1.Text = "admin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(32, 223);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 8;
            label4.Text = "Password : ";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(212, 220);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(244, 31);
            textBox2.TabIndex = 9;
            textBox2.Text = "admin123";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(CMBswicthprofile);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(380, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(492, 306);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = ".";
            // 
            // TXTcounterAccounts
            // 
            TXTcounterAccounts.Location = new Point(380, 153);
            TXTcounterAccounts.Name = "TXTcounterAccounts";
            TXTcounterAccounts.ReadOnly = true;
            TXTcounterAccounts.Size = new Size(190, 31);
            TXTcounterAccounts.TabIndex = 11;
            TXTcounterAccounts.Visible = false;
            TXTcounterAccounts.TextChanged += TXTcounterAccounts_TextChanged;
            // 
            // FormAccounts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1036, 664);
            Controls.Add(TXTcounterAccounts);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAccounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAccounts";
            Load += FormAccounts_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PCuser2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PCuser1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PCuser3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button BTNclose;
        private Button BTNaccount;
        private Button BTNdaftarpasien;
        private Button BTNpesanobat;
        private Button BTNdaftarobat;
        private Button BTNdashboard;
        private PictureBox PCuser3;
        private PictureBox PCuser2;
        private PictureBox PCuser1;
        private Label label1;
        private Label label2;
        private ComboBox CMBswicthprofile;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private TextBox TXTcounterAccounts;
        private Button BTNstock;
    }
}