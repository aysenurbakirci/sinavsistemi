namespace OgrenciSinavSistemiUygulamasi
{
    partial class anaEkran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.girisEkranlari = new MetroFramework.Controls.MetroTabControl();
            this.ogrenciGirisi = new MetroFramework.Controls.MetroTabPage();
            this.ogretmenGirisi = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ogretmenTC = new MetroFramework.Controls.MetroTextBox();
            this.ogretmenSifre = new MetroFramework.Controls.MetroTextBox();
            this.btnOgretmenGiris = new MetroFramework.Controls.MetroTile();
            this.btnOgrenciGiris = new MetroFramework.Controls.MetroTile();
            this.ogrenciSifre = new MetroFramework.Controls.MetroTextBox();
            this.ogrenciTC = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.girisEkranlari.SuspendLayout();
            this.ogrenciGirisi.SuspendLayout();
            this.ogretmenGirisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // girisEkranlari
            // 
            this.girisEkranlari.Controls.Add(this.ogrenciGirisi);
            this.girisEkranlari.Controls.Add(this.ogretmenGirisi);
            this.girisEkranlari.Location = new System.Drawing.Point(12, 58);
            this.girisEkranlari.Name = "girisEkranlari";
            this.girisEkranlari.SelectedIndex = 0;
            this.girisEkranlari.Size = new System.Drawing.Size(768, 269);
            this.girisEkranlari.TabIndex = 0;
            this.girisEkranlari.UseSelectable = true;
            // 
            // ogrenciGirisi
            // 
            this.ogrenciGirisi.Controls.Add(this.btnOgrenciGiris);
            this.ogrenciGirisi.Controls.Add(this.ogrenciSifre);
            this.ogrenciGirisi.Controls.Add(this.ogrenciTC);
            this.ogrenciGirisi.Controls.Add(this.metroLabel2);
            this.ogrenciGirisi.HorizontalScrollbarBarColor = true;
            this.ogrenciGirisi.HorizontalScrollbarHighlightOnWheel = false;
            this.ogrenciGirisi.HorizontalScrollbarSize = 10;
            this.ogrenciGirisi.Location = new System.Drawing.Point(4, 38);
            this.ogrenciGirisi.Name = "ogrenciGirisi";
            this.ogrenciGirisi.Size = new System.Drawing.Size(760, 227);
            this.ogrenciGirisi.TabIndex = 0;
            this.ogrenciGirisi.Text = "Öğrenci Girişi";
            this.ogrenciGirisi.VerticalScrollbarBarColor = true;
            this.ogrenciGirisi.VerticalScrollbarHighlightOnWheel = false;
            this.ogrenciGirisi.VerticalScrollbarSize = 10;
            this.ogrenciGirisi.Click += new System.EventHandler(this.ogrenciGirisi_Click);
            // 
            // ogretmenGirisi
            // 
            this.ogretmenGirisi.Controls.Add(this.btnOgretmenGiris);
            this.ogretmenGirisi.Controls.Add(this.ogretmenSifre);
            this.ogretmenGirisi.Controls.Add(this.ogretmenTC);
            this.ogretmenGirisi.Controls.Add(this.metroLabel1);
            this.ogretmenGirisi.HorizontalScrollbarBarColor = true;
            this.ogretmenGirisi.HorizontalScrollbarHighlightOnWheel = false;
            this.ogretmenGirisi.HorizontalScrollbarSize = 10;
            this.ogretmenGirisi.Location = new System.Drawing.Point(4, 38);
            this.ogretmenGirisi.Name = "ogretmenGirisi";
            this.ogretmenGirisi.Size = new System.Drawing.Size(760, 227);
            this.ogretmenGirisi.TabIndex = 1;
            this.ogretmenGirisi.Text = "Öğretmen Girişi";
            this.ogretmenGirisi.VerticalScrollbarBarColor = true;
            this.ogretmenGirisi.VerticalScrollbarHighlightOnWheel = false;
            this.ogretmenGirisi.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(299, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Öğretmen Girişi";
            // 
            // ogretmenTC
            // 
            // 
            // 
            // 
            this.ogretmenTC.CustomButton.Image = null;
            this.ogretmenTC.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.ogretmenTC.CustomButton.Name = "";
            this.ogretmenTC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ogretmenTC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ogretmenTC.CustomButton.TabIndex = 1;
            this.ogretmenTC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ogretmenTC.CustomButton.UseSelectable = true;
            this.ogretmenTC.CustomButton.Visible = false;
            this.ogretmenTC.Lines = new string[] {
        "T.C."};
            this.ogretmenTC.Location = new System.Drawing.Point(289, 76);
            this.ogretmenTC.MaxLength = 32767;
            this.ogretmenTC.Name = "ogretmenTC";
            this.ogretmenTC.PasswordChar = '\0';
            this.ogretmenTC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ogretmenTC.SelectedText = "";
            this.ogretmenTC.SelectionLength = 0;
            this.ogretmenTC.SelectionStart = 0;
            this.ogretmenTC.ShortcutsEnabled = true;
            this.ogretmenTC.Size = new System.Drawing.Size(122, 23);
            this.ogretmenTC.TabIndex = 3;
            this.ogretmenTC.Text = "T.C.";
            this.ogretmenTC.UseSelectable = true;
            this.ogretmenTC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ogretmenTC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ogretmenSifre
            // 
            // 
            // 
            // 
            this.ogretmenSifre.CustomButton.Image = null;
            this.ogretmenSifre.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.ogretmenSifre.CustomButton.Name = "";
            this.ogretmenSifre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ogretmenSifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ogretmenSifre.CustomButton.TabIndex = 1;
            this.ogretmenSifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ogretmenSifre.CustomButton.UseSelectable = true;
            this.ogretmenSifre.CustomButton.Visible = false;
            this.ogretmenSifre.Lines = new string[] {
        "Şifre"};
            this.ogretmenSifre.Location = new System.Drawing.Point(289, 105);
            this.ogretmenSifre.MaxLength = 32767;
            this.ogretmenSifre.Name = "ogretmenSifre";
            this.ogretmenSifre.PasswordChar = '\0';
            this.ogretmenSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ogretmenSifre.SelectedText = "";
            this.ogretmenSifre.SelectionLength = 0;
            this.ogretmenSifre.SelectionStart = 0;
            this.ogretmenSifre.ShortcutsEnabled = true;
            this.ogretmenSifre.Size = new System.Drawing.Size(122, 23);
            this.ogretmenSifre.TabIndex = 4;
            this.ogretmenSifre.Text = "Şifre";
            this.ogretmenSifre.UseSelectable = true;
            this.ogretmenSifre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ogretmenSifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnOgretmenGiris
            // 
            this.btnOgretmenGiris.ActiveControl = null;
            this.btnOgretmenGiris.Location = new System.Drawing.Point(299, 146);
            this.btnOgretmenGiris.Name = "btnOgretmenGiris";
            this.btnOgretmenGiris.Size = new System.Drawing.Size(102, 39);
            this.btnOgretmenGiris.TabIndex = 5;
            this.btnOgretmenGiris.Text = "Giriş";
            this.btnOgretmenGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOgretmenGiris.UseSelectable = true;
            this.btnOgretmenGiris.Click += new System.EventHandler(this.btnOgretmenGiris_Click);
            // 
            // btnOgrenciGiris
            // 
            this.btnOgrenciGiris.ActiveControl = null;
            this.btnOgrenciGiris.Location = new System.Drawing.Point(329, 153);
            this.btnOgrenciGiris.Name = "btnOgrenciGiris";
            this.btnOgrenciGiris.Size = new System.Drawing.Size(102, 39);
            this.btnOgrenciGiris.TabIndex = 9;
            this.btnOgrenciGiris.Text = "Giriş";
            this.btnOgrenciGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOgrenciGiris.UseSelectable = true;
            this.btnOgrenciGiris.Click += new System.EventHandler(this.btnOgrenciGiris_Click);
            // 
            // ogrenciSifre
            // 
            // 
            // 
            // 
            this.ogrenciSifre.CustomButton.Image = null;
            this.ogrenciSifre.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.ogrenciSifre.CustomButton.Name = "";
            this.ogrenciSifre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ogrenciSifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ogrenciSifre.CustomButton.TabIndex = 1;
            this.ogrenciSifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ogrenciSifre.CustomButton.UseSelectable = true;
            this.ogrenciSifre.CustomButton.Visible = false;
            this.ogrenciSifre.Lines = new string[] {
        "Şifre"};
            this.ogrenciSifre.Location = new System.Drawing.Point(319, 112);
            this.ogrenciSifre.MaxLength = 32767;
            this.ogrenciSifre.Name = "ogrenciSifre";
            this.ogrenciSifre.PasswordChar = '\0';
            this.ogrenciSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ogrenciSifre.SelectedText = "";
            this.ogrenciSifre.SelectionLength = 0;
            this.ogrenciSifre.SelectionStart = 0;
            this.ogrenciSifre.ShortcutsEnabled = true;
            this.ogrenciSifre.Size = new System.Drawing.Size(122, 23);
            this.ogrenciSifre.TabIndex = 8;
            this.ogrenciSifre.Text = "Şifre";
            this.ogrenciSifre.UseSelectable = true;
            this.ogrenciSifre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ogrenciSifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ogrenciTC
            // 
            // 
            // 
            // 
            this.ogrenciTC.CustomButton.Image = null;
            this.ogrenciTC.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.ogrenciTC.CustomButton.Name = "";
            this.ogrenciTC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ogrenciTC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ogrenciTC.CustomButton.TabIndex = 1;
            this.ogrenciTC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ogrenciTC.CustomButton.UseSelectable = true;
            this.ogrenciTC.CustomButton.Visible = false;
            this.ogrenciTC.Lines = new string[] {
        "T.C."};
            this.ogrenciTC.Location = new System.Drawing.Point(319, 83);
            this.ogrenciTC.MaxLength = 32767;
            this.ogrenciTC.Name = "ogrenciTC";
            this.ogrenciTC.PasswordChar = '\0';
            this.ogrenciTC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ogrenciTC.SelectedText = "";
            this.ogrenciTC.SelectionLength = 0;
            this.ogrenciTC.SelectionStart = 0;
            this.ogrenciTC.ShortcutsEnabled = true;
            this.ogrenciTC.Size = new System.Drawing.Size(122, 23);
            this.ogrenciTC.TabIndex = 7;
            this.ogrenciTC.Text = "T.C.";
            this.ogrenciTC.UseSelectable = true;
            this.ogrenciTC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ogrenciTC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(329, 35);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Öğrenci Girişi";
            // 
            // anaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.girisEkranlari);
            this.Name = "anaEkran";
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.anaEkran_Load);
            this.girisEkranlari.ResumeLayout(false);
            this.ogrenciGirisi.ResumeLayout(false);
            this.ogrenciGirisi.PerformLayout();
            this.ogretmenGirisi.ResumeLayout(false);
            this.ogretmenGirisi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl girisEkranlari;
        private MetroFramework.Controls.MetroTabPage ogrenciGirisi;
        private MetroFramework.Controls.MetroTabPage ogretmenGirisi;
        private MetroFramework.Controls.MetroTile btnOgrenciGiris;
        private MetroFramework.Controls.MetroTextBox ogrenciSifre;
        private MetroFramework.Controls.MetroTextBox ogrenciTC;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btnOgretmenGiris;
        private MetroFramework.Controls.MetroTextBox ogretmenSifre;
        private MetroFramework.Controls.MetroTextBox ogretmenTC;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

