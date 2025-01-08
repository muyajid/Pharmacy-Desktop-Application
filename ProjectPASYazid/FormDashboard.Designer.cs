namespace ProjectPASYazid
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            panel1 = new Panel();
            BTNclose = new Button();
            BTNaccount = new Button();
            BTNdaftarpasien = new Button();
            BTNpesanobat = new Button();
            BTNdaftarobat = new Button();
            BTNdashboard = new Button();
            PCuser2 = new PictureBox();
            PCuser1 = new PictureBox();
            PCuser3 = new PictureBox();
            TXTcounterDashboard = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label13 = new Label();
            label14 = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            label10 = new Label();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            BTNstock = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PCuser2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PCuser1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PCuser3).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            panel1.Controls.Add(TXTcounterDashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 610);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BTNclose
            // 
            BTNclose.BackColor = Color.DarkGreen;
            BTNclose.FlatStyle = FlatStyle.Flat;
            BTNclose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNclose.ForeColor = Color.White;
            BTNclose.Location = new Point(39, 507);
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
            BTNaccount.Location = new Point(39, 452);
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
            BTNdaftarpasien.Location = new Point(39, 361);
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
            BTNpesanobat.Location = new Point(39, 253);
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
            BTNdaftarobat.Location = new Point(39, 198);
            BTNdaftarobat.Name = "BTNdaftarobat";
            BTNdaftarobat.Size = new Size(164, 49);
            BTNdaftarobat.TabIndex = 1;
            BTNdaftarobat.Text = "Info Obat";
            BTNdaftarobat.UseVisualStyleBackColor = false;
            BTNdaftarobat.Click += BTNdaftarobat_Click;
            // 
            // BTNdashboard
            // 
            BTNdashboard.BackColor = Color.SeaGreen;
            BTNdashboard.FlatStyle = FlatStyle.Flat;
            BTNdashboard.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNdashboard.ForeColor = Color.White;
            BTNdashboard.Location = new Point(39, 143);
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
            PCuser2.Location = new Point(71, 29);
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
            PCuser1.Location = new Point(71, 29);
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
            PCuser3.Location = new Point(71, 29);
            PCuser3.Name = "PCuser3";
            PCuser3.Size = new Size(98, 89);
            PCuser3.SizeMode = PictureBoxSizeMode.StretchImage;
            PCuser3.TabIndex = 8;
            PCuser3.TabStop = false;
            PCuser3.Visible = false;
            PCuser3.Click += PCuser3_Click;
            // 
            // TXTcounterDashboard
            // 
            TXTcounterDashboard.Location = new Point(39, 565);
            TXTcounterDashboard.Name = "TXTcounterDashboard";
            TXTcounterDashboard.ReadOnly = true;
            TXTcounterDashboard.Size = new Size(164, 31);
            TXTcounterDashboard.TabIndex = 1;
            TXTcounterDashboard.Visible = false;
            TXTcounterDashboard.TextChanged += TXTcounterDashboard_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(544, 61);
            label1.Name = "label1";
            label1.Size = new Size(281, 41);
            label1.TabIndex = 1;
            label1.Text = "Selamat Datang Di";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGreen;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(519, 102);
            label2.Name = "label2";
            label2.Padding = new Padding(50, 0, 50, 0);
            label2.Size = new Size(337, 28);
            label2.TabIndex = 2;
            label2.Text = "Apotek Sumber Makmur";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(367, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(637, 393);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(63, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(512, 120);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data Profesi";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.DarkGreen;
            label13.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(167, 77);
            label13.Name = "label13";
            label13.Padding = new Padding(5, 2, 80, 2);
            label13.Size = new Size(255, 25);
            label13.TabIndex = 3;
            label13.Text = "Kompounding, Farmasi";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(16, 77);
            label14.Name = "label14";
            label14.Size = new Size(96, 25);
            label14.TabIndex = 2;
            label14.Text = "Kehalian : ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.DarkGreen;
            label12.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(167, 40);
            label12.Name = "label12";
            label12.Padding = new Padding(5, 2, 70, 2);
            label12.Size = new Size(256, 25);
            label12.TabIndex = 1;
            label12.Text = "Apotek Sumber Makmur";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(16, 39);
            label11.Name = "label11";
            label11.Size = new Size(149, 25);
            label11.TabIndex = 0;
            label11.Text = "Tempat Praktik : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkGreen;
            label9.FlatStyle = FlatStyle.Flat;
            label9.ForeColor = Color.White;
            label9.Location = new Point(238, 195);
            label9.Name = "label9";
            label9.Padding = new Padding(5, 2, 100, 2);
            label9.Size = new Size(251, 29);
            label9.TabIndex = 7;
            label9.Text = "0821-3263-0818";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(61, 195);
            label10.Name = "label10";
            label10.Size = new Size(126, 28);
            label10.TabIndex = 6;
            label10.Text = "Nomor HP : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkGreen;
            label7.FlatStyle = FlatStyle.Flat;
            label7.ForeColor = Color.White;
            label7.Location = new Point(239, 127);
            label7.Name = "label7";
            label7.Padding = new Padding(5, 2, 70, 2);
            label7.Size = new Size(323, 54);
            label7.TabIndex = 5;
            label7.Text = "JL Jendral ahmad yani no 165,\r\nKarangkates Sumberpucung.\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(62, 127);
            label8.Name = "label8";
            label8.Size = new Size(182, 28);
            label8.TabIndex = 4;
            label8.Text = "Alamat Apoteker : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkGreen;
            label5.FlatStyle = FlatStyle.Flat;
            label5.ForeColor = Color.White;
            label5.Location = new Point(239, 83);
            label5.Name = "label5";
            label5.Padding = new Padding(5, 2, 70, 2);
            label5.Size = new Size(243, 29);
            label5.TabIndex = 3;
            label5.Text = "STRA - 12345/2024";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(62, 83);
            label6.Name = "label6";
            label6.Size = new Size(146, 28);
            label6.TabIndex = 2;
            label6.Text = "Nomor STRA : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGreen;
            label4.FlatStyle = FlatStyle.Flat;
            label4.ForeColor = Color.White;
            label4.Location = new Point(239, 36);
            label4.Name = "label4";
            label4.Padding = new Padding(5, 2, 150, 2);
            label4.Size = new Size(242, 29);
            label4.TabIndex = 1;
            label4.Text = "John Doe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(62, 35);
            label3.Name = "label3";
            label3.Size = new Size(172, 28);
            label3.TabIndex = 0;
            label3.Text = "Nama Apoteker : ";
            // 
            // BTNstock
            // 
            BTNstock.BackColor = Color.DarkGreen;
            BTNstock.FlatStyle = FlatStyle.Flat;
            BTNstock.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BTNstock.ForeColor = Color.White;
            BTNstock.Location = new Point(39, 308);
            BTNstock.Name = "BTNstock";
            BTNstock.Size = new Size(164, 49);
            BTNstock.TabIndex = 9;
            BTNstock.Text = "Stock Obat";
            BTNstock.UseVisualStyleBackColor = false;
            BTNstock.Click += BTNstock_Click;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1161, 610);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PCuser2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PCuser1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PCuser3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button BTNdaftarobat;
        private Button BTNdashboard;
        private Button BTNpesanobat;
        private Button BTNclose;
        private Button BTNaccount;
        private Button BTNdaftarpasien;
        private PictureBox PCuser1;
        private PictureBox PCuser3;
        private PictureBox PCuser2;
        private TextBox TXTcounterDashboard;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label10;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label6;
        private GroupBox groupBox2;
        private Label label13;
        private Label label14;
        private Label label12;
        private Label label11;
        private Button BTNstock;
    }
}