using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OgrenciSinavSistemiUygulamasi
{
    class databaseClass
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L4H2ERB\\SQLEXPRESS;Initial Catalog=OgrSinavSistem;Integrated Security=True");

        public string ogrenciGirisi(string ogrenciTc, string sifre)
        {
            string onay = "0";
            try
            {
                SqlCommand girisKomut = new SqlCommand();
                baglanti.Open();
                girisKomut.Connection = baglanti;
                girisKomut.CommandText = "SELECT * FROM OgrenciBilgi WHERE OgrenciTC = '" + ogrenciTc + "' AND OgrenciSifre = '" + sifre + "'";
                SqlDataReader dataReader = girisKomut.ExecuteReader();
                if (dataReader.Read())
                {
                    onay = "1";
                }
            }
            catch (Exception hata)
            {
                onay = hata.ToString();
            }
            finally
            {

                baglanti.Close();
            }

            return onay;
        }

        public string ogrentmenGirisi(string ogretmenTC, string sifre)
        {
            string onay = "0";

            try
            {
                SqlCommand girisKomut = new SqlCommand();
                baglanti.Open();
                girisKomut.Connection = baglanti;
                girisKomut.CommandText = "SELECT * FROM OgretmenBilgileri WHERE OgretmenTC = '" + ogretmenTC + "' AND OgretmenSifre = '" + sifre + "'";
                SqlDataReader dataReader = girisKomut.ExecuteReader();
                if (dataReader.Read())
                {
                    onay = "1";
                }
            }
            catch (Exception hata)
            {
                onay = hata.ToString();
            }
            finally
            {
                baglanti.Close();
            }

            return onay;
        }

        public string soruEkle(int konuID, string soruMtn, string dgrCevap, string a, string b, string c, string d)
        {
            string kontrol = "1";
            try
            {
                baglanti.Open();
                SqlCommand kaydetKomut = new SqlCommand("INSERT INTO SinavSorulari (KonuBasligiID,SoruCumlesi,SecenekA,SecenekB,SecenekC,SecenekD,DogruCevap) VALUES ('" + konuID + "','" + soruMtn + "','" + a + "','" + b + "','" + c + "','" + d + "','" + dgrCevap + "')", baglanti);
                kaydetKomut.ExecuteNonQuery();
            }
            catch(Exception hata)
            {
                kontrol = hata.ToString();
            }
            finally
            {
                baglanti.Close();
            }
            return kontrol;
        }

        public List<string> konuBasliklari()
        {
            List<string> konuBasliklari = new List<string>();
            try
            {
                baglanti.Open();
                SqlCommand soruBaslikListeKomutu = new SqlCommand("SELECT * FROM KonuBasliklari", baglanti);
                soruBaslikListeKomutu.ExecuteNonQuery();
                SqlDataReader reader = soruBaslikListeKomutu.ExecuteReader();
                while (reader.Read())
                {
                    konuBasliklari.Add(reader["KonuBasligi"].ToString());
                }
            }
            catch (Exception hata)
            {
                konuBasliklari.Add(hata.ToString());
            }
            finally
            {
                baglanti.Close();
            }
            return konuBasliklari;
        }

        public List<string> tarihListesiOlustur(string ogrenciTC)
        {
            List<string> tarihListesi = new List<string>();

            try
            {
                baglanti.Open();
                SqlCommand sinavTarihListeKomutu = new SqlCommand("SELECT * FROM SonucKontrolleri WHERE OgrenciTC ='" + ogrenciTC + "'", baglanti);
                sinavTarihListeKomutu.ExecuteNonQuery();
                SqlDataReader reader = sinavTarihListeKomutu.ExecuteReader();
                while (reader.Read())
                {
                    tarihListesi.Add(reader["CozulduguTarih"].ToString());
                }
            }
            catch (Exception hata)
            {
                
            }
            finally
            {
                baglanti.Close();
            }
            return tarihListesi;
        }

        public List<string> genelSonuc(string ogrenciTC, List<string> tarihler)
        {
            List<string> sonucListesi = new List<string>();
            int toplamDogru = 0;
            
            
            for (int i = 0; i < tarihler.Count - 1; i++)
            {
                baglanti.Open();
                SqlCommand sonucKomut = new SqlCommand("SELECT * FROM SonucKontrolleri WHERE OgrenciTC ='" + ogrenciTC + "' AND CozulduguTarih = '" + tarihler[i] + "'", baglanti);
                sonucKomut.ExecuteNonQuery();
                SqlDataReader read = sonucKomut.ExecuteReader();
                while (read.Read())
                {
                    toplamDogru += Convert.ToInt32(read["DogruSayisi"]);
                }
                sonucListesi.Add(toplamDogru.ToString());
                toplamDogru = 0;
                baglanti.Close();
            }
            
            return sonucListesi;
        }

        public List<string> ayrintiliSonuc(string tc,string tarih)
        {
            List<string> dogruListesi = new List<string>();

            baglanti.Open();
            SqlCommand sonucKomut = new SqlCommand("SELECT * FROM SonucKontrolleri WHERE OgrenciTC ='" + tc + "' AND CozulduguTarih = '" + tarih + "'", baglanti);
            sonucKomut.ExecuteNonQuery();
            SqlDataReader read = sonucKomut.ExecuteReader();
            while (read.Read())
            {
                dogruListesi.Add(read["DogruSayisi"].ToString());
            }
            return dogruListesi;
        }

        public List<string> soruYaz(int konuBasligiID)
        {
            List<string> soru = new List<string>();
            baglanti.Open();

            SqlCommand soruKomut = new SqlCommand("SELECT * FROM SinavSorulari WHERE KonuBasligiID = '"+ konuBasligiID +"'",baglanti);
            soruKomut.ExecuteNonQuery();
            SqlDataReader reader = soruKomut.ExecuteReader();
            while (reader.Read())
            {
                soru.Add(reader["SoruCumlesi"].ToString());
                soru.Add(reader["SecenekA"].ToString());
                soru.Add(reader["SecenekB"].ToString());
                soru.Add(reader["SecenekC"].ToString());
                soru.Add(reader["SecenekD"].ToString());
                soru.Add(reader["DogruCevap"].ToString());
            }

            return soru;

        }
    }
}
