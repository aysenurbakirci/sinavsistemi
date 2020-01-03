namespace OgrenciSinavSistemiUygulamasi
{
    partial class OgrenciEkrani
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
            this.tumSonuclar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSinavEkrani = new MetroFramework.Controls.MetroTile();
            this.btnAyrintiliSonuc = new MetroFramework.Controls.MetroTile();
            this.lblOgrenciTC = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tumSonuclar)).BeginInit();
            this.SuspendLayout();
            // 
            // tumSonuclar
            // 
            chartArea1.Name = "ChartArea1";
            this.tumSonuclar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.tumSonuclar.Legends.Add(legend1);
            this.tumSonuclar.Location = new System.Drawing.Point(231, 63);
            this.tumSonuclar.Name = "tumSonuclar";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "SinavPuanlari";
            this.tumSonuclar.Series.Add(series1);
            this.tumSonuclar.Size = new System.Drawing.Size(475, 300);
            this.tumSonuclar.TabIndex = 0;
            this.tumSonuclar.Click += new System.EventHandler(this.tumSonuclar_Click);
            // 
            // btnSinavEkrani
            // 
            this.btnSinavEkrani.ActiveControl = null;
            this.btnSinavEkrani.Location = new System.Drawing.Point(23, 136);
            this.btnSinavEkrani.Name = "btnSinavEkrani";
            this.btnSinavEkrani.Size = new System.Drawing.Size(132, 68);
            this.btnSinavEkrani.TabIndex = 1;
            this.btnSinavEkrani.Text = "Sınava Git";
            this.btnSinavEkrani.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSinavEkrani.UseSelectable = true;
            this.btnSinavEkrani.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btnAyrintiliSonuc
            // 
            this.btnAyrintiliSonuc.ActiveControl = null;
            this.btnAyrintiliSonuc.Location = new System.Drawing.Point(23, 227);
            this.btnAyrintiliSonuc.Name = "btnAyrintiliSonuc";
            this.btnAyrintiliSonuc.Size = new System.Drawing.Size(132, 68);
            this.btnAyrintiliSonuc.TabIndex = 2;
            this.btnAyrintiliSonuc.Text = "Ayrıntılı Sonuçlar";
            this.btnAyrintiliSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAyrintiliSonuc.UseSelectable = true;
            this.btnAyrintiliSonuc.Click += new System.EventHandler(this.btnAyrintiliSonuc_Click);
            // 
            // lblOgrenciTC
            // 
            this.lblOgrenciTC.AutoSize = true;
            this.lblOgrenciTC.Location = new System.Drawing.Point(23, 82);
            this.lblOgrenciTC.Name = "lblOgrenciTC";
            this.lblOgrenciTC.Size = new System.Drawing.Size(81, 19);
            this.lblOgrenciTC.TabIndex = 3;
            this.lblOgrenciTC.Text = "metroLabel1";
            // 
            // OgrenciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOgrenciTC);
            this.Controls.Add(this.btnAyrintiliSonuc);
            this.Controls.Add(this.btnSinavEkrani);
            this.Controls.Add(this.tumSonuclar);
            this.Name = "OgrenciEkrani";
            this.Text = "Öğrenci Ekranı";
            this.Load += new System.EventHandler(this.OgrenciEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tumSonuclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart tumSonuclar;
        private MetroFramework.Controls.MetroTile btnSinavEkrani;
        private MetroFramework.Controls.MetroTile btnAyrintiliSonuc;
        private MetroFramework.Controls.MetroLabel lblOgrenciTC;
    }
}