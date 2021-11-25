
namespace BankaOtomasyonu
{
    partial class KartEkstreRaporForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KrediHarcamaDetayTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BankaOtomasyonDbDataSet = new BankaOtomasyonu.BankaOtomasyonDbDataSet();
            this.KrediHarcamaDetayTblTableAdapter = new BankaOtomasyonu.BankaOtomasyonDbDataSetTableAdapters.KrediHarcamaDetayTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KrediHarcamaDetayTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankaOtomasyonDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.KrediHarcamaDetayTblBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BankaOtomasyonu.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1088, 537);
            this.reportViewer1.TabIndex = 0;
            // 
            // KrediHarcamaDetayTblBindingSource
            // 
            this.KrediHarcamaDetayTblBindingSource.DataMember = "KrediHarcamaDetayTbl";
            this.KrediHarcamaDetayTblBindingSource.DataSource = this.BankaOtomasyonDbDataSet;
            // 
            // BankaOtomasyonDbDataSet
            // 
            this.BankaOtomasyonDbDataSet.DataSetName = "BankaOtomasyonDbDataSet";
            this.BankaOtomasyonDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KrediHarcamaDetayTblTableAdapter
            // 
            this.KrediHarcamaDetayTblTableAdapter.ClearBeforeFill = true;
            // 
            // KartEkstreRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 537);
            this.Controls.Add(this.reportViewer1);
            this.Name = "KartEkstreRaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KartEkstreRaporForm";
            this.Load += new System.EventHandler(this.KartEkstreRaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KrediHarcamaDetayTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankaOtomasyonDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KrediHarcamaDetayTblBindingSource;
        private BankaOtomasyonDbDataSet BankaOtomasyonDbDataSet;
        private BankaOtomasyonDbDataSetTableAdapters.KrediHarcamaDetayTblTableAdapter KrediHarcamaDetayTblTableAdapter;
    }
}