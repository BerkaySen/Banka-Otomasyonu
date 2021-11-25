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
    public partial class KrediKartAlisverisForm : Form
    {
        public KrediKartAlisverisForm()
        {
            InitializeComponent();
        }
        public string KullaniciAd { get; set; }
        public string MusteriTcNo { get; set; }
        DataClass dc = new DataClass();
        private void KrediKartAlisverisForm_Load(object sender, EventArgs e)
        {
            //combobox içerisine kategorileri dolduruyoruz
            List<string> Kategoriler = dc.TumKategorileriGetir();


            List<string> DonenList = dc.MusteriKartlariTumu(MusteriTcNo);
            foreach (var KartNo in DonenList)
            {
                CmbKartSec.Items.Add(KartNo);
            }
            CmbKartSec.SelectedIndex = 0;


            foreach (var Kategori in Kategoriler)
            {
                comboBox1.Items.Add(Kategori);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >=1 && comboBox1.SelectedItem != null && textBox1.Text != "0")
            {
                //MessageBox.Show("helal len");
                int HesapBakiye = dc.KrediKartBakiye(int.Parse(CmbKartSec.SelectedItem.ToString()));
                int TutarDusur = HesapBakiye - int.Parse(textBox1.Text);
                //eğer bakiye girilen tutardan büyükse if blogu çalışır
                if (TutarDusur >= 0)
                {
                    int SecilenKart = int.Parse(CmbKartSec.SelectedItem.ToString());
                    bool dgr = dc.KrediHesapTutarTahsil(SecilenKart,int.Parse(textBox1.Text));
                    //hesapdan girilen tutarı düşürdük şimdi alışveriş detaylarını gerekli tabloya giriyoruz.
                    
                    bool HarcamaDetayDurum=dc.AlisverisDetayOlustur(SecilenKart,comboBox1.SelectedItem.ToString(),int.Parse(textBox1.Text));
                    if (!HarcamaDetayDurum)
                    {
                        MessageBox.Show("sıkıntı oldu");
                    }
                    textBox1.Text = "";
                    MessageBox.Show("Ödeme İşlemi Başarılı \nBankamızı Tercih Ettiğiniz İçin Teşekkürler", "Ödeme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show("Bakiye Yetersiz.\nKartınıza Para Yüklemeniz Gereklidir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Tutar Alanı veya Kategori Kısımları Boş Geçilemez !!\nVeya Tutar 0 Tl Olamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
