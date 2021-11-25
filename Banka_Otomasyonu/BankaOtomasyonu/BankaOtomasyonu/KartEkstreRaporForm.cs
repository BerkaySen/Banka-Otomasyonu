using Microsoft.Reporting.WinForms;
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
    public partial class KartEkstreRaporForm : Form
    {
        public KartEkstreRaporForm()
        {
            InitializeComponent();
        }

        private void KartEkstreRaporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BankaOtomasyonDbDataSet.KrediHarcamaDetayTbl' table. You can move, or remove it, as needed.
            this.KrediHarcamaDetayTblTableAdapter.Fill(this.BankaOtomasyonDbDataSet.KrediHarcamaDetayTbl);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }


        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
