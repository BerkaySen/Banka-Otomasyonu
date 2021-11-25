
namespace BankaOtomasyonu
{
    partial class Anasayfa
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
            this.CalisanMenu = new System.Windows.Forms.MenuStrip();
            this.calisanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankaHesabıOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krediKartıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusteriMenu = new System.Windows.Forms.MenuStrip();
            this.musteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krediKartıAlışverişYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kartEkstreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankaHesabıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapCüzdanıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalisanMenu.SuspendLayout();
            this.MusteriMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalisanMenu
            // 
            this.CalisanMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CalisanMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calisanToolStripMenuItem,
            this.hesapİşlemleriToolStripMenuItem});
            this.CalisanMenu.Location = new System.Drawing.Point(0, 28);
            this.CalisanMenu.Name = "CalisanMenu";
            this.CalisanMenu.Size = new System.Drawing.Size(1463, 28);
            this.CalisanMenu.TabIndex = 3;
            this.CalisanMenu.Text = "menuStrip1";
            // 
            // calisanToolStripMenuItem
            // 
            this.calisanToolStripMenuItem.Name = "calisanToolStripMenuItem";
            this.calisanToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.calisanToolStripMenuItem.Text = "Müsteri Kayıt";
            this.calisanToolStripMenuItem.Click += new System.EventHandler(this.calisanToolStripMenuItem_Click);
            // 
            // hesapİşlemleriToolStripMenuItem
            // 
            this.hesapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankaHesabıOluşturToolStripMenuItem,
            this.krediKartıİşlemleriToolStripMenuItem});
            this.hesapİşlemleriToolStripMenuItem.Name = "hesapİşlemleriToolStripMenuItem";
            this.hesapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.hesapİşlemleriToolStripMenuItem.Text = "Hesap İşlemleri";
            // 
            // bankaHesabıOluşturToolStripMenuItem
            // 
            this.bankaHesabıOluşturToolStripMenuItem.Name = "bankaHesabıOluşturToolStripMenuItem";
            this.bankaHesabıOluşturToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.bankaHesabıOluşturToolStripMenuItem.Text = "Banka Hesabı İşlemleri";
            this.bankaHesabıOluşturToolStripMenuItem.Click += new System.EventHandler(this.bankaHesabıOluşturToolStripMenuItem_Click);
            // 
            // krediKartıİşlemleriToolStripMenuItem
            // 
            this.krediKartıİşlemleriToolStripMenuItem.Name = "krediKartıİşlemleriToolStripMenuItem";
            this.krediKartıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.krediKartıİşlemleriToolStripMenuItem.Text = "Kredi Kartı İşlemleri";
            this.krediKartıİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.krediKartıİşlemleriToolStripMenuItem_Click);
            // 
            // MusteriMenu
            // 
            this.MusteriMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MusteriMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriToolStripMenuItem,
            this.krediKartıAlışverişYapToolStripMenuItem,
            this.kartEkstreToolStripMenuItem,
            this.bankaHesabıToolStripMenuItem,
            this.hesapCüzdanıToolStripMenuItem});
            this.MusteriMenu.Location = new System.Drawing.Point(0, 0);
            this.MusteriMenu.Name = "MusteriMenu";
            this.MusteriMenu.Size = new System.Drawing.Size(1463, 28);
            this.MusteriMenu.TabIndex = 4;
            this.MusteriMenu.Text = "menuStrip1";
            // 
            // musteriToolStripMenuItem
            // 
            this.musteriToolStripMenuItem.Name = "musteriToolStripMenuItem";
            this.musteriToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.musteriToolStripMenuItem.Text = "Profil Bilgilerim";
            this.musteriToolStripMenuItem.Click += new System.EventHandler(this.musteriToolStripMenuItem_Click);
            // 
            // krediKartıAlışverişYapToolStripMenuItem
            // 
            this.krediKartıAlışverişYapToolStripMenuItem.Name = "krediKartıAlışverişYapToolStripMenuItem";
            this.krediKartıAlışverişYapToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.krediKartıAlışverişYapToolStripMenuItem.Text = "Kredi Kartı Alışveriş Yap";
            this.krediKartıAlışverişYapToolStripMenuItem.Click += new System.EventHandler(this.krediKartıAlışverişYapToolStripMenuItem_Click);
            // 
            // kartEkstreToolStripMenuItem
            // 
            this.kartEkstreToolStripMenuItem.Name = "kartEkstreToolStripMenuItem";
            this.kartEkstreToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.kartEkstreToolStripMenuItem.Text = "Kart Ekstre";
            this.kartEkstreToolStripMenuItem.Click += new System.EventHandler(this.kartEkstreToolStripMenuItem_Click);
            // 
            // bankaHesabıToolStripMenuItem
            // 
            this.bankaHesabıToolStripMenuItem.Name = "bankaHesabıToolStripMenuItem";
            this.bankaHesabıToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.bankaHesabıToolStripMenuItem.Text = "Banka Hesap Hareketleri";
            this.bankaHesabıToolStripMenuItem.Click += new System.EventHandler(this.bankaHesabıToolStripMenuItem_Click);
            // 
            // hesapCüzdanıToolStripMenuItem
            // 
            this.hesapCüzdanıToolStripMenuItem.Name = "hesapCüzdanıToolStripMenuItem";
            this.hesapCüzdanıToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.hesapCüzdanıToolStripMenuItem.Text = "Hesap Cüzdanı";
            this.hesapCüzdanıToolStripMenuItem.Click += new System.EventHandler(this.hesapCüzdanıToolStripMenuItem_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 694);
            this.Controls.Add(this.CalisanMenu);
            this.Controls.Add(this.MusteriMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.CalisanMenu;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Anasayfa_FormClosing);
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.CalisanMenu.ResumeLayout(false);
            this.CalisanMenu.PerformLayout();
            this.MusteriMenu.ResumeLayout(false);
            this.MusteriMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip CalisanMenu;
        private System.Windows.Forms.MenuStrip MusteriMenu;
        private System.Windows.Forms.ToolStripMenuItem calisanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankaHesabıOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krediKartıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krediKartıAlışverişYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kartEkstreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankaHesabıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapCüzdanıToolStripMenuItem;
    }
}