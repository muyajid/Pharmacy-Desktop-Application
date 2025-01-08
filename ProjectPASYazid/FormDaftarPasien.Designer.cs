namespace ProjectPASYazid
{
    partial class FormDaftarPasien
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDaftarPasien));
            GBinputdata = new GroupBox();
            Membership_Card = new ListBox();
            TXTnoHP = new TextBox();
            label8 = new Label();
            BTNinputdata = new Button();
            BTNmembership = new Button();
            TXTcodemember = new TextBox();
            TXTalamatpasien = new TextBox();
            RBwanita = new RadioButton();
            RBlakilaki = new RadioButton();
            NMRCumur = new NumericUpDown();
            TXTnama = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            GBtampildata = new GroupBox();
            BTNhapusdata = new Button();
            DGmembership = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            BTNviewsdata = new Button();
            PCuser2 = new PictureBox();
            PCuser3 = new PictureBox();
            PCuser1 = new PictureBox();
            BTNdashboard = new Button();
            BTNdaftarobat = new Button();
            BTNpesanobat = new Button();
            BTNdaftarpasien = new Button();
            BTNaccount = new Button();
            BTNclose = new Button();
            TXTcounterDaftarPasien = new TextBox();
            BTNstock = new Button();
            panel1 = new Panel();
            GBinputdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NMRCumur).BeginInit();
            GBtampildata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGmembership).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PCuser2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PCuser3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PCuser1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // GBinputdata
            // 
            GBinputdata.Controls.Add(Membership_Card);
            GBinputdata.Controls.Add(TXTnoHP);
            GBinputdata.Controls.Add(label8);
            GBinputdata.Controls.Add(BTNinputdata);
            GBinputdata.Controls.Add(BTNmembership);
            GBinputdata.Controls.Add(TXTcodemember);
            GBinputdata.Controls.Add(TXTalamatpasien);
            GBinputdata.Controls.Add(RBwanita);
            GBinputdata.Controls.Add(RBlakilaki);
            GBinputdata.Controls.Add(NMRCumur);
            GBinputdata.Controls.Add(TXTnama);
            GBinputdata.Controls.Add(label7);
            GBinputdata.Controls.Add(label6);
            GBinputdata.Controls.Add(label5);
            GBinputdata.Controls.Add(label4);
            GBinputdata.Controls.Add(label3);
            GBinputdata.ForeColor = Color.White;
            GBinputdata.Location = new Point(292, 169);
            GBinputdata.Name = "GBinputdata";
            GBinputdata.Size = new Size(930, 449);
            GBinputdata.TabIndex = 5;
            GBinputdata.TabStop = false;
            GBinputdata.Text = "Input Data Pasien Baru";
            GBinputdata.Enter += GBinputdata_Enter;
            // 
            // Membership_Card
            // 
            Membership_Card.BackColor = Color.FromArgb(192, 255, 192);
            Membership_Card.FormattingEnabled = true;
            Membership_Card.ItemHeight = 25;
            Membership_Card.Location = new Point(552, 59);
            Membership_Card.Name = "Membership_Card";
            Membership_Card.Size = new Size(330, 329);
            Membership_Card.TabIndex = 15;
            // 
            // TXTnoHP
            // 
            TXTnoHP.Location = new Point(244, 265);
            TXTnoHP.Name = "TXTnoHP";
            TXTnoHP.Size = new Size(251, 31);
            TXTnoHP.TabIndex = 14;
            TXTnoHP.TextChanged += TXTnoHP_TextChanged;
            TXTnoHP.KeyPress += TXTnoHP_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(41, 268);
            label8.Name = "label8";
            label8.Size = new Size(125, 28);
            label8.TabIndex = 13;
            label8.Text = "Nomer HP : ";
            // 
            // BTNinputdata
            // 
            BTNinputdata.BackColor = Color.DarkGreen;
            BTNinputdata.FlatStyle = FlatStyle.Flat;
            BTNinputdata.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNinputdata.ForeColor = Color.Transparent;
            BTNinputdata.Location = new Point(222, 361);
            BTNinputdata.Name = "BTNinputdata";
            BTNinputdata.Size = new Size(154, 46);
            BTNinputdata.TabIndex = 12;
            BTNinputdata.Text = "Input Data";
            BTNinputdata.UseVisualStyleBackColor = false;
            BTNinputdata.Click += BTNinputdata_Click;
            // 
            // BTNmembership
            // 
            BTNmembership.BackColor = Color.DarkGreen;
            BTNmembership.FlatStyle = FlatStyle.Flat;
            BTNmembership.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNmembership.Location = new Point(42, 361);
            BTNmembership.Name = "BTNmembership";
            BTNmembership.Size = new Size(154, 46);
            BTNmembership.TabIndex = 1;
            BTNmembership.Text = "Membership";
            BTNmembership.UseVisualStyleBackColor = false;
            BTNmembership.Click += BTNmembership_Click_1;
            // 
            // TXTcodemember
            // 
            TXTcodemember.BackColor = SystemColors.ActiveBorder;
            TXTcodemember.Location = new Point(244, 312);
            TXTcodemember.Name = "TXTcodemember";
            TXTcodemember.ReadOnly = true;
            TXTcodemember.Size = new Size(251, 31);
            TXTcodemember.TabIndex = 11;
            // 
            // TXTalamatpasien
            // 
            TXTalamatpasien.Location = new Point(244, 192);
            TXTalamatpasien.Multiline = true;
            TXTalamatpasien.Name = "TXTalamatpasien";
            TXTalamatpasien.Size = new Size(251, 61);
            TXTalamatpasien.TabIndex = 10;
            // 
            // RBwanita
            // 
            RBwanita.AutoSize = true;
            RBwanita.Location = new Point(376, 150);
            RBwanita.Name = "RBwanita";
            RBwanita.Size = new Size(91, 29);
            RBwanita.TabIndex = 9;
            RBwanita.TabStop = true;
            RBwanita.Text = "Wanita";
            RBwanita.UseVisualStyleBackColor = true;
            // 
            // RBlakilaki
            // 
            RBlakilaki.AutoSize = true;
            RBlakilaki.Location = new Point(244, 150);
            RBlakilaki.Name = "RBlakilaki";
            RBlakilaki.Size = new Size(114, 29);
            RBlakilaki.TabIndex = 8;
            RBlakilaki.TabStop = true;
            RBlakilaki.Text = "Laki - Laki";
            RBlakilaki.UseVisualStyleBackColor = true;
            // 
            // NMRCumur
            // 
            NMRCumur.Location = new Point(244, 106);
            NMRCumur.Name = "NMRCumur";
            NMRCumur.ReadOnly = true;
            NMRCumur.Size = new Size(131, 31);
            NMRCumur.TabIndex = 7;
            // 
            // TXTnama
            // 
            TXTnama.Location = new Point(244, 63);
            TXTnama.Name = "TXTnama";
            TXTnama.Size = new Size(251, 31);
            TXTnama.TabIndex = 5;
            TXTnama.Click += TXTnama_Click;
            TXTnama.TextChanged += TXTnama_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(41, 312);
            label7.Name = "label7";
            label7.Size = new Size(197, 28);
            label7.TabIndex = 4;
            label7.Text = "Kode Membership  :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(42, 149);
            label6.Name = "label6";
            label6.Size = new Size(153, 28);
            label6.TabIndex = 3;
            label6.Text = "Jenis Kelamin : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 192);
            label5.Name = "label5";
            label5.Size = new Size(162, 28);
            label5.TabIndex = 2;
            label5.Text = "Alamat Pasien  : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 106);
            label4.Name = "label4";
            label4.Size = new Size(150, 28);
            label4.TabIndex = 1;
            label4.Text = "Umur Pasien  : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 63);
            label3.Name = "label3";
            label3.Size = new Size(152, 28);
            label3.TabIndex = 0;
            label3.Text = "Nama Pasien  : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(292, 88);
            label1.Name = "label1";
            label1.Size = new Size(220, 45);
            label1.TabIndex = 6;
            label1.Text = "Daftar Pasien";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGreen;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(519, 100);
            label2.Name = "label2";
            label2.Padding = new Padding(5, 0, 5, 0);
            label2.Size = new Size(226, 25);
            label2.TabIndex = 7;
            label2.Text = "Apotek Sumber Makmur";
            // 
            // GBtampildata
            // 
            GBtampildata.Controls.Add(BTNhapusdata);
            GBtampildata.Controls.Add(DGmembership);
            GBtampildata.ForeColor = Color.Black;
            GBtampildata.Location = new Point(290, 174);
            GBtampildata.Name = "GBtampildata";
            GBtampildata.Size = new Size(932, 444);
            GBtampildata.TabIndex = 9;
            GBtampildata.TabStop = false;
            GBtampildata.Text = "Data Mempership";
            GBtampildata.Visible = false;
            GBtampildata.Enter += GBtampildata_Enter;
            // 
            // BTNhapusdata
            // 
            BTNhapusdata.BackColor = Color.DarkGreen;
            BTNhapusdata.FlatStyle = FlatStyle.Flat;
            BTNhapusdata.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNhapusdata.ForeColor = Color.White;
            BTNhapusdata.Location = new Point(19, 46);
            BTNhapusdata.Name = "BTNhapusdata";
            BTNhapusdata.Size = new Size(147, 35);
            BTNhapusdata.TabIndex = 11;
            BTNhapusdata.Text = "Hapus Data";
            BTNhapusdata.UseVisualStyleBackColor = false;
            BTNhapusdata.Click += BTNhapusdata_Click;
            // 
            // DGmembership
            // 
            DGmembership.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGmembership.BackgroundColor = Color.FromArgb(192, 255, 192);
            DGmembership.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGmembership.Columns.AddRange(new DataGridViewColumn[] { Column6, Column7, Column8, Column9, Column1, Column10 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DGmembership.DefaultCellStyle = dataGridViewCellStyle1;
            DGmembership.Location = new Point(19, 102);
            DGmembership.Name = "DGmembership";
            DGmembership.ReadOnly = true;
            DGmembership.RowHeadersWidth = 62;
            DGmembership.Size = new Size(897, 316);
            DGmembership.TabIndex = 10;
            // 
            // Column6
            // 
            Column6.HeaderText = "Nama";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Umur";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Kelamin";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "Alamat";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "No HP";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "ID member";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // BTNviewsdata
            // 
            BTNviewsdata.BackColor = Color.DarkGreen;
            BTNviewsdata.FlatStyle = FlatStyle.Flat;
            BTNviewsdata.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNviewsdata.ForeColor = Color.White;
            BTNviewsdata.Location = new Point(1075, 105);
            BTNviewsdata.Name = "BTNviewsdata";
            BTNviewsdata.Size = new Size(147, 35);
            BTNviewsdata.TabIndex = 10;
            BTNviewsdata.Text = "Lihat Data";
            BTNviewsdata.UseVisualStyleBackColor = false;
            BTNviewsdata.Click += BTNviewsdata_Click;
            // 
            // PCuser2
            // 
            PCuser2.Image = (Image)resources.GetObject("PCuser2.Image");
            PCuser2.Location = new Point(71, 59);
            PCuser2.Name = "PCuser2";
            PCuser2.Size = new Size(98, 89);
            PCuser2.SizeMode = PictureBoxSizeMode.StretchImage;
            PCuser2.TabIndex = 7;
            PCuser2.TabStop = false;
            PCuser2.Visible = false;
            PCuser2.Click += PCuser2_Click;
            // 
            // PCuser3
            // 
            PCuser3.Image = (Image)resources.GetObject("PCuser3.Image");
            PCuser3.Location = new Point(71, 59);
            PCuser3.Name = "PCuser3";
            PCuser3.Size = new Size(98, 89);
            PCuser3.SizeMode = PictureBoxSizeMode.StretchImage;
            PCuser3.TabIndex = 8;
            PCuser3.TabStop = false;
            PCuser3.Visible = false;
            PCuser3.Click += PCuser3_Click;
            // 
            // PCuser1
            // 
            PCuser1.Image = (Image)resources.GetObject("PCuser1.Image");
            PCuser1.Location = new Point(71, 59);
            PCuser1.Name = "PCuser1";
            PCuser1.Size = new Size(98, 89);
            PCuser1.SizeMode = PictureBoxSizeMode.StretchImage;
            PCuser1.TabIndex = 6;
            PCuser1.TabStop = false;
            PCuser1.Click += PCuser1_Click;
            // 
            // BTNdashboard
            // 
            BTNdashboard.BackColor = Color.DarkGreen;
            BTNdashboard.FlatStyle = FlatStyle.Flat;
            BTNdashboard.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNdashboard.ForeColor = Color.White;
            BTNdashboard.Location = new Point(39, 173);
            BTNdashboard.Name = "BTNdashboard";
            BTNdashboard.Size = new Size(164, 49);
            BTNdashboard.TabIndex = 0;
            BTNdashboard.Text = "Dashboard";
            BTNdashboard.UseVisualStyleBackColor = false;
            BTNdashboard.Click += BTNdashboard_Click;
            // 
            // BTNdaftarobat
            // 
            BTNdaftarobat.BackColor = Color.DarkGreen;
            BTNdaftarobat.FlatStyle = FlatStyle.Flat;
            BTNdaftarobat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNdaftarobat.ForeColor = Color.White;
            BTNdaftarobat.Location = new Point(39, 228);
            BTNdaftarobat.Name = "BTNdaftarobat";
            BTNdaftarobat.Size = new Size(164, 49);
            BTNdaftarobat.TabIndex = 1;
            BTNdaftarobat.Text = "Info Obat";
            BTNdaftarobat.UseVisualStyleBackColor = false;
            BTNdaftarobat.Click += BTNdaftarobat_Click;
            // 
            // BTNpesanobat
            // 
            BTNpesanobat.BackColor = Color.DarkGreen;
            BTNpesanobat.FlatStyle = FlatStyle.Flat;
            BTNpesanobat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNpesanobat.ForeColor = Color.White;
            BTNpesanobat.Location = new Point(39, 283);
            BTNpesanobat.Name = "BTNpesanobat";
            BTNpesanobat.Size = new Size(164, 49);
            BTNpesanobat.TabIndex = 2;
            BTNpesanobat.Text = "Pesan Obat";
            BTNpesanobat.UseVisualStyleBackColor = false;
            BTNpesanobat.Click += BTNpesanobat_Click;
            // 
            // BTNdaftarpasien
            // 
            BTNdaftarpasien.BackColor = Color.SeaGreen;
            BTNdaftarpasien.FlatStyle = FlatStyle.Flat;
            BTNdaftarpasien.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNdaftarpasien.ForeColor = Color.White;
            BTNdaftarpasien.Location = new Point(40, 394);
            BTNdaftarpasien.Name = "BTNdaftarpasien";
            BTNdaftarpasien.Size = new Size(164, 49);
            BTNdaftarpasien.TabIndex = 3;
            BTNdaftarpasien.Text = "Daftar Pasien";
            BTNdaftarpasien.UseVisualStyleBackColor = false;
            // 
            // BTNaccount
            // 
            BTNaccount.BackColor = Color.DarkGreen;
            BTNaccount.FlatStyle = FlatStyle.Flat;
            BTNaccount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNaccount.ForeColor = Color.White;
            BTNaccount.Location = new Point(40, 478);
            BTNaccount.Name = "BTNaccount";
            BTNaccount.Size = new Size(164, 49);
            BTNaccount.TabIndex = 4;
            BTNaccount.Text = "Account";
            BTNaccount.UseVisualStyleBackColor = false;
            BTNaccount.Click += BTNaccount_Click;
            // 
            // BTNclose
            // 
            BTNclose.BackColor = Color.DarkGreen;
            BTNclose.FlatStyle = FlatStyle.Flat;
            BTNclose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNclose.ForeColor = Color.White;
            BTNclose.Location = new Point(40, 533);
            BTNclose.Name = "BTNclose";
            BTNclose.Size = new Size(164, 49);
            BTNclose.TabIndex = 5;
            BTNclose.Text = "Close";
            BTNclose.UseVisualStyleBackColor = false;
            BTNclose.Click += BTNclose_Click;
            // 
            // TXTcounterDaftarPasien
            // 
            TXTcounterDaftarPasien.Location = new Point(72, 588);
            TXTcounterDaftarPasien.Name = "TXTcounterDaftarPasien";
            TXTcounterDaftarPasien.ReadOnly = true;
            TXTcounterDaftarPasien.Size = new Size(132, 31);
            TXTcounterDaftarPasien.TabIndex = 4;
            TXTcounterDaftarPasien.Visible = false;
            TXTcounterDaftarPasien.TextChanged += TXTcounterDaftarPasien_TextChanged;
            // 
            // BTNstock
            // 
            BTNstock.BackColor = Color.DarkGreen;
            BTNstock.FlatStyle = FlatStyle.Flat;
            BTNstock.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNstock.ForeColor = Color.White;
            BTNstock.Location = new Point(40, 339);
            BTNstock.Name = "BTNstock";
            BTNstock.Size = new Size(164, 49);
            BTNstock.TabIndex = 17;
            BTNstock.Text = "Stock Obat";
            BTNstock.UseVisualStyleBackColor = false;
            BTNstock.Click += BTNstock_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BTNstock);
            panel1.Controls.Add(TXTcounterDaftarPasien);
            panel1.Controls.Add(BTNclose);
            panel1.Controls.Add(BTNaccount);
            panel1.Controls.Add(BTNdaftarpasien);
            panel1.Controls.Add(BTNpesanobat);
            panel1.Controls.Add(BTNdaftarobat);
            panel1.Controls.Add(BTNdashboard);
            panel1.Controls.Add(PCuser1);
            panel1.Controls.Add(PCuser3);
            panel1.Controls.Add(PCuser2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 671);
            panel1.TabIndex = 3;
            // 
            // FormDaftarPasien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1316, 671);
            Controls.Add(BTNviewsdata);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(GBinputdata);
            Controls.Add(GBtampildata);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDaftarPasien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDaftarPasien";
            Load += FormDaftarPasien_Load;
            GBinputdata.ResumeLayout(false);
            GBinputdata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NMRCumur).EndInit();
            GBtampildata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGmembership).EndInit();
            ((System.ComponentModel.ISupportInitialize)PCuser2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PCuser3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PCuser1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox GBinputdata;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox TXTnama;
        private Label label7;
        private NumericUpDown NMRCumur;
        private TextBox TXTalamatpasien;
        private RadioButton RBwanita;
        private RadioButton RBlakilaki;
        private Button BTNmembership;
        private TextBox TXTcodemember;
        private GroupBox GBtampildata;
        private DataGridView DGmembership;
        private Button BTNhapusdata;
        private Button BTNinputdata;
        private Button BTNviewsdata;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column10;
        private TextBox TXTnoHP;
        private Label label8;
        private PictureBox PCuser2;
        private PictureBox PCuser3;
        private PictureBox PCuser1;
        private Button BTNdashboard;
        private Button BTNdaftarobat;
        private Button BTNpesanobat;
        private Button BTNdaftarpasien;
        private Button BTNaccount;
        private Button BTNclose;
        private TextBox TXTcounterDaftarPasien;
        private Button BTNstock;
        private Panel panel1;
        private ListBox Membership_Card;
    }
}