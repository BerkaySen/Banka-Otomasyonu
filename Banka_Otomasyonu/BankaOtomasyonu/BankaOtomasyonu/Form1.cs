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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        DataClass dc = new DataClass();
        private void LoginPage_Load(object sender, EventArgs e)
        {
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAdi.Text.Length < 6 || TxtSifre.Text.Length < 6)
            {
                MessageBox.Show("Kullanıcı Adınız veya Şifreniz 6 Karakterden Az Olamaz !!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // giriş işlemleri yapılıyor
                // DataClass Classı içerisinde bulunan kullanici doğrula metodu çağırılıyor ve dönen deger true is if bloguna giriyor
                // eğer dönen deger true değilse else blogu çalışıyor.
                if (dc.kullanicidogrula(TxtKullaniciAdi.Text, TxtSifre.Text))
                {
                    //Giriş Sayfasını Gizleyip Anasayfayı Açıyoruz.
                    Anasayfa ASayfa = new Anasayfa();
                    this.Hide();
                    ASayfa.KullaniciAd = TxtKullaniciAdi.Text;
                    ASayfa.RolId = dc.RolKontrol(TxtKullaniciAdi.Text);
                    ASayfa.ShowDialog();
                }
                else
                    MessageBox.Show("Böyle Bir Kullanıcı Bulunamadı Kullanıcı Adınız veya Şifreniz Yanlış !", "Bilgileriniz Yanlış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void BtnKaydol_Click(object sender, EventArgs e)
        {
            KullaniciKayitForm KullKayit = new KullaniciKayitForm();
            KullKayit.ShowDialog();
        }
    }
}
