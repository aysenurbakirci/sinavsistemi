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
    public partial class OgrenciEkrani : MetroFramework.Forms.MetroForm
    {
        public OgrenciEkrani()
        {
            InitializeComponent();
        }

        static public string ogrenciTCKimlik;

        private void OgrenciEkrani_Load(object sender, EventArgs e)
        {
            lblOgrenciTC.Text = ogrenciTCKimlik;
            AyrintiliSonucEkrani.ogrenciTCKimlikAyrintili = lblOgrenciTC.Text;

            List<string> tarih = new List<string>();
            List<string> liste = new List<string>();
            databaseClass data = new databaseClass();
            tarih = data.tarihListesiOlustur(lblOgrenciTC.Text);
            liste = data.genelSonuc(lblOgrenciTC.Text,tarih);

            this.tumSonuclar.Series["SinavPuanlari"].Points.AddXY(tarih[0], liste[0]);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            SinavEkrani sinav = new SinavEkrani();
            sinav.Show();

        }

        private void btnAyrintiliSonuc_Click(object sender, EventArgs e)
        {
            AyrintiliSonucEkrani sonuc = new AyrintiliSonucEkrani();
            sonuc.Show();
        }

        private void tumSonuclar_Click(object sender, EventArgs e)
        {

        }
    }
}
