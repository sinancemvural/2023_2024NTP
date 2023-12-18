using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    internal class Hesapla
    {
        public int Topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
            
        }

        public void Carp(int sayi1,int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            
        }

        public void Bol(int sayi1,int sayi2)
        {
            if(sayi2==0)
            {
                Console.WriteLine("0'a bölme işlemi yapılamaz.");
            }
            else
            {
                int sonuc = sayi1 / sayi2;
                Console.WriteLine(sonuc);
            }
        }

        public void Cikar(int sayi1,int sayi2)
        {
            int sonuc = 0;
            if (sayi1 > sayi2)
            {
                Console.WriteLine(sayi1 + "-" + sayi2 + ":");
                sonuc = sayi1 - sayi2;
            }
           else
            {
                Console.WriteLine(sayi2 + "-" + sayi1 + ":");
                sonuc = sayi2 - sayi1;
            }

            Console.WriteLine(sonuc);
        }

        public void RakamYaz(int rakam)
        {
            switch(rakam)
            {
                case 0:
                     Console.WriteLine("SIFIR");
                     break;
                case 1:
                    Console.WriteLine("BİR");
                    break;
                case 2:
                    Console.WriteLine("İKİ");
                    break;
                case 3:
                    Console.WriteLine("ÜÇ");
                    break;
                case 4:
                    Console.WriteLine("DÖRT");
                    break;
                case 5:
                    Console.WriteLine("BEŞ");
                    break;
                case 6:
                    Console.WriteLine("ALTI");
                    break;
                case 7:
                    Console.WriteLine("YEDİ");
                    break;
                case 8:
                    Console.WriteLine("SEKİZ");
                    break;
                case 9:
                    Console.WriteLine("DOKUZ");
                    break;
                default:
                    Console.WriteLine("RAKAM DEGİL");
                    break;
            }
        }
    }
}
