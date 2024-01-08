using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimSistemi_OYS_
{
    internal class Ogrenci
    {
       public string ad, soyad, sinif, tcNo;
       public int okulNo;

        public Ogrenci(string ad, string soyad, string sinif, int okulNo, string tcno) //KURUCU METOT
        {
            this.ad = ad;
            this.soyad = soyad;
            this.sinif = sinif;
            this.okulNo = okulNo;
            this.tcNo = tcno;
        }

        public void EkranaYaz()
        {
            Console.WriteLine("Ad-Soyad:{0} {1}\nSınıf:{2}\nOkul Numarası:{3}", ad, soyad, sinif, okulNo);
        }
    }
}
