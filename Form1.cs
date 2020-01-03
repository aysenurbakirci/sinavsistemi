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
    public partial class anaEkran : MetroFramework.Forms.MetroForm
    {
        public anaEkran()
        {
            InitializeComponent();
        }

        private void anaEkran_Load(object sender, EventArgs e)
        {

        }

        private void ogrenciGirisi_Click(object sender, EventArgs e)
        {

        }

        private void btnOgretmenGiris_Click(object sender, EventArgs e)
        {
            string onay = "";
            databaseClass data = new databaseClass();
            onay = data.ogrentmenGirisi(ogretmenTC.Text, ogretmenSifre.Text);

            if(onay == "1")
            {
                SoruEkle ogretmenEkrani = new SoruEkle();
                ogretmenEkrani.Show();
            }
        }

        private void btnOgrenciGiris_Click(object sender, EventArgs e)
        {
            string onay = "";
            databaseClass data = new databaseClass();
            OgrenciEkrani.ogrenciTCKimlik = ogrenciTC.Text;
            onay = data.ogrenciGirisi(ogrenciTC.Text, ogrenciSifre.Text);

            if(onay == "1")
            {
                OgrenciEkrani ogrenciEkrani = new OgrenciEkrani();
                ogrenciEkrani.Show();
            }
        }
    }
}
