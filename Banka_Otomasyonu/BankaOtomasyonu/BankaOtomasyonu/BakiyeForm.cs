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
    public partial class BakiyeForm : Form
    {
        public BakiyeForm()
        {
            InitializeComponent();
        }
        public string GetSetTcNo { get; set; }

        DataClass dc = new DataClass();
        private void TxbTutar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void TutarTxtbTemizle()
        {
            TxbTutar.Text = "";
        }

        private void BtnBakiyeEkle_Click(object sender, EventArgs e)
        {
            if (CmbHesapTur.SelectedIndex == 0)
            {
                try
                {
                    bool KayitDgr = dc.HesapTutarEkle(CmbHesapNoSec.SelectedItem.ToString(), int.Parse(TxbTutar.Text));
                    if (!KayitDgr)
                    {
                        MessageBox.Show("Tutar Müşterinin Hesabına Eklenemedi Ekleme Esnasında Hata Oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TutarTxtbTemizle();
                    }
                    else
                    {
                        dc.HesapTutarDetayEkle(CmbHesapNoSec.SelectedItem.ToString(), int.Parse(TxbTutar.Text), "+");
                        DialogResult dialog = MessageBox.Show("Tutar Müşterinin Hesabına Başarıyla Eklendi Pencereyi Kapatmak İstermisiniz ?", "Onaylandı", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                        if (DialogResult.Yes == dialog)
                        {
                            this.Close();
                        }
                        else
                            HesapBakiyeGoster();


                    }
                    TutarTxtbTemizle();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Sadece Sayısal Değerler Girebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TutarTxtbTemizle();
                }
            }
            else if (CmbHesapTur.SelectedIndex == 1)
            {
                try
                {
                    bool KayitDgr = dc.KrediHesapTutarEkle(int.Parse( CmbHesapNoSec.SelectedItem.ToString()), int.Parse(TxbTutar.Text));
                    if (!KayitDgr)
                    {
                        MessageBox.Show("Tutar Müşterinin Kartına Eklenemedi Ekleme Esnasında Hata Oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TutarTxtbTemizle();
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Tutar Müşterinin Kartına Başarıyla Eklendi Pencereyi Kapatmak İstermisiniz ?", "Onaylandı", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                        if (DialogResult.Yes == dialog)
                        {
                            this.Close();
                        }
                        else
                            KrediKartiBakiyeGoster();


                    }
                    TutarTxtbTemizle();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Sadece Sayısal Değerler Girebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TutarTxtbTemizle();
                }
            }
        }

        private void BtnBakiyeCikar_Click(object sender, EventArgs e)
        {
            if (CmbHesapTur.SelectedIndex == 0)
            {
                try
                {
                    if (CmbHesapTur.SelectedIndex == 0)
                    {
                        bool KayitDgr = dc.HesapTutarTahsil(CmbHesapNoSec.SelectedItem.ToString(), int.Parse(TxbTutar.Text));
                        if (!KayitDgr)
                        {
                            MessageBox.Show("Tutar Müşterinin Hesabından Tahsil Edilemedi Hata Oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TutarTxtbTemizle();
                        }
                        else
                        {
                            dc.HesapTutarDetayEkle(CmbHesapNoSec.SelectedItem.ToString(), int.Parse(TxbTutar.Text), "-");
                            DialogResult dialog = MessageBox.Show("Tutar Müşterinin Hesabından Başarıyla Tahsil Edildi Pencereyi Kapatmak İstermisiniz ?", "Onaylandı", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                            if (DialogResult.Yes == dialog)
                            {
                                this.Close();
                            }
                            else
                                HesapBakiyeGoster();

                            TutarTxtbTemizle();
                        }
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Sadece Sayısal Değerler Girebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TutarTxtbTemizle();
                }
            }
            else if (CmbHesapTur.SelectedIndex == 1)
            {
                try
                {
                    bool KayitDgr = dc.KrediHesapTutarTahsil(int.Parse(CmbHesapNoSec.SelectedItem.ToString()), int.Parse(TxbTutar.Text));
                    if (!KayitDgr)
                    {
                        MessageBox.Show("Tutar Müşterinin Kartından Tahsil Edilemedi Hata Oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TutarTxtbTemizle();
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Tutar Müşterinin Kartından Başarıyla Tahsil Edildi Pencereyi Kapatmak İstermisiniz ?", "Onaylandı", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                        if (DialogResult.Yes == dialog)
                        {
                            this.Close();
                        }
                        else
                            KrediKartiBakiyeGoster();

                        TutarTxtbTemizle();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Sadece Sayısal Değerler Girebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TutarTxtbTemizle();
                }
            }
        }

        private void CmbHesapTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbHesapTur.SelectedIndex == 0)
            {//Banka Hesabı İçin Çalışacak Kod Blogu
                CmbHesapSecTemizle();
                List<string> Hesaplar = dc.MusteriTumHesaplariGetir(GetSetTcNo);
                foreach (var item in Hesaplar)
                {
                    CmbHesapNoSec.Items.Add(item);
                }
                CmbHesapNoSec.SelectedIndex = 0;
            }
            else if (CmbHesapTur.SelectedIndex == 1)
            {//Kredi Kartı Hesabı Seçilirse çalışacak kod blogu
                CmbHesapSecTemizle();
                
                List<string> DonenList = dc.MusteriKartlariTumu(GetSetTcNo);
                foreach (var KartNo in DonenList)
                {
                    CmbHesapNoSec.Items.Add(KartNo);
                }
                CmbHesapNoSec.SelectedIndex = 0;
                //KrediKartiBakiyeGoster();
            }
            else//herhangibibir sebeple bir sorun olursa çalışacak kod blogu aslında bunu yazmasakda olurdu.
                CmbHesapSecTemizle();
        }
        private void CmbHesapSecTemizle()
        {
            CmbHesapNoSec.Items.Clear();
        }

        private void BakiyeForm_Load(object sender, EventArgs e)
        {
            CmbHesapTur.Items.Add("Banka Hesabı");
            CmbHesapTur.Items.Add("Kredi Kartı Hesabı");
            CmbHesapTur.SelectedIndex = 0;
        }

        private void CmbHesapNoSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbHesapNoSec.SelectedItem != null && CmbHesapTur.SelectedIndex == 0)
            {
                HesapBakiyeGoster();
            }
            else if (CmbHesapNoSec.SelectedItem != null && CmbHesapTur.SelectedIndex == 1)
            {
                // Kullanıcının kredi kartı hesaplarını aşşağıdaki comboboxa ekle
                KrediKartiBakiyeGoster();
            }
        }
        private void HesapBakiyeGoster()
        {
            string[] HesapDetay = null;
            string SecilenHesapNo = CmbHesapNoSec.SelectedItem.ToString();
            HesapDetay = dc.SecilenHesapNoDetay(SecilenHesapNo);
            LblBakiyePanelBakiye.Text = String.Format("Hesap Bakiyesi : {0}.00 TL", HesapDetay[0]);
            LblBakiyePanelIbanNo.Text = String.Format("Hesap Iban : {0}", HesapDetay[1]);
        }
        private void KrediKartiBakiyeGoster()
        {
            string[] KrediHesapDetay = null;
            string SecilenKartNo = CmbHesapNoSec.SelectedItem.ToString();
            KrediHesapDetay = dc.SecilenKartDetay(int.Parse(SecilenKartNo));
            LblBakiyePanelBakiye.Text = String.Format("Hesap Bakiyesi : {0}.00 TL", KrediHesapDetay[0]);
            LblBakiyePanelIbanNo.Text = String.Format("Kart Numarası : {0}", KrediHesapDetay[1]);
        }
    }
}
