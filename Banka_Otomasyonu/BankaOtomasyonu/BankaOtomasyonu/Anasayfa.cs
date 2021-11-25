using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BankaOtomasyonu
{
    public partial class Anasayfa : Form
    {
        public string KullaniciAd { get; set; }
        public int RolId { get; set; }


        public string MusteriTcNo { get; set; }
        public string MusteriIsim { get; set; }
        public string MusteriSoyisim { get; set; }
        public string MusteriDTarih { get; set; }


        DataClass dc = new DataClass();
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            CalisanMenu.Visible = false;
            MusteriMenu.Visible = false;
            // Müşetiler için Yaratılmış Menustrip Göstermek için if blogu çalışacak eger kişinin rol idsi 2 eşitse yani çalışan ise 
            //çalışanlara özel yaratılan menustrip gözükmesi için else if bloguna girecektir
            //eger herhangibi bir şekilde rol id databaseden düzgün bir şekilde getirilemezse else Blogu çalışacak.

            if (RolId == 1)
            {
                MusteriMenu.Visible = true;
                // Müşterinin Profil Bilgilerini GetSet İçerisine Aktarıyoruz İleride Farklı Yerlerde Kullanmak İçin.
                string[] MusteriProfil = dc.MusteriProfilDondur(KullaniciAd);
                if (MusteriProfil != null)
                {
                    MusteriTcNo = MusteriProfil[0];
                    MusteriIsim = MusteriProfil[1];
                    MusteriSoyisim = MusteriProfil[2];
                    MusteriDTarih = MusteriProfil[3];
                }
            }
            else if (RolId == 2)
            {
                CalisanMenu.Visible = true;
            }
            else
            {
                MessageBox.Show("Rol Bilginiz Veritabanından Getirilemedi Bir Hata Oluştu ! \nTekrar Giriş Yapmayı Deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        private void calisanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciKayitForm cf = new KullaniciKayitForm();
                    cf.MdiParent = this;
                    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    cf.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    cf.Dock = DockStyle.Fill;
                    cf.Show();
        }

        private void bankaHesabıOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapIslemleriForm hif = new HesapIslemleriForm();
            hif.MdiParent = this;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            hif.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            hif.Dock = DockStyle.Fill;
            hif.Show();
        }

        private void krediKartıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KrediKartiForm kif = new KrediKartiForm();
            kif.MdiParent = this;
            kif.KullaniciAd = KullaniciAd;
            kif.RolId = RolId;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            kif.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            kif.Dock = DockStyle.Fill;
            kif.Show();
        }

        private void musteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MusteriProfilForm Mpf = new MusteriProfilForm();
                Mpf.MdiParent = this;
                Mpf.KullaniciAd = KullaniciAd;
                Mpf.MusteriTcNo = MusteriTcNo;
                Mpf.MusteriIsim = MusteriIsim;
                Mpf.MusteriSoyisim = MusteriSoyisim;
                Mpf.MusteriDTarih = MusteriDTarih;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                Mpf.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Mpf.Dock = DockStyle.Fill;
                Mpf.Show();
            }
            catch (Exception h)
            {
                MessageBox.Show("Profil Sayfanız Açılamadı Bir Hata Oluştu Hata Kodu => " + h, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void krediKartıAlışverişYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KrediKartAlisverisForm Mpf = new KrediKartAlisverisForm();
            Mpf.MdiParent = this;
            Mpf.KullaniciAd = KullaniciAd;
            Mpf.MusteriTcNo = MusteriTcNo;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Mpf.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Mpf.Dock = DockStyle.Fill;
            Mpf.Show();
        }

        private void kartEkstreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KartEkstreForm kef = new KartEkstreForm();
            kef.MdiParent = this;
            kef.kullaniciAdi = KullaniciAd;
            kef.TcNo = MusteriTcNo;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            kef.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            kef.Dock = DockStyle.Fill;
            kef.Show();
        }

        private void bankaHesabıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankHesapHareketForm bhf = new BankHesapHareketForm();
            bhf.MdiParent = this;
            bhf.KullaniciAd = KullaniciAd;
            bhf.TcNo = MusteriTcNo;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            bhf.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            bhf.Dock = DockStyle.Fill;
            bhf.Show();
        }

        private void hesapCüzdanıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapCuzdan hc = new HesapCuzdan();
            hc.MdiParent = this;
            hc.KullaniciAd = KullaniciAd;
            hc.TcNo = MusteriTcNo;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            hc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            hc.Dock = DockStyle.Fill;
            hc.Show();
        }
    }
}
