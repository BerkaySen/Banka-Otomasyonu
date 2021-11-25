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
    public partial class KartEkstreForm : Form
    {
        public KartEkstreForm()
        {
            InitializeComponent();
        }
        public string kullaniciAdi { get; set; }
        public string TcNo { get; set; }
        private int MusteriNo { get; set; }

        DataClass dc = new DataClass();
        private void KartEkstreForm_Load(object sender, EventArgs e)
        {
            GroupBoxEkstreDetay.Visible = false;
            #region
            try
            {
                string GlnMusteriNo = dc.MusteriNoGetir(TcNo);
                if (GlnMusteriNo != "" && GlnMusteriNo != null)
                {
                    MusteriNo = int.Parse(GlnMusteriNo);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Müşteri Numaranız Bulunamadı Bir Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
            
            try
            {
                List<string> KartlarListe = dc.MusteriKartlariTumu(TcNo);
                foreach (var KartNo in KartlarListe)
                {
                    CmbKrediKartlar.Items.Add(KartNo);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Geçmiş Ekstreleriniz Getirilemedi Bir Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CmbKrediKartlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int EkstreTarih = dc.KrediKartEkstreTarihGetir(int.Parse(CmbKrediKartlar.SelectedItem.ToString()));
            int Today = DateTime.Now.Day;
            if (EkstreTarih == Today)
            {
                List<KrediHarcamaDetayTbl>  EkstreDetayList = dc.KartEkstreDondur(int.Parse(CmbKrediKartlar.SelectedItem.ToString()));
                int GiyimHarcama = 0;
                int YiyecekHarcama = 0;
                int YakıtHarcama = 0;
                int EgitimHarcama = 0;
                int DigerHarcama = 0;
                for (int i = 0; i < EkstreDetayList.Count; i++)
                {
                    switch (EkstreDetayList[i].HarcamaKategoriId)
                    {
                        //giyim
                        case (1):
                            GiyimHarcama += EkstreDetayList[i].HarcamaTutar;
                            break;


                        //yiyecek
                        case (2):
                            YiyecekHarcama += EkstreDetayList[i].HarcamaTutar;
                            break;


                        //yakıt
                        case (3):
                            YakıtHarcama += EkstreDetayList[i].HarcamaTutar;
                            break;


                        //Eğitim
                        case (4):
                            EgitimHarcama += EkstreDetayList[i].HarcamaTutar;
                            break;


                        default:
                            DigerHarcama += EkstreDetayList[i].HarcamaTutar;
                            break;
                    }
                }

                LblGiyim.Text =String.Format("Giyim İçin Toplam {0}.00 TL",GiyimHarcama.ToString());
                LblYiyecek.Text = String.Format("Yiyecek İçin Toplam {0}.00 TL", YiyecekHarcama.ToString());
                LblYakit.Text = String.Format("Yakıt İçin Toplam {0}.00 TL", YakıtHarcama.ToString());
                LblEgitim.Text = String.Format("Eğitim İçin Toplam {0}.00 TL", EgitimHarcama.ToString());
                LblDiger.Text = String.Format("Diğer Harcamalar İçin Toplam {0}.00 TL", DigerHarcama.ToString());
                LblToplamHarcama.ForeColor = Color.Red;
                LblToplamHarcama.Text = String.Format("Harcamalarınız Toplamı >> {0}.00 TL", (GiyimHarcama+YiyecekHarcama+YakıtHarcama+EgitimHarcama+DigerHarcama).ToString());

                ChartDataYaz(GiyimHarcama, YiyecekHarcama, YakıtHarcama, EgitimHarcama, DigerHarcama);
                GroupBoxEkstreDetay.Visible = true;
            }
            else
                MessageBox.Show("Gösterilecek Ekstre Yok Ekstre Tarihinizi Bekleyiniz. \nBu Kart İçin Ekstre Tarihiniz Her Ayın " + EkstreTarih.ToString() + ". Gününde Kesilmektedir.");
        }
        private void ChartDataYaz(int Giyim,int Yiyecek,int Yakit,int Egitim,int Diger)
        {
            foreach (var series in chartHarcama.Series)
            {
                series.Points.Clear();
            }
            chartHarcama.Series["Harcamalar"].Points.AddXY("Giyim", Giyim);
            chartHarcama.Series["Harcamalar"].Points.AddXY("Yiyecek", Yiyecek);
            chartHarcama.Series["Harcamalar"].Points.AddXY("Yakit", Yakit);
            chartHarcama.Series["Harcamalar"].Points.AddXY("Egitim", Egitim);
            chartHarcama.Series["Harcamalar"].Points.AddXY("Diger", Diger);
        }

        private void BtnRapor_Click(object sender, EventArgs e)
        {
            KartEkstreRaporForm kerpf =new KartEkstreRaporForm();
            kerpf.ShowDialog();
        }
    }
}
