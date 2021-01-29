namespace MezunBilgiSistemi
{
    partial class Form1
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
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.pBoxPassword = new System.Windows.Forms.PictureBox();
            this.pBoxUser = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cikis = new System.Windows.Forms.Label();
            this.lblHataKullanici = new System.Windows.Forms.Label();
            this.lblHataSifre = new System.Windows.Forms.Label();
            this.lblHata = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(87, 215);
            this.txtKullaniciAdi.MaxLength = 11;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(210, 15);
            this.txtKullaniciAdi.TabIndex = 1;
            this.txtKullaniciAdi.Text = "TC";
            this.txtKullaniciAdi.Click += new System.EventHandler(this.txtKullaniciAdi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(57, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(57, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 1);
            this.panel2.TabIndex = 5;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.White;
            this.txtSifre.Location = new System.Drawing.Point(87, 282);
            this.txtSifre.MaxLength = 25;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(210, 15);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.Click += new System.EventHandler(this.txtSifre_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnGirisYap.Location = new System.Drawing.Point(117, 344);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(120, 35);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // pBoxPassword
            // 
            this.pBoxPassword.BackgroundImage = global::MezunBilgiSistemi.Properties.Resources.padlock;
            this.pBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pBoxPassword.Location = new System.Drawing.Point(57, 275);
            this.pBoxPassword.Name = "pBoxPassword";
            this.pBoxPassword.Size = new System.Drawing.Size(30, 30);
            this.pBoxPassword.TabIndex = 3;
            this.pBoxPassword.TabStop = false;
            // 
            // pBoxUser
            // 
            this.pBoxUser.BackgroundImage = global::MezunBilgiSistemi.Properties.Resources.user;
            this.pBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pBoxUser.Location = new System.Drawing.Point(57, 208);
            this.pBoxUser.Name = "pBoxUser";
            this.pBoxUser.Size = new System.Drawing.Size(30, 30);
            this.pBoxUser.TabIndex = 0;
            this.pBoxUser.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(43, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "MANİSA CELAL BAYAR ÜNİVERSTESİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(83, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "MEZUN BİLGİ SİSTEMİ";
            // 
            // Cikis
            // 
            this.Cikis.AutoSize = true;
            this.Cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cikis.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cikis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Cikis.Location = new System.Drawing.Point(324, 9);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(14, 14);
            this.Cikis.TabIndex = 9;
            this.Cikis.Text = "X";
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // lblHataKullanici
            // 
            this.lblHataKullanici.AutoSize = true;
            this.lblHataKullanici.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHataKullanici.ForeColor = System.Drawing.Color.Red;
            this.lblHataKullanici.Location = new System.Drawing.Point(54, 242);
            this.lblHataKullanici.Name = "lblHataKullanici";
            this.lblHataKullanici.Size = new System.Drawing.Size(133, 15);
            this.lblHataKullanici.TabIndex = 10;
            this.lblHataKullanici.Text = "! Kullanıcı Adı Boş Bırakılamaz";
            this.lblHataKullanici.Visible = false;
            // 
            // lblHataSifre
            // 
            this.lblHataSifre.AutoSize = true;
            this.lblHataSifre.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHataSifre.ForeColor = System.Drawing.Color.Red;
            this.lblHataSifre.Location = new System.Drawing.Point(57, 309);
            this.lblHataSifre.Name = "lblHataSifre";
            this.lblHataSifre.Size = new System.Drawing.Size(101, 15);
            this.lblHataSifre.TabIndex = 11;
            this.lblHataSifre.Text = "! Şifre Boş Bırakılamaz";
            this.lblHataSifre.Visible = false;
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHata.ForeColor = System.Drawing.Color.Red;
            this.lblHata.Location = new System.Drawing.Point(57, 190);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(134, 15);
            this.lblHata.TabIndex = 12;
            this.lblHata.Text = "! Hatalı Kullanıcı Adı veya Şifre";
            this.lblHata.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.lblHataSifre);
            this.Controls.Add(this.lblHataKullanici);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBoxPassword);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.pBoxUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxUser;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.PictureBox pBoxPassword;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Cikis;
        private System.Windows.Forms.Label lblHataKullanici;
        private System.Windows.Forms.Label lblHataSifre;
        private System.Windows.Forms.Label lblHata;
    }
}

