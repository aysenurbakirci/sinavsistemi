namespace OgrenciSinavSistemiUygulamasi
{
    partial class AyrintiliSonucEkrani
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tarihListesi = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ayrintiliSonuc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ayrintiliSonuc)).BeginInit();
            this.SuspendLayout();
            // 
            // tarihListesi
            // 
            this.tarihListesi.FormattingEnabled = true;
            this.tarihListesi.ItemHeight = 23;
            this.tarihListesi.Location = new System.Drawing.Point(23, 107);
            this.tarihListesi.Name = "tarihListesi";
            this.tarihListesi.Size = new System.Drawing.Size(237, 29);
            this.tarihListesi.TabIndex = 0;
            this.tarihListesi.UseSelectable = true;
            this.tarihListesi.SelectedIndexChanged += new System.EventHandler(this.tarihListesi_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(157, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Sınav Tarihi Seçiniz:";
            // 
            // ayrintiliSonuc
            // 
            chartArea1.Name = "ChartArea1";
            this.ayrintiliSonuc.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ayrintiliSonuc.Legends.Add(legend1);
            this.ayrintiliSonuc.Location = new System.Drawing.Point(266, 79);
            this.ayrintiliSonuc.Name = "ayrintiliSonuc";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "CarpanlaraAyirma";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "UsluIfadeler";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "KokluIfadeler";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Olasilik";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Cebir";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "DogrusalDenklemler";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Esitsizlikler";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Ucgenler";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "EslikVeBenzerlik";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "GeometrikCisimler";
            this.ayrintiliSonuc.Series.Add(series1);
            this.ayrintiliSonuc.Series.Add(series2);
            this.ayrintiliSonuc.Series.Add(series3);
            this.ayrintiliSonuc.Series.Add(series4);
            this.ayrintiliSonuc.Series.Add(series5);
            this.ayrintiliSonuc.Series.Add(series6);
            this.ayrintiliSonuc.Series.Add(series7);
            this.ayrintiliSonuc.Series.Add(series8);
            this.ayrintiliSonuc.Series.Add(series9);
            this.ayrintiliSonuc.Series.Add(series10);
            this.ayrintiliSonuc.Size = new System.Drawing.Size(511, 300);
            this.ayrintiliSonuc.TabIndex = 2;
            this.ayrintiliSonuc.Text = "chart1";
            // 
            // AyrintiliSonucEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ayrintiliSonuc);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tarihListesi);
            this.Name = "AyrintiliSonucEkrani";
            this.Text = "Sonuç Ekranı";
            this.Load += new System.EventHandler(this.AyrintiliSonucEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ayrintiliSonuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox tarihListesi;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ayrintiliSonuc;
    }
}