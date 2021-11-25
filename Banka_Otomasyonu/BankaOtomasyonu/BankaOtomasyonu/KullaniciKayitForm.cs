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
    public partial class KullaniciKayitForm : Form
    {
        public KullaniciKayitForm()
        {
            InitializeComponent();
        }
        DataClass dc = new DataClass();
        private void KullaniciKayitForm_Load(object sender, EventArgs e)
        {
            CmBoxDoldur();
            List<string> StatuList = dc.TumRolleriGetir();
            foreach (var Statu in StatuList)
            {
                CmbStatu.Items.Add(Statu);
            }

        }

        private void CmBoxDoldur()
        {
            for (int i = DateTime.Now.Year -18; i > 1900; i--)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (TxbTcNo.Text.Length != 11 || TxbIsım.Text.Length < 3 || TxtbSoyisim.Text.Length < 3 || comboBox1.SelectedItem ==null)
            {
                MessageBox.Show("Kişisel Bilgilerinizde Eksiklik veya Yanlışlık Mevcut Lütfen Bilgilerinizi Kontrol Ediniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    bool TcSnc = dc.TcKontrol(TxbTcNo.Text, TxbIsım.Text, TxtbSoyisim.Text, int.Parse(comboBox1.SelectedItem.ToString()));
                    if (TcSnc == true)
                    {
                        if (TbKullaniciAdi.Text.Length < 6 || TbSifre.Text.Length < 6 || CmbStatu.SelectedItem == null)
                        {
                            MessageBox.Show("Sistem Bilgileri Bölümünde  Kullanıcı Adı Veya Şifre 6 Karakterden Kısa Olamaz Veya Statu Bölümü Boş Geçilemez !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            //Bütün Şartlar Karşılandıgında Buradaki Blok Çalışacak ve Bilgileri Veritabanına Kaydedeceğiz.
                            if (dc.TcNoKayitKontrol(TxbTcNo.Text) == true)
                            {
                                dc.KullaniciKayit(TbKullaniciAdi.Text, TbSifre.Text, CmbStatu.SelectedItem.ToString(), TxbTcNo.Text, TxbIsım.Text, TxtbSoyisim.Text, comboBox1.SelectedItem.ToString());
                                Temizle();
                                MessageBox.Show("Kullanıcı Kaydı Başarıyla Oluşturuldu.", "Başarılı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                                MessageBox.Show("Veritabanında Zaten Aynı Tc Kimlik Numarasına Sahip Kayıt Mevcut. \nLütfen Tc Kimlik Bilgilerinizi Kontrol Ediniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Kişisel Bilgiler Bölümündeki Bilgiler Yanlış Türkiye Cumhuriyetinde Böyle Bir Kişi Yok !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorgulama Esnasında Hata İle Karşılaşıldı Hata Kodu => " + ex, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


           
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizle();
        }


        // Formda Bulunan Textboxları Temizler ve Comboboxları İlk Elemana Döndürür.
        private void Temizle()
        {
            TxbTcNo.Text = "";
            TxbIsım.Text = "";
            TxtbSoyisim.Text = "";
            comboBox1.SelectedIndex = 0;

            TbKullaniciAdi.Text = "";
            TbSifre.Text = "";
            CmbStatu.SelectedIndex = 0;

        }
    }
}
