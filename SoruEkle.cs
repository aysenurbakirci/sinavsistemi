using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciSinavSistemiUygulamasi
{
    public partial class SoruEkle : MetroFramework.Forms.MetroForm
    {
        public SoruEkle()
        {
            InitializeComponent();
        }
        int konuBasligi;
        private void SoruEkle_Load(object sender, EventArgs e)
        {
            databaseClass data = new databaseClass();
            List<string> konuBasliklari = new List<string>();
            konuBasliklari = data.konuBasliklari();
            for(int i = 0; i< konuBasliklari.Count()-1; i++)
            {
                konuListesi.Items.Add(konuBasliklari[i]);
            }

        }

        private void konuListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            konuBasligi = konuListesi.SelectedIndex + 1;
        }

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            string kontrol;
            databaseClass data = new databaseClass();
            kontrol = data.soruEkle(konuBasligi, soruMetni.Text, dogruCevap.Text, secenekA.Text, secenekB.Text, secenekC.Text, secenekD.Text);
            if(kontrol != "1")
            {
                MetroFramework.MetroMessageBox.Show(this, "HATA!", "Soru Eklenemedi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
