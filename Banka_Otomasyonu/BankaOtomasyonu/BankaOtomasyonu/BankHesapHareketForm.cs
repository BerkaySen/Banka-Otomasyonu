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
    public partial class BankHesapHareketForm : Form
    {
        public BankHesapHareketForm()
        {
            InitializeComponent();
        }
        public string KullaniciAd { get; set; }
        public string TcNo { get; set; }

        BankaOtomasyonEModel db = new BankaOtomasyonEModel();
        private void BankHesapHareketForm_Load(object sender, EventArgs e)
        {
            try
            {
                var products = from c in db.HesapIslemDetays select c;
                dataGridView1.DataSource = products.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu"+ex, "Hata");
                this.Close();
            }
        }
    }
}
