namespace ProjectPASYazid
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            PNLLogin = new Panel();
            BTNlogin = new Button();
            BTNclose = new Button();
            CBshowpassword = new CheckBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            TXTconfirmpassword = new TextBox();
            TXTpassword = new TextBox();
            TXTusername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            PNLLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PNLLogin
            // 
            PNLLogin.BackColor = Color.White;
            PNLLogin.Controls.Add(BTNlogin);
            PNLLogin.Controls.Add(BTNclose);
            PNLLogin.Controls.Add(CBshowpassword);
            PNLLogin.Controls.Add(pictureBox2);
            PNLLogin.Controls.Add(pictureBox1);
            PNLLogin.Controls.Add(TXTconfirmpassword);
            PNLLogin.Controls.Add(TXTpassword);
            PNLLogin.Controls.Add(TXTusername);
            PNLLogin.Controls.Add(label3);
            PNLLogin.Controls.Add(label2);
            PNLLogin.Controls.Add(label1);
            PNLLogin.Location = new Point(155, 112);
            PNLLogin.Name = "PNLLogin";
            PNLLogin.Size = new Size(479, 484);
            PNLLogin.TabIndex = 0;
            // 
            // BTNlogin
            // 
            BTNlogin.BackColor = Color.DarkGreen;
            BTNlogin.FlatStyle = FlatStyle.Flat;
            BTNlogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNlogin.ForeColor = Color.White;
            BTNlogin.Location = new Point(102, 360);
            BTNlogin.Name = "BTNlogin";
            BTNlogin.Size = new Size(126, 49);
            BTNlogin.TabIndex = 11;
            BTNlogin.Text = "Login";
            BTNlogin.UseVisualStyleBackColor = false;
            BTNlogin.Click += BTNlogin_Click;
            // 
            // BTNclose
            // 
            BTNclose.BackColor = Color.DarkGreen;
            BTNclose.FlatStyle = FlatStyle.Flat;
            BTNclose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNclose.ForeColor = Color.White;
            BTNclose.Location = new Point(242, 360);
            BTNclose.Name = "BTNclose";
            BTNclose.Size = new Size(134, 49);
            BTNclose.TabIndex = 10;
            BTNclose.Text = "Close";
            BTNclose.UseVisualStyleBackColor = false;
            BTNclose.Click += BTNclose_Click;
            // 
            // CBshowpassword
            // 
            CBshowpassword.AutoSize = true;
            CBshowpassword.BackColor = Color.Transparent;
            CBshowpassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CBshowpassword.ForeColor = Color.DarkGreen;
            CBshowpassword.Location = new Point(102, 312);
            CBshowpassword.Name = "CBshowpassword";
            CBshowpassword.Size = new Size(166, 29);
            CBshowpassword.TabIndex = 8;
            CBshowpassword.Text = "Show Password";
            CBshowpassword.UseVisualStyleBackColor = false;
            CBshowpassword.CheckedChanged += CBshowpassword_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(102, 157);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(102, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // TXTconfirmpassword
            // 
            TXTconfirmpassword.Location = new Point(102, 272);
            TXTconfirmpassword.Name = "TXTconfirmpassword";
            TXTconfirmpassword.PasswordChar = '*';
            TXTconfirmpassword.Size = new Size(269, 31);
            TXTconfirmpassword.TabIndex = 5;
            // 
            // TXTpassword
            // 
            TXTpassword.Location = new Point(102, 188);
            TXTpassword.Name = "TXTpassword";
            TXTpassword.PasswordChar = '*';
            TXTpassword.Size = new Size(269, 31);
            TXTpassword.TabIndex = 4;
            // 
            // TXTusername
            // 
            TXTusername.Location = new Point(102, 105);
            TXTusername.Name = "TXTusername";
            TXTusername.Size = new Size(269, 31);
            TXTusername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(102, 241);
            label3.Name = "label3";
            label3.Size = new Size(199, 28);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password  : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(141, 157);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 1;
            label2.Text = "Password  : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(141, 74);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 0;
            label1.Text = "Username : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGreen;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(287, 88);
            label4.Name = "label4";
            label4.Padding = new Padding(60, 5, 60, 5);
            label4.Size = new Size(210, 48);
            label4.TabIndex = 12;
            label4.Text = "Login";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 679);
            Controls.Add(label4);
            Controls.Add(PNLLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            PNLLogin.ResumeLayout(false);
            PNLLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PNLLogin;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BTNclose;
        private CheckBox CBshowpassword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox TXTconfirmpassword;
        private TextBox TXTpassword;
        private TextBox TXTusername;
        private Button BTNlogin;
        private Label label4;
    }
}
