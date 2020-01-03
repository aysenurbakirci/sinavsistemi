namespace OgrenciSinavSistemiUygulamasi
{
    partial class SoruEkle
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
            this.konuListesi = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.soruMetni = new MetroFramework.Controls.MetroTextBox();
            this.dogruCevap = new MetroFramework.Controls.MetroTextBox();
            this.secenekA = new MetroFramework.Controls.MetroTextBox();
            this.secenekB = new MetroFramework.Controls.MetroTextBox();
            this.secenekC = new MetroFramework.Controls.MetroTextBox();
            this.secenekD = new MetroFramework.Controls.MetroTextBox();
            this.btnSoruEkle = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // konuListesi
            // 
            this.konuListesi.FormattingEnabled = true;
            this.konuListesi.ItemHeight = 23;
            this.konuListesi.Location = new System.Drawing.Point(96, 85);
            this.konuListesi.Name = "konuListesi";
            this.konuListesi.Size = new System.Drawing.Size(241, 29);
            this.konuListesi.TabIndex = 0;
            this.konuListesi.UseSelectable = true;
            this.konuListesi.SelectedIndexChanged += new System.EventHandler(this.konuListesi_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(35, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Konu:";
            // 
            // soruMetni
            // 
            // 
            // 
            // 
            this.soruMetni.CustomButton.Image = null;
            this.soruMetni.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.soruMetni.CustomButton.Name = "";
            this.soruMetni.CustomButton.Size = new System.Drawing.Size(119, 119);
            this.soruMetni.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.soruMetni.CustomButton.TabIndex = 1;
            this.soruMetni.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.soruMetni.CustomButton.UseSelectable = true;
            this.soruMetni.CustomButton.Visible = false;
            this.soruMetni.Lines = new string[] {
        "Soru Metni:"};
            this.soruMetni.Location = new System.Drawing.Point(35, 140);
            this.soruMetni.MaxLength = 32767;
            this.soruMetni.Multiline = true;
            this.soruMetni.Name = "soruMetni";
            this.soruMetni.PasswordChar = '\0';
            this.soruMetni.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.soruMetni.SelectedText = "";
            this.soruMetni.SelectionLength = 0;
            this.soruMetni.SelectionStart = 0;
            this.soruMetni.ShortcutsEnabled = true;
            this.soruMetni.Size = new System.Drawing.Size(302, 121);
            this.soruMetni.TabIndex = 2;
            this.soruMetni.Text = "Soru Metni:";
            this.soruMetni.UseSelectable = true;
            this.soruMetni.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.soruMetni.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dogruCevap
            // 
            // 
            // 
            // 
            this.dogruCevap.CustomButton.Image = null;
            this.dogruCevap.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.dogruCevap.CustomButton.Name = "";
            this.dogruCevap.CustomButton.Size = new System.Drawing.Size(47, 47);
            this.dogruCevap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dogruCevap.CustomButton.TabIndex = 1;
            this.dogruCevap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dogruCevap.CustomButton.UseSelectable = true;
            this.dogruCevap.CustomButton.Visible = false;
            this.dogruCevap.Lines = new string[] {
        "Doğru Cevap:"};
            this.dogruCevap.Location = new System.Drawing.Point(35, 276);
            this.dogruCevap.MaxLength = 32767;
            this.dogruCevap.Multiline = true;
            this.dogruCevap.Name = "dogruCevap";
            this.dogruCevap.PasswordChar = '\0';
            this.dogruCevap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dogruCevap.SelectedText = "";
            this.dogruCevap.SelectionLength = 0;
            this.dogruCevap.SelectionStart = 0;
            this.dogruCevap.ShortcutsEnabled = true;
            this.dogruCevap.Size = new System.Drawing.Size(302, 49);
            this.dogruCevap.TabIndex = 3;
            this.dogruCevap.Text = "Doğru Cevap:";
            this.dogruCevap.UseSelectable = true;
            this.dogruCevap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dogruCevap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // secenekA
            // 
            // 
            // 
            // 
            this.secenekA.CustomButton.Image = null;
            this.secenekA.CustomButton.Location = new System.Drawing.Point(248, 2);
            this.secenekA.CustomButton.Name = "";
            this.secenekA.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.secenekA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.secenekA.CustomButton.TabIndex = 1;
            this.secenekA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.secenekA.CustomButton.UseSelectable = true;
            this.secenekA.CustomButton.Visible = false;
            this.secenekA.Lines = new string[] {
        "A Şıkkı:"};
            this.secenekA.Location = new System.Drawing.Point(403, 85);
            this.secenekA.MaxLength = 32767;
            this.secenekA.Multiline = true;
            this.secenekA.Name = "secenekA";
            this.secenekA.PasswordChar = '\0';
            this.secenekA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.secenekA.SelectedText = "";
            this.secenekA.SelectionLength = 0;
            this.secenekA.SelectionStart = 0;
            this.secenekA.ShortcutsEnabled = true;
            this.secenekA.Size = new System.Drawing.Size(302, 56);
            this.secenekA.TabIndex = 4;
            this.secenekA.Text = "A Şıkkı:";
            this.secenekA.UseSelectable = true;
            this.secenekA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.secenekA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // secenekB
            // 
            // 
            // 
            // 
            this.secenekB.CustomButton.Image = null;
            this.secenekB.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.secenekB.CustomButton.Name = "";
            this.secenekB.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.secenekB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.secenekB.CustomButton.TabIndex = 1;
            this.secenekB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.secenekB.CustomButton.UseSelectable = true;
            this.secenekB.CustomButton.Visible = false;
            this.secenekB.Lines = new string[] {
        "B Şıkkı:"};
            this.secenekB.Location = new System.Drawing.Point(403, 147);
            this.secenekB.MaxLength = 32767;
            this.secenekB.Multiline = true;
            this.secenekB.Name = "secenekB";
            this.secenekB.PasswordChar = '\0';
            this.secenekB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.secenekB.SelectedText = "";
            this.secenekB.SelectionLength = 0;
            this.secenekB.SelectionStart = 0;
            this.secenekB.ShortcutsEnabled = true;
            this.secenekB.Size = new System.Drawing.Size(302, 55);
            this.secenekB.TabIndex = 5;
            this.secenekB.Text = "B Şıkkı:";
            this.secenekB.UseSelectable = true;
            this.secenekB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.secenekB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // secenekC
            // 
            // 
            // 
            // 
            this.secenekC.CustomButton.Image = null;
            this.secenekC.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.secenekC.CustomButton.Name = "";
            this.secenekC.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.secenekC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.secenekC.CustomButton.TabIndex = 1;
            this.secenekC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.secenekC.CustomButton.UseSelectable = true;
            this.secenekC.CustomButton.Visible = false;
            this.secenekC.Lines = new string[] {
        "C Şıkkı:"};
            this.secenekC.Location = new System.Drawing.Point(403, 208);
            this.secenekC.MaxLength = 32767;
            this.secenekC.Multiline = true;
            this.secenekC.Name = "secenekC";
            this.secenekC.PasswordChar = '\0';
            this.secenekC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.secenekC.SelectedText = "";
            this.secenekC.SelectionLength = 0;
            this.secenekC.SelectionStart = 0;
            this.secenekC.ShortcutsEnabled = true;
            this.secenekC.Size = new System.Drawing.Size(302, 53);
            this.secenekC.TabIndex = 6;
            this.secenekC.Text = "C Şıkkı:";
            this.secenekC.UseSelectable = true;
            this.secenekC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.secenekC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // secenekD
            // 
            // 
            // 
            // 
            this.secenekD.CustomButton.Image = null;
            this.secenekD.CustomButton.Location = new System.Drawing.Point(246, 2);
            this.secenekD.CustomButton.Name = "";
            this.secenekD.CustomButton.Size = new System.Drawing.Size(53, 53);
            this.secenekD.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.secenekD.CustomButton.TabIndex = 1;
            this.secenekD.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.secenekD.CustomButton.UseSelectable = true;
            this.secenekD.CustomButton.Visible = false;
            this.secenekD.Lines = new string[] {
        "D Şıkkı:"};
            this.secenekD.Location = new System.Drawing.Point(403, 267);
            this.secenekD.MaxLength = 32767;
            this.secenekD.Multiline = true;
            this.secenekD.Name = "secenekD";
            this.secenekD.PasswordChar = '\0';
            this.secenekD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.secenekD.SelectedText = "";
            this.secenekD.SelectionLength = 0;
            this.secenekD.SelectionStart = 0;
            this.secenekD.ShortcutsEnabled = true;
            this.secenekD.Size = new System.Drawing.Size(302, 58);
            this.secenekD.TabIndex = 7;
            this.secenekD.Text = "D Şıkkı:";
            this.secenekD.UseSelectable = true;
            this.secenekD.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.secenekD.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.ActiveControl = null;
            this.btnSoruEkle.Location = new System.Drawing.Point(312, 361);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(162, 37);
            this.btnSoruEkle.TabIndex = 8;
            this.btnSoruEkle.Text = "Ekle";
            this.btnSoruEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSoruEkle.UseSelectable = true;
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // SoruEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSoruEkle);
            this.Controls.Add(this.secenekD);
            this.Controls.Add(this.secenekC);
            this.Controls.Add(this.secenekB);
            this.Controls.Add(this.secenekA);
            this.Controls.Add(this.dogruCevap);
            this.Controls.Add(this.soruMetni);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.konuListesi);
            this.Name = "SoruEkle";
            this.Text = "Öğretmen Ekranı(Soru Ekleme)";
            this.Load += new System.EventHandler(this.SoruEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox konuListesi;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox soruMetni;
        private MetroFramework.Controls.MetroTextBox dogruCevap;
        private MetroFramework.Controls.MetroTextBox secenekA;
        private MetroFramework.Controls.MetroTextBox secenekB;
        private MetroFramework.Controls.MetroTextBox secenekC;
        private MetroFramework.Controls.MetroTextBox secenekD;
        private MetroFramework.Controls.MetroTile btnSoruEkle;
    }
}