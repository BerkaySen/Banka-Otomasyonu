
namespace BankaOtomasyonu
{
    partial class BakiyeForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbHesapNoSec = new System.Windows.Forms.ComboBox();
            this.CmbHesapTur = new System.Windows.Forms.ComboBox();
            this.BtnBakiyeCikar = new System.Windows.Forms.Button();
            this.TxbTutar = new System.Windows.Forms.TextBox();
            this.BtnBakiyeEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LblBakiyePanelBakiye = new System.Windows.Forms.Label();
            this.LblBakiyePanelIbanNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Hesap Seçiniz >>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hesap Türünü Seçiniz >>";
            // 
            // CmbHesapNoSec
            // 
            this.CmbHesapNoSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbHesapNoSec.FormattingEnabled = true;
            this.CmbHesapNoSec.Location = new System.Drawing.Point(299, 218);
            this.CmbHesapNoSec.Name = "CmbHesapNoSec";
            this.CmbHesapNoSec.Size = new System.Drawing.Size(151, 24);
            this.CmbHesapNoSec.TabIndex = 13;
            this.CmbHesapNoSec.SelectedIndexChanged += new System.EventHandler(this.CmbHesapNoSec_SelectedIndexChanged);
            // 
            // CmbHesapTur
            // 
            this.CmbHesapTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbHesapTur.FormattingEnabled = true;
            this.CmbHesapTur.Location = new System.Drawing.Point(299, 177);
            this.CmbHesapTur.Name = "CmbHesapTur";
            this.CmbHesapTur.Size = new System.Drawing.Size(151, 24);
            this.CmbHesapTur.TabIndex = 12;
            this.CmbHesapTur.SelectedIndexChanged += new System.EventHandler(this.CmbHesapTur_SelectedIndexChanged);
            // 
            // BtnBakiyeCikar
            // 
            this.BtnBakiyeCikar.ForeColor = System.Drawing.Color.Red;
            this.BtnBakiyeCikar.Location = new System.Drawing.Point(375, 258);
            this.BtnBakiyeCikar.Name = "BtnBakiyeCikar";
            this.BtnBakiyeCikar.Size = new System.Drawing.Size(75, 36);
            this.BtnBakiyeCikar.TabIndex = 19;
            this.BtnBakiyeCikar.Text = "Çıkar";
            this.BtnBakiyeCikar.UseVisualStyleBackColor = true;
            this.BtnBakiyeCikar.Click += new System.EventHandler(this.BtnBakiyeCikar_Click);
            // 
            // TxbTutar
            // 
            this.TxbTutar.Location = new System.Drawing.Point(299, 140);
            this.TxbTutar.Name = "TxbTutar";
            this.TxbTutar.Size = new System.Drawing.Size(151, 22);
            this.TxbTutar.TabIndex = 16;
            this.TxbTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbTutar_KeyPress);
            // 
            // BtnBakiyeEkle
            // 
            this.BtnBakiyeEkle.ForeColor = System.Drawing.Color.ForestGreen;
            this.BtnBakiyeEkle.Location = new System.Drawing.Point(299, 258);
            this.BtnBakiyeEkle.Name = "BtnBakiyeEkle";
            this.BtnBakiyeEkle.Size = new System.Drawing.Size(75, 36);
            this.BtnBakiyeEkle.TabIndex = 18;
            this.BtnBakiyeEkle.Text = "Ekle";
            this.BtnBakiyeEkle.UseVisualStyleBackColor = true;
            this.BtnBakiyeEkle.Click += new System.EventHandler(this.BtnBakiyeEkle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tutar Giriniz :";
            // 
            // LblBakiyePanelBakiye
            // 
            this.LblBakiyePanelBakiye.AutoSize = true;
            this.LblBakiyePanelBakiye.Location = new System.Drawing.Point(476, 221);
            this.LblBakiyePanelBakiye.Name = "LblBakiyePanelBakiye";
            this.LblBakiyePanelBakiye.Size = new System.Drawing.Size(12, 17);
            this.LblBakiyePanelBakiye.TabIndex = 21;
            this.LblBakiyePanelBakiye.Text = ".";
            // 
            // LblBakiyePanelIbanNo
            // 
            this.LblBakiyePanelIbanNo.AutoSize = true;
            this.LblBakiyePanelIbanNo.Location = new System.Drawing.Point(476, 180);
            this.LblBakiyePanelIbanNo.Name = "LblBakiyePanelIbanNo";
            this.LblBakiyePanelIbanNo.Size = new System.Drawing.Size(12, 17);
            this.LblBakiyePanelIbanNo.TabIndex = 20;
            this.LblBakiyePanelIbanNo.Text = ".";
            // 
            // BakiyeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.LblBakiyePanelBakiye);
            this.Controls.Add(this.LblBakiyePanelIbanNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbHesapNoSec);
            this.Controls.Add(this.CmbHesapTur);
            this.Controls.Add(this.BtnBakiyeCikar);
            this.Controls.Add(this.TxbTutar);
            this.Controls.Add(this.BtnBakiyeEkle);
            this.Controls.Add(this.label7);
            this.Name = "BakiyeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bakiye Islemleri";
            this.Load += new System.EventHandler(this.BakiyeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbHesapNoSec;
        private System.Windows.Forms.ComboBox CmbHesapTur;
        private System.Windows.Forms.Button BtnBakiyeCikar;
        private System.Windows.Forms.TextBox TxbTutar;
        private System.Windows.Forms.Button BtnBakiyeEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblBakiyePanelBakiye;
        private System.Windows.Forms.Label LblBakiyePanelIbanNo;
    }
}