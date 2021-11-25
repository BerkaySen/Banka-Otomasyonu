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
    public partial class HesapCuzdan : Form
    {
        public HesapCuzdan()
        {
            InitializeComponent();
        }
        public string KullaniciAd { get; set; }
        public string TcNo { get; set; }
        private string GetSetHesapNo { get; set; }
        DataClass dc = new DataClass();
        private void HesapCuzdan_Load(object sender, EventArgs e)
        {
            List<string> Hesaplar = dc.MusteriTumHesaplariGetir(TcNo);
            foreach (var HesapNo in Hesaplar)
            {
                CmbHesapSec.Items.Add(HesapNo);
            }
        }
        private void ButtonlarGorunurluk(bool dgr)
        {
            BtnAyarlar.Enabled = dgr;
            BtnOnizleme.Enabled = dgr;
            BtnYazdir.Enabled = dgr;
        }
        private void BtnAyarlar_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void BtnOnizleme_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            DialogResult pdr = printDialog1.ShowDialog();
            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string MusteriNo = dc.MusteriNoGetir(TcNo);
            string[] MusteriProfDetay = dc.MusteriNoDetay(int.Parse(MusteriNo));
            //Yazı fontumu ve çizgi çizmek için fırçamı ve kalem nesnemi oluşturdum
            Font myFont = new Font("Calibri", 28);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);
            List<HesapTbl> HesapData = dc.HesapNoDetayTumu(GetSetHesapNo);
            //Bu kısımda Dunya Bankası yazısını ve çizgileri yazdırıyorum
            e.Graphics.DrawLine(myPen, 120, 120, 750, 120);
            e.Graphics.DrawLine(myPen, 120, 180, 750, 180);
            e.Graphics.DrawString("Dünya Bankası", myFont, sbrush, 200, 120);
            myFont = new Font("Calibri", 12, FontStyle.Bold);
            e.Graphics.DrawString("Hesap No : "+HesapData[0].HesapNo, myFont, sbrush, 130, 190);
            e.Graphics.DrawString("Iban : "+HesapData[0].IbanNo, myFont, sbrush, 130, 220);
            e.Graphics.DrawString("Hesap Sahibi : "+MusteriProfDetay[0]+" "+MusteriProfDetay[1], myFont, sbrush, 130, 250);
            e.Graphics.DrawString("Dogum Tarihi : "+MusteriProfDetay[2], myFont, sbrush, 130, 280);
            e.Graphics.DrawLine(myPen, 120, 320, 750, 320);

            
            e.Graphics.DrawString("Islem No", myFont, sbrush, 150, 328);
            e.Graphics.DrawString("Tutar", myFont, sbrush, 270, 328);
            e.Graphics.DrawString("Islem", myFont, sbrush, 450, 328);
            e.Graphics.DrawString("Tarih", myFont, sbrush, 640, 328);

            e.Graphics.DrawLine(myPen, 120, 348, 750, 348);

            int y = 360;

            StringFormat myStringFormat = new StringFormat();
            myStringFormat.Alignment = StringAlignment.Far;

            decimal gTotal = 0;

            List<HesapIslemDetay> HDetayList = dc.HesapIslemDondur(GetSetHesapNo);
            foreach (var Detay in HDetayList)
            {//Detay.Tutar
                e.Graphics.DrawString(Detay.IslemId.ToString(), myFont, sbrush, 150, y, myStringFormat);
                e.Graphics.DrawString(Detay.Tutar.ToString(), myFont, sbrush, 270, y);
               // decimal bFiyat = Convert.ToDecimal(lvi.SubItems[2].Text);
               // decimal fiyat = Convert.ToDecimal(lvi.SubItems[1].Text) * Convert.ToDecimal(lvi.SubItems[2].Text);
                gTotal +=int.Parse(Detay.Tutar);
                e.Graphics.DrawString(Detay.IslemTur, myFont, sbrush, 470, y, myStringFormat);
                e.Graphics.DrawString(Detay.IslemTarih.ToString(), myFont, sbrush, 700, y, myStringFormat);

                y += 20;
            }


           /* foreach (ListViewItem lvi in listView1.Items)
            {
                e.Graphics.DrawString(lvi.SubItems[1].Text, myFont, sbrush, 160, y, myStringFormat);
                e.Graphics.DrawString(lvi.Text, myFont, sbrush, 220, y);
                decimal bFiyat = Convert.ToDecimal(lvi.SubItems[2].Text);
                decimal fiyat = Convert.ToDecimal(lvi.SubItems[1].Text) * Convert.ToDecimal(lvi.SubItems[2].Text);
                gTotal += fiyat;
                e.Graphics.DrawString(bFiyat.ToString("c"), myFont, sbrush, 530, y, myStringFormat);
                e.Graphics.DrawString(fiyat.ToString("c"), myFont, sbrush, 700, y, myStringFormat);

                y += 20;

            }*/

           // e.Graphics.DrawLine(myPen, 120, y, 750, y);
           // e.Graphics.DrawString(gTotal.ToString("c"), myFont, sbrush, 700, y + 10, myStringFormat);

        }

        private void CmbHesapSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSetHesapNo = CmbHesapSec.SelectedItem.ToString();
        }
    }
}
