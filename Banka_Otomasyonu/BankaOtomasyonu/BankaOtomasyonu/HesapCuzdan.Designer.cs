
namespace BankaOtomasyonu
{
    partial class HesapCuzdan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HesapCuzdan));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.BtnOnizleme = new System.Windows.Forms.Button();
            this.BtnAyarlar = new System.Windows.Forms.Button();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.CmbHesapSec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // BtnOnizleme
            // 
            this.BtnOnizleme.Location = new System.Drawing.Point(468, 113);
            this.BtnOnizleme.Name = "BtnOnizleme";
            this.BtnOnizleme.Size = new System.Drawing.Size(186, 82);
            this.BtnOnizleme.TabIndex = 0;
            this.BtnOnizleme.Text = "Önizleme";
            this.BtnOnizleme.UseVisualStyleBackColor = true;
            this.BtnOnizleme.Click += new System.EventHandler(this.BtnOnizleme_Click);
            // 
            // BtnAyarlar
            // 
            this.BtnAyarlar.Location = new System.Drawing.Point(244, 113);
            this.BtnAyarlar.Name = "BtnAyarlar";
            this.BtnAyarlar.Size = new System.Drawing.Size(186, 82);
            this.BtnAyarlar.TabIndex = 1;
            this.BtnAyarlar.Text = "Ayarlar";
            this.BtnAyarlar.UseVisualStyleBackColor = true;
            this.BtnAyarlar.Click += new System.EventHandler(this.BtnAyarlar_Click);
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Location = new System.Drawing.Point(35, 113);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(186, 82);
            this.BtnYazdir.TabIndex = 2;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // CmbHesapSec
            // 
            this.CmbHesapSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbHesapSec.FormattingEnabled = true;
            this.CmbHesapSec.Location = new System.Drawing.Point(166, 35);
            this.CmbHesapSec.Name = "CmbHesapSec";
            this.CmbHesapSec.Size = new System.Drawing.Size(157, 24);
            this.CmbHesapSec.TabIndex = 3;
            this.CmbHesapSec.SelectedIndexChanged += new System.EventHandler(this.CmbHesapSec_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hesap No Seçiniz :";
            // 
            // HesapCuzdan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbHesapSec);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.BtnAyarlar);
            this.Controls.Add(this.BtnOnizleme);
            this.Name = "HesapCuzdan";
            this.Text = "HesapCuzdan";
            this.Load += new System.EventHandler(this.HesapCuzdan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button BtnOnizleme;
        private System.Windows.Forms.Button BtnAyarlar;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.ComboBox CmbHesapSec;
        private System.Windows.Forms.Label label1;
    }
}