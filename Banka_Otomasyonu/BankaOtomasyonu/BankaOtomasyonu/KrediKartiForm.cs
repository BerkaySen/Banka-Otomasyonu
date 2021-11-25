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
    public partial class KrediKartiForm : Form
    {
        public KrediKartiForm()
        {
            InitializeComponent();
        }
        public string KullaniciAd { get; set; }
        public int RolId { get; set; }


        public string GetSetTcNo { get; set; }
        public string GetSetMusteriAd { get; set; }
        public string GetSetMusteriSoyad { get; set; }
        public string GetSetDogumYili { get; set; }
        DataClass dc = new DataClass();
        private void KrediKartiForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 30; i++)
            {
                CmbEkstreGun.Items.Add(i);
                CmbHesapKesim.Items.Add(i);
                CmbSonOdeme.Items.Add(i);
            }
            ButtonlarEnabled(false);
            KrediKartOlusturGorunum(false);

        }

        private void BtnMusteriSec_Click(object sender, EventArgs e)
        {
            GroupBoxMusteriSecimGorunurluk(true);
        }
        private void GroupBoxMusteriSecimGorunurluk(bool Deger)
        {
            textBox1.Text = "";
            GroupBoxMusteriSecim.Visible = Deger;
        }

        private void BtnMusteriSecimIptal_Click(object sender, EventArgs e)
        {
            GroupBoxMusteriSecimGorunurluk(false);
        }

        private void BtnMusteriAra_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 11)
            {
                

                try
                {
                    string[] ProfilData = null;
                    ProfilData = dc.KullaniciProfilDondur(textBox1.Text);// tc ad soyad dogum yılı döndürür
                    
                    if (ProfilData != null)
                    {
                        GetSetTcNo = ProfilData[0];
                        GetSetMusteriAd = ProfilData[1];
                        GetSetMusteriSoyad = ProfilData[2];
                        GetSetDogumYili = ProfilData[3];

                        LblMusteriBilgi.ForeColor = Color.Green;
                        LblMusteriBilgi.Text = String.Format("MÜŞTERİ BİLGİLERİ\n\nTc Kimlik No : {0}\nİsim : {1}\nSoyisim : {2}\nDoğum Yılı : {3}", GetSetTcNo, GetSetMusteriAd, GetSetMusteriSoyad, GetSetDogumYili);
                        GroupBoxMusteriSecimGorunurluk(false);
                        ButtonlarEnabled(true);
                    }
                    else
                    {
                        MessageBox.Show("Böyle Bir Müşteri Yoktur", "Müşteri Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Müşteri Bilgileri Alınamadı Bir Hata Oluştu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Tc Kimlik Numarası 11 Haneden Fazla veya Az Olamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnKartOlustur_Click(object sender, EventArgs e)
        {
            LblKartOlusturMusteriNo.Text = "Müşteri No : " + dc.MusteriNoGetir(GetSetTcNo);

            KrediKartOlusturGorunum(true);
        }
        private void KrediKartOlusturGorunum(bool Deger)
        {
            GroupBoxKartOlustur.Visible = Deger;
            CmbEkstreGun.SelectedIndex = 0;
            CmbHesapKesim.SelectedIndex = 0;
            CmbSonOdeme.SelectedIndex = 0;
        }

        private void BtnKartOlusturIptal_Click(object sender, EventArgs e)
        {
            KrediKartOlusturGorunum(false);
        }
        private void ButtonlarEnabled(bool EnableDeger)
        {
            BtnKartOlustur.Enabled = EnableDeger;
            button1.Enabled = EnableDeger;
        }

        private void BtnKrediKartOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbEkstreGun.SelectedIndex != CmbHesapKesim.SelectedIndex && CmbSonOdeme.SelectedIndex != CmbHesapKesim.SelectedIndex)
                {
                    bool KartOlusturDgr = dc.KrediKartOlustur(GetSetTcNo, CmbHesapKesim.SelectedItem.ToString(), CmbSonOdeme.SelectedItem.ToString(), CmbEkstreGun.SelectedItem.ToString());
                    if (KartOlusturDgr)
                    {
                        MessageBox.Show("Kredi Kartı Başarıyla Oluşturuldu", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        KrediKartOlusturGorunum(false);
                    }
                    else
                        MessageBox.Show("Kredi Kartı Oluşturulamadı Oluşturma Esnasında Hata İle Karşılaşıldı.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Tüm İşlemler Aynı Gün İçerisinde Olamaz Lütfen Farklı Günler Seçiniz", "Seçim Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kredi Kartı Oluşturulamadı Oluşturma Esnasında Hata İle Karşılaşıldı.", "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BakiyeForm bf = new BakiyeForm();
            bf.GetSetTcNo = GetSetTcNo;
            bf.ShowDialog();
        }
    }
}
