using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OgrenciSinavSistemiUygulamasi
{
    [TestFixture]
    class TestClass
    {
        databaseClass data = new databaseClass();

        [Test]
        public void ogrenciGirisTesti()
        {
            string kontrol = data.ogrenciGirisi("11454342365", "232323");
            Assert.AreEqual(1, Convert.ToInt32(kontrol));
        }

        [Test]
        public void ogretmenGirisTesti()
        {
            string kontrol = data.ogrentmenGirisi("12321234543", "342423");
            Assert.AreEqual(1, Convert.ToInt32(kontrol));
        }

        [Test]
        public void soruCekme()
        {
            List<string> soruListe = new List<string>();
            soruListe = data.soruYaz(1);
            int kontrol = 0;
            if(soruListe != null)
            {
                kontrol = 1;
            }
            Assert.AreEqual(1, kontrol);
        }

    }
}
