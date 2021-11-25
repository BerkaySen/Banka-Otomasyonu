
namespace BankaOtomasyonu
{
    partial class KullaniciKayitForm
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
            this.LblTc = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.LblSoyad = new System.Windows.Forms.Label();
            this.LblDogumTarih = new System.Windows.Forms.Label();
            this.TxbTcNo = new System.Windows.Forms.TextBox();
            this.TxbIsım = new System.Windows.Forms.TextBox();
            this.TxtbSoyisim = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TbSifre = new System.Windows.Forms.TextBox();
            this.CmbStatu = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTc
            // 
            this.LblTc.AutoSize = true;
            this.LblTc.Location = new System.Drawing.Point(12, 38);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(94, 17);
            this.LblTc.TabIndex = 0;
            this.LblTc.Text = "Tc Kimlik No :";
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Location = new System.Drawing.Point(12, 76);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(40, 17);
            this.LblAd.TabIndex = 1;
            this.LblAd.Text = "İsim :";
            // 
            // LblSoyad
            // 
            this.LblSoyad.AutoSize = true;
            this.LblSoyad.Location = new System.Drawing.Point(12, 115);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(64, 17);
            this.LblSoyad.TabIndex = 2;
            this.LblSoyad.Text = "Soyisim :";
            // 
            // LblDogumTarih
            // 
            this.LblDogumTarih.AutoSize = true;
            this.LblDogumTarih.Location = new System.Drawing.Point(12, 149);
            this.LblDogumTarih.Name = "LblDogumTarih";
            this.LblDogumTarih.Size = new System.Drawing.Size(119, 17);
            this.LblDogumTarih.TabIndex = 3;
            this.LblDogumTarih.Text = "Doğum Tarihiniz :";
            // 
            // TxbTcNo
            // 
            this.TxbTcNo.Location = new System.Drawing.Point(140, 38);
            this.TxbTcNo.Name = "TxbTcNo";
            this.TxbTcNo.Size = new System.Drawing.Size(146, 22);
            this.TxbTcNo.TabIndex = 4;
            // 
            // TxbIsım
            // 
            this.TxbIsım.Location = new System.Drawing.Point(140, 76);
            this.TxbIsım.Name = "TxbIsım";
            this.TxbIsım.Size = new System.Drawing.Size(146, 22);
            this.TxbIsım.TabIndex = 5;
            // 
            // TxtbSoyisim
            // 
            this.TxtbSoyisim.Location = new System.Drawing.Point(140, 115);
            this.TxtbSoyisim.Name = "TxtbSoyisim";
            this.TxtbSoyisim.Size = new System.Drawing.Size(146, 22);
            this.TxtbSoyisim.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Statu :";
            // 
            // TbKullaniciAdi
            // 
            this.TbKullaniciAdi.Location = new System.Drawing.Point(112, 49);
            this.TbKullaniciAdi.Name = "TbKullaniciAdi";
            this.TbKullaniciAdi.Size = new System.Drawing.Size(121, 22);
            this.TbKullaniciAdi.TabIndex = 12;
            // 
            // TbSifre
            // 
            this.TbSifre.Location = new System.Drawing.Point(112, 87);
            this.TbSifre.Name = "TbSifre";
            this.TbSifre.Size = new System.Drawing.Size(121, 22);
            this.TbSifre.TabIndex = 13;
            // 
            // CmbStatu
            // 
            this.CmbStatu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStatu.FormattingEnabled = true;
            this.CmbStatu.Location = new System.Drawing.Point(112, 131);
            this.CmbStatu.Name = "CmbStatu";
            this.CmbStatu.Size = new System.Drawing.Size(121, 24);
            this.CmbStatu.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.LblTc);
            this.groupBox1.Controls.Add(this.LblAd);
            this.groupBox1.Controls.Add(this.LblSoyad);
            this.groupBox1.Controls.Add(this.LblDogumTarih);
            this.groupBox1.Controls.Add(this.TxbTcNo);
            this.groupBox1.Controls.Add(this.TxbIsım);
            this.groupBox1.Controls.Add(this.TxtbSoyisim);
            this.groupBox1.Location = new System.Drawing.Point(22, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 207);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TbKullaniciAdi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CmbStatu);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TbSifre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(429, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 207);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sistem Bilgileri";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 45);
            this.button2.TabIndex = 17;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KullaniciKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 624);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "KullaniciKayitForm";
            this.Text = "KullaniciKayitForm";
            this.Load += new System.EventHandler(this.KullaniciKayitForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTc;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label LblSoyad;
        private System.Windows.Forms.Label LblDogumTarih;
        private System.Windows.Forms.TextBox TxbTcNo;
        private System.Windows.Forms.TextBox TxbIsım;
        private System.Windows.Forms.TextBox TxtbSoyisim;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbKullaniciAdi;
        private System.Windows.Forms.TextBox TbSifre;
        private System.Windows.Forms.ComboBox CmbStatu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
    }
}