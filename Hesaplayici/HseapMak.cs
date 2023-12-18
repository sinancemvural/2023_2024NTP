using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesaplayici
{
    internal class HseapMak
    {
        double sonuc;

        public double Topla(int sayi1,int sayi2)
        {
            sonuc= sayi1+sayi2;
            return sonuc;
        }

        public double Carpma(int sayi1,int sayi2)
        {
            sonuc = sayi1 * sayi2;
            return sonuc;
        }

        public double Bol(int sayi1,int sayi2)
        {
            if (sayi2 != 0)
            {
                sonuc = sayi1 / sayi2;
                return sonuc;
            }
            else
            {
                return -1;
            }
        }

        public double Cikarma(int sayi1,int sayi2)
        {
            if (sayi1 > sayi2)
            {
                sonuc = sayi1 - sayi2;
            }
            else
                sonuc = sayi2 - sayi1;
           
            return sonuc;
        }
    }
}
