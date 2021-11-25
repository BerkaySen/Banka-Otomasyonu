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
    public partial class MusteriProfilForm : Form
    {
        public MusteriProfilForm()
        {
            InitializeComponent();
        }
        public string KullaniciAd { get; set; }
        public string MusteriTcNo { get; set; }
        public string MusteriIsim { get; set; }
        public string MusteriSoyisim { get; set; }
        public string MusteriDTarih { get; set; }


        private void MusteriProfilForm_Load(object sender, EventArgs e)
        {
            LblKullaniciAd.Text = KullaniciAd;
            LblTcNo.Text = MusteriTcNo;
            LblIsım.Text = MusteriIsim;
            LblSoyisim.Text = MusteriSoyisim;
            LblDTarih.Text = MusteriDTarih;
        }
    }
}
