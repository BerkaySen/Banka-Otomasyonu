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
    public partial class HesapIslemleriForm : Form
    {
        public HesapIslemleriForm()
        {
            InitializeComponent();
        }
        DataClass dc = new DataClass();
        HesapOlusturClass Ho = new HesapOlusturClass();

        private void HesapIslemleriForm_Load(object sender, EventArgs e)
        {
            MusteriProfLabelVisible(false);

            HesapOlusturPanelGorunurluk(false);
            ButtonlarEnabled(false);
        }
        string GetSetTcNo { get; set; }
        string GetSetIsim { get; set; }
        string GetSetSoyisim { get; set; }
        string GetSetDTarih { get; set; }



        #region
        /// <summary>
        /// Verilen Degere Göre Müşteri Bilgilerini Gösteren Labelları gösterip Gizlemeye ayrayan metoddur.
        /// </summary>
        /// <param name="Dgr"></param>
        private void MusteriProfLabelVisible(bool Dgr)
        {
            LblTc.Visible = Dgr;
            LblIsım.Visible = Dgr;
            LblSoyisim.Visible = Dgr;
            LblDogumTarih.Visible = Dgr;

        }
        #endregion

        private void BtnAra_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbTcNoSearch.Text.Length == 11)
                {
                    string[] Gelendata = new string[4];
                    Gelendata = dc.KullaniciProfilDondur(TbTcNoSearch.Text);
                    if (Gelendata != null)
                    {
                        GetSetTcNo = Gelendata[0];
                        GetSetIsim = Gelendata[1];
                        GetSetSoyisim = Gelendata[2];
                        GetSetDTarih = Gelendata[3];


                        DialogResult ResultData = MessageBox.Show(String.Format("Kullanıcı Bulundu Detaylar Aşşağıdadır Onaylıyormusunuz ?\n\nTc Kimlik Numarası : {0}\nAdı : {1}\nSoyadı : {2}\nDogum Yılı : {3}", GetSetTcNo, GetSetIsim, GetSetSoyisim, GetSetDTarih), "Müşetri Bilgi Onay Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (DialogResult.Yes == ResultData)
                        {
                            MusteriProfLabelVisible(true);
                            LblTc.Text = String.Format("Tc Kimlik Numarası : {0}", GetSetTcNo);
                            LblIsım.Text = String.Format("Adı : {0}", GetSetIsim);
                            LblSoyisim.Text = String.Format("Soyadı : {0}", GetSetSoyisim);
                            LblDogumTarih.Text = String.Format("Dogum Yılı : {0}", GetSetDTarih);

                            LblMusteriDetay.ForeColor = Color.Green;
                            LblMusteriDetay.Text = String.Format("SEÇİLİ MÜŞTERİ BİLGİLERİ\n\nTc Kimlik Numarası : {0}\nAdı : {1}\nSoyadı : {2}\nDogum Yılı : {3}", GetSetTcNo, GetSetIsim, GetSetSoyisim, GetSetDTarih);
                            MusteriSecimPanelGorunurluk(false);
                            ButtonlarEnabled(true);
                        }
                        else
                        {
                            MusteriProfLabelVisible(false);
                        }
                    }
                    else
                    {
                        MusteriProfLabelVisible(false);
                        MessageBox.Show("Böyle Birisi Kayıtlı Değil", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tc Kimlik Numarası 11 Haneden Oluşmalıdır.");
                }
            }
            catch (Exception)
            {
                MusteriProfLabelVisible(false);
                MessageBox.Show("Böyle Birisi Kayıtlı Değil", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void MusteriSecimPanelGorunurluk(bool GorunurlukDurum)
        {
            MusteriProfLabelVisible(GorunurlukDurum);
            GroupBoxMusteriSecimPanel.Visible = GorunurlukDurum;
            LblTc.Text = "";
            LblIsım.Text = "";
            LblSoyisim.Text = "";
            LblDogumTarih.Text = "";

        }
        private void HesapOlusturPanelGorunurluk(bool GorunurlukDurum)
        {
            LblMusteriNo.Text = "";
            LblHesapNo.Text = "";
            LblIbanNo.Text = "";

            GroupBoxHesapOlustur.Visible = GorunurlukDurum;
        }

        private void BtnSec_Click(object sender, EventArgs e)
        {
            if (GetSetTcNo != null || GetSetIsim != null || GetSetSoyisim != null || GetSetDTarih != null)
            {
                MusteriSecimPanelGorunurluk(false);
            }
            else
            {
                MessageBox.Show("Önce Seçim Yapmalısınız İşlem Yapılacak Müşteriyi Seçmelisiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HesapOlusturPanelGorunurluk(true);
            HesapDataDoldur();
        }

        private void BtnMusteriSec_Click(object sender, EventArgs e)
        {
            MusteriSecimPanelGorunurluk(true);
        }
        private void ButtonlarEnabled(bool EnabledDurum)
        {
            BtnBakiye.Enabled = EnabledDurum;
            button2.Enabled = EnabledDurum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HesapDataDoldur();

        }

        private void HesapDataDoldur()
        {
            string MusteriNo = dc.MusteriNoGetir(GetSetTcNo);
            LblMusteriNo.Text = MusteriNo;
            LblHesapNo.Text = Ho.HesapNoUret();
            LblIbanNo.Text = Ho.IbanNoOlustur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dc.HesapNoKontrol(LblHesapNo.Text) && dc.IbanKontrol(LblIbanNo.Text))
            {

                bool KayitDgr = dc.HesapOlustur(int.Parse(LblMusteriNo.Text), LblHesapNo.Text, LblIbanNo.Text);
                if (KayitDgr)
                {
                    MessageBox.Show("Hesap Oluşturma İşlemi Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Hesap Oluşturma İşlemi BAŞARISIZ\nYeni Hesap Oluşturulamadı !!", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Malesef Veritabanında Aynı Numarada Iban No veya Hesap No Bulunan Kayıt Mevcuttur.\nVerileri Yenile Butonuna Basıp Tekrar Deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            HesapOlusturPanelGorunurluk(false);
        }

        private void BtnBakiye_Click(object sender, EventArgs e)
        {
            BakiyeForm bf = new BakiyeForm();
            bf.GetSetTcNo = GetSetTcNo;
            bf.ShowDialog();

        }
      
    }
}
