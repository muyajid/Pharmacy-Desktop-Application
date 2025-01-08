namespace ProjectPASYazid
{
    partial class StockObat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockObat));
            panel1 = new Panel();
            BTNstock = new Button();
            TXTcounterStock = new TextBox();
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TXTnamaobat = new TextBox();
            TXThargaproduct = new TextBox();
            NMRCstockproduk = new NumericUpDown();
            BTNtambahobat = new Button();
            BTNupdateobat = new Button();
            BTNhapusobat = new Button();
            DGobat = new DataGridView();
            NamaProduk = new DataGridViewTextBoxColumn();
            HargaProduck = new DataGridViewTextBoxColumn();
            StockProduk = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PCuser2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PCuser1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PCuser3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NMRCstockproduk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGobat).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BTNstock);
            panel1.Controls.Add(TXTcounterStock);
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
            panel1.Size = new Size(247, 663);
            panel1.TabIndex = 4;
            // 
            // BTNstock
            // 
            BTNstock.BackColor = Color.SeaGreen;
            BTNstock.FlatStyle = FlatStyle.Flat;
            BTNstock.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNstock.ForeColor = Color.White;
            BTNstock.Location = new Point(40, 339);
            BTNstock.Name = "BTNstock";
            BTNstock.Size = new Size(164, 49);
            BTNstock.TabIndex = 17;
            BTNstock.Text = "Stock Obat";
            BTNstock.UseVisualStyleBackColor = false;
            // 
            // TXTcounterStock
            // 
            TXTcounterStock.Location = new Point(72, 588);
            TXTcounterStock.Name = "TXTcounterStock";
            TXTcounterStock.ReadOnly = true;
            TXTcounterStock.Size = new Size(89, 31);
            TXTcounterStock.TabIndex = 4;
            TXTcounterStock.Visible = false;
            TXTcounterStock.TextChanged += TXTcounterStock_TextChanged;
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
            // BTNdaftarpasien
            // 
            BTNdaftarpasien.BackColor = Color.DarkGreen;
            BTNdaftarpasien.FlatStyle = FlatStyle.Flat;
            BTNdaftarpasien.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNdaftarpasien.ForeColor = Color.White;
            BTNdaftarpasien.Location = new Point(40, 394);
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
            BTNpesanobat.Location = new Point(39, 283);
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
            BTNdaftarobat.Location = new Point(39, 228);
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
            BTNdashboard.Location = new Point(39, 173);
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
            PCuser2.Location = new Point(72, 59);
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
            PCuser1.Location = new Point(71, 59);
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
            PCuser3.Location = new Point(71, 59);
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
            label1.Location = new Point(281, 167);
            label1.Name = "label1";
            label1.Size = new Size(272, 38);
            label1.TabIndex = 18;
            label1.Text = "Management Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGreen;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(281, 205);
            label2.Name = "label2";
            label2.Padding = new Padding(25, 0, 25, 0);
            label2.Size = new Size(287, 28);
            label2.TabIndex = 19;
            label2.Text = "Apotek Sumber Makmur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(281, 291);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 20;
            label3.Text = "Nama Produk : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(281, 334);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 21;
            label4.Text = "Harga Produk : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(281, 376);
            label5.Name = "label5";
            label5.Size = new Size(135, 25);
            label5.TabIndex = 22;
            label5.Text = "Stock Produk : ";
            // 
            // TXTnamaobat
            // 
            TXTnamaobat.Location = new Point(426, 288);
            TXTnamaobat.Name = "TXTnamaobat";
            TXTnamaobat.Size = new Size(213, 31);
            TXTnamaobat.TabIndex = 23;
            // 
            // TXThargaproduct
            // 
            TXThargaproduct.Location = new Point(426, 331);
            TXThargaproduct.Name = "TXThargaproduct";
            TXThargaproduct.Size = new Size(213, 31);
            TXThargaproduct.TabIndex = 24;
            TXThargaproduct.KeyPress += TXThargaproduct_KeyPress;
            // 
            // NMRCstockproduk
            // 
            NMRCstockproduk.Location = new Point(426, 374);
            NMRCstockproduk.Name = "NMRCstockproduk";
            NMRCstockproduk.ReadOnly = true;
            NMRCstockproduk.Size = new Size(213, 31);
            NMRCstockproduk.TabIndex = 25;
            // 
            // BTNtambahobat
            // 
            BTNtambahobat.BackColor = Color.DarkGreen;
            BTNtambahobat.FlatStyle = FlatStyle.Flat;
            BTNtambahobat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNtambahobat.ForeColor = Color.White;
            BTNtambahobat.Location = new Point(281, 459);
            BTNtambahobat.Name = "BTNtambahobat";
            BTNtambahobat.Size = new Size(108, 50);
            BTNtambahobat.TabIndex = 26;
            BTNtambahobat.Text = "Tambah";
            BTNtambahobat.UseVisualStyleBackColor = false;
            BTNtambahobat.Click += BTNtambahobat_Click;
            // 
            // BTNupdateobat
            // 
            BTNupdateobat.BackColor = Color.DarkGreen;
            BTNupdateobat.FlatStyle = FlatStyle.Flat;
            BTNupdateobat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNupdateobat.ForeColor = Color.White;
            BTNupdateobat.Location = new Point(407, 459);
            BTNupdateobat.Name = "BTNupdateobat";
            BTNupdateobat.Size = new Size(104, 50);
            BTNupdateobat.TabIndex = 27;
            BTNupdateobat.Text = "Update";
            BTNupdateobat.UseVisualStyleBackColor = false;
            BTNupdateobat.Click += BTNupdateobat_Click;
            // 
            // BTNhapusobat
            // 
            BTNhapusobat.BackColor = Color.DarkGreen;
            BTNhapusobat.FlatStyle = FlatStyle.Flat;
            BTNhapusobat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNhapusobat.ForeColor = Color.White;
            BTNhapusobat.Location = new Point(528, 459);
            BTNhapusobat.Name = "BTNhapusobat";
            BTNhapusobat.Size = new Size(111, 50);
            BTNhapusobat.TabIndex = 28;
            BTNhapusobat.Text = "Hapus";
            BTNhapusobat.UseVisualStyleBackColor = false;
            BTNhapusobat.Click += BTNhapusobat_Click;
            // 
            // DGobat
            // 
            DGobat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGobat.BackgroundColor = Color.FromArgb(192, 255, 192);
            DGobat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGobat.Columns.AddRange(new DataGridViewColumn[] { NamaProduk, HargaProduck, StockProduk });
            DGobat.Location = new Point(682, 167);
            DGobat.Name = "DGobat";
            DGobat.ReadOnly = true;
            DGobat.RowHeadersWidth = 62;
            DGobat.Size = new Size(672, 342);
            DGobat.TabIndex = 29;
            // 
            // NamaProduk
            // 
            NamaProduk.HeaderText = "Nama Produk";
            NamaProduk.MinimumWidth = 8;
            NamaProduk.Name = "NamaProduk";
            NamaProduk.ReadOnly = true;
            // 
            // HargaProduck
            // 
            HargaProduck.HeaderText = "Harga Produk";
            HargaProduck.MinimumWidth = 8;
            HargaProduck.Name = "HargaProduck";
            HargaProduck.ReadOnly = true;
            // 
            // StockProduk
            // 
            StockProduk.HeaderText = "Stock Produk";
            StockProduk.MinimumWidth = 8;
            StockProduk.Name = "StockProduk";
            StockProduk.ReadOnly = true;
            // 
            // StockObat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1382, 663);
            Controls.Add(DGobat);
            Controls.Add(BTNhapusobat);
            Controls.Add(BTNupdateobat);
            Controls.Add(BTNtambahobat);
            Controls.Add(NMRCstockproduk);
            Controls.Add(TXThargaproduct);
            Controls.Add(TXTnamaobat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockObat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update";
            Load += StockObat_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PCuser2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PCuser1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PCuser3).EndInit();
            ((System.ComponentModel.ISupportInitialize)NMRCstockproduk).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGobat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button BTNstock;
        private TextBox TXTcounterStock;
        private Button BTNclose;
        private Button BTNaccount;
        private Button BTNdaftarpasien;
        private Button BTNpesanobat;
        private Button BTNdaftarobat;
        private Button BTNdashboard;
        private PictureBox PCuser1;
        private PictureBox PCuser3;
        private PictureBox PCuser2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TXTnamaobat;
        private TextBox TXThargaproduct;
        private NumericUpDown NMRCstockproduk;
        private Button BTNtambahobat;
        private Button BTNupdateobat;
        private Button BTNhapusobat;
        private DataGridView DGobat;
        private DataGridViewTextBoxColumn NamaProduk;
        private DataGridViewTextBoxColumn HargaProduck;
        private DataGridViewTextBoxColumn StockProduk;
    }
}