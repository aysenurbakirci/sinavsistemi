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
    public partial class AyrintiliSonucEkrani : MetroFramework.Forms.MetroForm
    {
        public AyrintiliSonucEkrani()
        {
            InitializeComponent();
        }
        static public string ogrenciTCKimlikAyrintili;
        private void AyrintiliSonucEkrani_Load(object sender, EventArgs e)
        {

            List<string> tarihListe = new List<string>();
            databaseClass data = new databaseClass();
            tarihListe = data.tarihListesiOlustur(ogrenciTCKimlikAyrintili);
            tarihListesi.Items.Add(tarihListe[0]);
            for (int i = 1; i < tarihListe.Count - 1; i++)
            {
                if (tarihListe[i] != tarihListe[i + 1])
                {
                    tarihListesi.Items.Add(tarihListe[i]);
                }
            } 
        }

        private void tarihListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tarih = tarihListesi.SelectedItem.ToString();
            databaseClass data = new databaseClass();
            List<string> dogruSayilari = new List<string>();
            dogruSayilari =  data.ayrintiliSonuc(ogrenciTCKimlikAyrintili, tarih);

            this.ayrintiliSonuc.Series["CarpanlaraAyirma"].Points.AddY(dogruSayilari[0]);
            this.ayrintiliSonuc.Series["UsluIfadeler"].Points.AddY(dogruSayilari[1]);
            this.ayrintiliSonuc.Series["KokluIfadeler"].Points.AddY(dogruSayilari[2]);
            this.ayrintiliSonuc.Series["Olasilik"].Points.AddY(dogruSayilari[3]);
            this.ayrintiliSonuc.Series["Cebir"].Points.AddY(dogruSayilari[4]);
            this.ayrintiliSonuc.Series["DogrusalDenklemler"].Points.AddY(dogruSayilari[5]);
            this.ayrintiliSonuc.Series["Esitsizlikler"].Points.AddY(dogruSayilari[6]);
            this.ayrintiliSonuc.Series["Ucgenler"].Points.AddY(dogruSayilari[7]);
            this.ayrintiliSonuc.Series["EslikVeBenzerlik"].Points.AddY(dogruSayilari[8]);
            this.ayrintiliSonuc.Series["GeometrikCisimler"].Points.AddY(dogruSayilari[9]);
        }
    }
}
