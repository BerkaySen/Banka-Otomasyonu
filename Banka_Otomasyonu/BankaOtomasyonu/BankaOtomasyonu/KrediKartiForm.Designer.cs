
namespace BankaOtomasyonu
{
    partial class KrediKartiForm
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
            this.GroupBoxKartOlustur = new System.Windows.Forms.GroupBox();
            this.BtnKrediKartOlustur = new System.Windows.Forms.Button();
            this.CmbSonOdeme = new System.Windows.Forms.ComboBox();
            this.CmbHesapKesim = new System.Windows.Forms.ComboBox();
            this.CmbEkstreGun = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKartOlusturIptal = new System.Windows.Forms.Button();
            this.LblKartOlusturMusteriNo = new System.Windows.Forms.Label();
            this.GroupBoxIslemler = new System.Windows.Forms.GroupBox();
            this.LblMusteriBilgi = new System.Windows.Forms.Label();
            this.BtnKartOlustur = new System.Windows.Forms.Button();
            this.BtnMusteriSec = new System.Windows.Forms.Button();
            this.GroupBoxMusteriSecim = new System.Windows.Forms.GroupBox();
            this.BtnMusteriAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnMusteriSecimIptal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBoxKartOlustur.SuspendLayout();
            this.GroupBoxIslemler.SuspendLayout();
            this.GroupBoxMusteriSecim.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxKartOlustur
            // 
            this.GroupBoxKartOlustur.Controls.Add(this.BtnKrediKartOlustur);
            this.GroupBoxKartOlustur.Controls.Add(this.CmbSonOdeme);
            this.GroupBoxKartOlustur.Controls.Add(this.CmbHesapKesim);
            this.GroupBoxKartOlustur.Controls.Add(this.CmbEkstreGun);
            this.GroupBoxKartOlustur.Controls.Add(this.label4);
            this.GroupBoxKartOlustur.Controls.Add(this.label3);
            this.GroupBoxKartOlustur.Controls.Add(this.label1);
            this.GroupBoxKartOlustur.Controls.Add(this.BtnKartOlusturIptal);
            this.GroupBoxKartOlustur.Controls.Add(this.LblKartOlusturMusteriNo);
            this.GroupBoxKartOlustur.Location = new System.Drawing.Point(324, 78);
            this.GroupBoxKartOlustur.Name = "GroupBoxKartOlustur";
            this.GroupBoxKartOlustur.Size = new System.Drawing.Size(556, 390);
            this.GroupBoxKartOlustur.TabIndex = 0;
            this.GroupBoxKartOlustur.TabStop = false;
            this.GroupBoxKartOlustur.Text = "Kredi Kartı Oluştur Panel";
            // 
            // BtnKrediKartOlustur
            // 
            this.BtnKrediKartOlustur.Location = new System.Drawing.Point(181, 335);
            this.BtnKrediKartOlustur.Name = "BtnKrediKartOlustur";
            this.BtnKrediKartOlustur.Size = new System.Drawing.Size(172, 37);
            this.BtnKrediKartOlustur.TabIndex = 11;
            this.BtnKrediKartOlustur.Text = "Oluştur";
            this.BtnKrediKartOlustur.UseVisualStyleBackColor = true;
            this.BtnKrediKartOlustur.Click += new System.EventHandler(this.BtnKrediKartOlustur_Click);
            // 
            // CmbSonOdeme
            // 
            this.CmbSonOdeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSonOdeme.FormattingEnabled = true;
            this.CmbSonOdeme.Location = new System.Drawing.Point(167, 142);
            this.CmbSonOdeme.Name = "CmbSonOdeme";
            this.CmbSonOdeme.Size = new System.Drawing.Size(91, 24);
            this.CmbSonOdeme.TabIndex = 10;
            // 
            // CmbHesapKesim
            // 
            this.CmbHesapKesim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbHesapKesim.FormattingEnabled = true;
            this.CmbHesapKesim.Location = new System.Drawing.Point(168, 105);
            this.CmbHesapKesim.Name = "CmbHesapKesim";
            this.CmbHesapKesim.Size = new System.Drawing.Size(91, 24);
            this.CmbHesapKesim.TabIndex = 9;
            // 
            // CmbEkstreGun
            // 
            this.CmbEkstreGun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEkstreGun.FormattingEnabled = true;
            this.CmbEkstreGun.Location = new System.Drawing.Point(167, 179);
            this.CmbEkstreGun.Name = "CmbEkstreGun";
            this.CmbEkstreGun.Size = new System.Drawing.Size(91, 24);
            this.CmbEkstreGun.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aylık Ekstre Günü :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Son Odeme Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hesap Kesim Tarihi :";
            // 
            // BtnKartOlusturIptal
            // 
            this.BtnKartOlusturIptal.Location = new System.Drawing.Point(359, 335);
            this.BtnKartOlusturIptal.Name = "BtnKartOlusturIptal";
            this.BtnKartOlusturIptal.Size = new System.Drawing.Size(172, 37);
            this.BtnKartOlusturIptal.TabIndex = 4;
            this.BtnKartOlusturIptal.Text = "İptal";
            this.BtnKartOlusturIptal.UseVisualStyleBackColor = true;
            this.BtnKartOlusturIptal.Click += new System.EventHandler(this.BtnKartOlusturIptal_Click);
            // 
            // LblKartOlusturMusteriNo
            // 
            this.LblKartOlusturMusteriNo.AutoSize = true;
            this.LblKartOlusturMusteriNo.Location = new System.Drawing.Point(78, 65);
            this.LblKartOlusturMusteriNo.Name = "LblKartOlusturMusteriNo";
            this.LblKartOlusturMusteriNo.Size = new System.Drawing.Size(84, 17);
            this.LblKartOlusturMusteriNo.TabIndex = 0;
            this.LblKartOlusturMusteriNo.Text = "Müşteri No :";
            // 
            // GroupBoxIslemler
            // 
            this.GroupBoxIslemler.Controls.Add(this.button1);
            this.GroupBoxIslemler.Controls.Add(this.LblMusteriBilgi);
            this.GroupBoxIslemler.Controls.Add(this.BtnKartOlustur);
            this.GroupBoxIslemler.Controls.Add(this.BtnMusteriSec);
            this.GroupBoxIslemler.Location = new System.Drawing.Point(33, 78);
            this.GroupBoxIslemler.Name = "GroupBoxIslemler";
            this.GroupBoxIslemler.Size = new System.Drawing.Size(261, 390);
            this.GroupBoxIslemler.TabIndex = 1;
            this.GroupBoxIslemler.TabStop = false;
            this.GroupBoxIslemler.Text = "İşlemler";
            // 
            // LblMusteriBilgi
            // 
            this.LblMusteriBilgi.AutoSize = true;
            this.LblMusteriBilgi.Location = new System.Drawing.Point(6, 34);
            this.LblMusteriBilgi.Name = "LblMusteriBilgi";
            this.LblMusteriBilgi.Size = new System.Drawing.Size(103, 17);
            this.LblMusteriBilgi.TabIndex = 2;
            this.LblMusteriBilgi.Text = "Müşteri Bilgileri";
            // 
            // BtnKartOlustur
            // 
            this.BtnKartOlustur.Location = new System.Drawing.Point(6, 230);
            this.BtnKartOlustur.Name = "BtnKartOlustur";
            this.BtnKartOlustur.Size = new System.Drawing.Size(249, 43);
            this.BtnKartOlustur.TabIndex = 3;
            this.BtnKartOlustur.Text = "Kart Oluştur";
            this.BtnKartOlustur.UseVisualStyleBackColor = true;
            this.BtnKartOlustur.Click += new System.EventHandler(this.BtnKartOlustur_Click);
            // 
            // BtnMusteriSec
            // 
            this.BtnMusteriSec.Location = new System.Drawing.Point(6, 171);
            this.BtnMusteriSec.Name = "BtnMusteriSec";
            this.BtnMusteriSec.Size = new System.Drawing.Size(249, 43);
            this.BtnMusteriSec.TabIndex = 2;
            this.BtnMusteriSec.Text = "Müşteri Seç";
            this.BtnMusteriSec.UseVisualStyleBackColor = true;
            this.BtnMusteriSec.Click += new System.EventHandler(this.BtnMusteriSec_Click);
            // 
            // GroupBoxMusteriSecim
            // 
            this.GroupBoxMusteriSecim.Controls.Add(this.BtnMusteriAra);
            this.GroupBoxMusteriSecim.Controls.Add(this.label2);
            this.GroupBoxMusteriSecim.Controls.Add(this.textBox1);
            this.GroupBoxMusteriSecim.Controls.Add(this.BtnMusteriSecimIptal);
            this.GroupBoxMusteriSecim.Location = new System.Drawing.Point(324, 78);
            this.GroupBoxMusteriSecim.Name = "GroupBoxMusteriSecim";
            this.GroupBoxMusteriSecim.Size = new System.Drawing.Size(474, 390);
            this.GroupBoxMusteriSecim.TabIndex = 2;
            this.GroupBoxMusteriSecim.TabStop = false;
            this.GroupBoxMusteriSecim.Text = "Musteri Secim Paneli";
            // 
            // BtnMusteriAra
            // 
            this.BtnMusteriAra.Location = new System.Drawing.Point(252, 75);
            this.BtnMusteriAra.Name = "BtnMusteriAra";
            this.BtnMusteriAra.Size = new System.Drawing.Size(172, 33);
            this.BtnMusteriAra.TabIndex = 3;
            this.BtnMusteriAra.Text = "Ara";
            this.BtnMusteriAra.UseVisualStyleBackColor = true;
            this.BtnMusteriAra.Click += new System.EventHandler(this.BtnMusteriAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Tc Kimlik Numarası Giriniz :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // BtnMusteriSecimIptal
            // 
            this.BtnMusteriSecimIptal.Location = new System.Drawing.Point(252, 115);
            this.BtnMusteriSecimIptal.Name = "BtnMusteriSecimIptal";
            this.BtnMusteriSecimIptal.Size = new System.Drawing.Size(172, 37);
            this.BtnMusteriSecimIptal.TabIndex = 0;
            this.BtnMusteriSecimIptal.Text = "Iptal";
            this.BtnMusteriSecimIptal.UseVisualStyleBackColor = true;
            this.BtnMusteriSecimIptal.Click += new System.EventHandler(this.BtnMusteriSecimIptal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bakiye Islemleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KrediKartiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 1055);
            this.Controls.Add(this.GroupBoxMusteriSecim);
            this.Controls.Add(this.GroupBoxIslemler);
            this.Controls.Add(this.GroupBoxKartOlustur);
            this.Name = "KrediKartiForm";
            this.Text = "KrediKartiForm";
            this.Load += new System.EventHandler(this.KrediKartiForm_Load);
            this.GroupBoxKartOlustur.ResumeLayout(false);
            this.GroupBoxKartOlustur.PerformLayout();
            this.GroupBoxIslemler.ResumeLayout(false);
            this.GroupBoxIslemler.PerformLayout();
            this.GroupBoxMusteriSecim.ResumeLayout(false);
            this.GroupBoxMusteriSecim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxKartOlustur;
        private System.Windows.Forms.Label LblKartOlusturMusteriNo;
        private System.Windows.Forms.GroupBox GroupBoxIslemler;
        private System.Windows.Forms.Label LblMusteriBilgi;
        private System.Windows.Forms.Button BtnKartOlustur;
        private System.Windows.Forms.Button BtnMusteriSec;
        private System.Windows.Forms.GroupBox GroupBoxMusteriSecim;
        private System.Windows.Forms.Button BtnMusteriSecimIptal;
        private System.Windows.Forms.Button BtnMusteriAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnKartOlusturIptal;
        private System.Windows.Forms.ComboBox CmbEkstreGun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSonOdeme;
        private System.Windows.Forms.ComboBox CmbHesapKesim;
        private System.Windows.Forms.Button BtnKrediKartOlustur;
        private System.Windows.Forms.Button button1;
    }
}