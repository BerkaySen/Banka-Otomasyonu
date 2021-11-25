
namespace BankaOtomasyonu
{
    partial class KartEkstreForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GroupBoxEkstreDetay = new System.Windows.Forms.GroupBox();
            this.CmbKrediKartlar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblGiyim = new System.Windows.Forms.Label();
            this.LblYiyecek = new System.Windows.Forms.Label();
            this.LblYakit = new System.Windows.Forms.Label();
            this.LblEgitim = new System.Windows.Forms.Label();
            this.LblDiger = new System.Windows.Forms.Label();
            this.LblToplamHarcama = new System.Windows.Forms.Label();
            this.chartHarcama = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnRapor = new System.Windows.Forms.Button();
            this.GroupBoxEkstreDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHarcama)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxEkstreDetay
            // 
            this.GroupBoxEkstreDetay.Controls.Add(this.BtnRapor);
            this.GroupBoxEkstreDetay.Controls.Add(this.chartHarcama);
            this.GroupBoxEkstreDetay.Controls.Add(this.LblToplamHarcama);
            this.GroupBoxEkstreDetay.Controls.Add(this.LblDiger);
            this.GroupBoxEkstreDetay.Controls.Add(this.LblEgitim);
            this.GroupBoxEkstreDetay.Controls.Add(this.LblYakit);
            this.GroupBoxEkstreDetay.Controls.Add(this.LblYiyecek);
            this.GroupBoxEkstreDetay.Controls.Add(this.LblGiyim);
            this.GroupBoxEkstreDetay.Location = new System.Drawing.Point(28, 85);
            this.GroupBoxEkstreDetay.Name = "GroupBoxEkstreDetay";
            this.GroupBoxEkstreDetay.Size = new System.Drawing.Size(1151, 477);
            this.GroupBoxEkstreDetay.TabIndex = 2;
            this.GroupBoxEkstreDetay.TabStop = false;
            this.GroupBoxEkstreDetay.Text = "Ekstre Detayı";
            // 
            // CmbKrediKartlar
            // 
            this.CmbKrediKartlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKrediKartlar.FormattingEnabled = true;
            this.CmbKrediKartlar.Location = new System.Drawing.Point(176, 21);
            this.CmbKrediKartlar.Name = "CmbKrediKartlar";
            this.CmbKrediKartlar.Size = new System.Drawing.Size(226, 24);
            this.CmbKrediKartlar.TabIndex = 4;
            this.CmbKrediKartlar.SelectedIndexChanged += new System.EventHandler(this.CmbKrediKartlar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kredi Kartı Seçiniz  :";
            // 
            // LblGiyim
            // 
            this.LblGiyim.AutoSize = true;
            this.LblGiyim.Location = new System.Drawing.Point(7, 41);
            this.LblGiyim.Name = "LblGiyim";
            this.LblGiyim.Size = new System.Drawing.Size(108, 17);
            this.LblGiyim.TabIndex = 0;
            this.LblGiyim.Text = "Giyim Harcama ";
            // 
            // LblYiyecek
            // 
            this.LblYiyecek.AutoSize = true;
            this.LblYiyecek.Location = new System.Drawing.Point(7, 68);
            this.LblYiyecek.Name = "LblYiyecek";
            this.LblYiyecek.Size = new System.Drawing.Size(118, 17);
            this.LblYiyecek.TabIndex = 1;
            this.LblYiyecek.Text = "Yiyecek Harcama";
            // 
            // LblYakit
            // 
            this.LblYakit.AutoSize = true;
            this.LblYakit.Location = new System.Drawing.Point(7, 96);
            this.LblYakit.Name = "LblYakit";
            this.LblYakit.Size = new System.Drawing.Size(100, 17);
            this.LblYakit.TabIndex = 2;
            this.LblYakit.Text = "Yakıt Harcama";
            // 
            // LblEgitim
            // 
            this.LblEgitim.AutoSize = true;
            this.LblEgitim.Location = new System.Drawing.Point(7, 126);
            this.LblEgitim.Name = "LblEgitim";
            this.LblEgitim.Size = new System.Drawing.Size(107, 17);
            this.LblEgitim.TabIndex = 3;
            this.LblEgitim.Text = "Egitim Harcama";
            // 
            // LblDiger
            // 
            this.LblDiger.AutoSize = true;
            this.LblDiger.Location = new System.Drawing.Point(7, 154);
            this.LblDiger.Name = "LblDiger";
            this.LblDiger.Size = new System.Drawing.Size(103, 17);
            this.LblDiger.TabIndex = 4;
            this.LblDiger.Text = "Diger Harcama";
            // 
            // LblToplamHarcama
            // 
            this.LblToplamHarcama.AutoSize = true;
            this.LblToplamHarcama.Location = new System.Drawing.Point(7, 186);
            this.LblToplamHarcama.Name = "LblToplamHarcama";
            this.LblToplamHarcama.Size = new System.Drawing.Size(116, 17);
            this.LblToplamHarcama.TabIndex = 5;
            this.LblToplamHarcama.Text = "Toplam Harcama";
            // 
            // chartHarcama
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHarcama.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHarcama.Legends.Add(legend1);
            this.chartHarcama.Location = new System.Drawing.Point(385, 21);
            this.chartHarcama.Name = "chartHarcama";
            this.chartHarcama.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Harcamalar";
            this.chartHarcama.Series.Add(series1);
            this.chartHarcama.Size = new System.Drawing.Size(760, 450);
            this.chartHarcama.TabIndex = 6;
            this.chartHarcama.Text = "chart1";
            // 
            // BtnRapor
            // 
            this.BtnRapor.Location = new System.Drawing.Point(10, 428);
            this.BtnRapor.Name = "BtnRapor";
            this.BtnRapor.Size = new System.Drawing.Size(369, 42);
            this.BtnRapor.TabIndex = 7;
            this.BtnRapor.Text = "Rapor Al";
            this.BtnRapor.UseVisualStyleBackColor = true;
            this.BtnRapor.Click += new System.EventHandler(this.BtnRapor_Click);
            // 
            // KartEkstreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 574);
            this.Controls.Add(this.CmbKrediKartlar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupBoxEkstreDetay);
            this.Name = "KartEkstreForm";
            this.Text = "KartEkstreForm";
            this.Load += new System.EventHandler(this.KartEkstreForm_Load);
            this.GroupBoxEkstreDetay.ResumeLayout(false);
            this.GroupBoxEkstreDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHarcama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupBoxEkstreDetay;
        private System.Windows.Forms.ComboBox CmbKrediKartlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblDiger;
        private System.Windows.Forms.Label LblEgitim;
        private System.Windows.Forms.Label LblYakit;
        private System.Windows.Forms.Label LblYiyecek;
        private System.Windows.Forms.Label LblGiyim;
        private System.Windows.Forms.Label LblToplamHarcama;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHarcama;
        private System.Windows.Forms.Button BtnRapor;
    }
}