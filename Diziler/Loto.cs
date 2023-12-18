using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Loto
    {
        int[] sayilar = new int[7];
        Random rastgele=new Random();//Rastgele sayı bulur
        bool sayiVar = false;
        public void SayiBul()
        {
            for (int i = 0;i< 7;i++)
            {
                int bulunanSayi = rastgele.Next(1, 49);
                
                for(int j=0;j<i;j++)
                {
                    if (sayilar[j]==bulunanSayi)
                    {
                        i--;
                        sayiVar = true;
                    }
                }

                if(sayiVar==false)
                {
                    sayilar[i] = bulunanSayi;
                }
            }
        }

        public void Yaz()
        {
            Array.Sort(sayilar);
            for(int i=0;i<7;i++)
            {
                Console.Write(sayilar[i] + " ");
            }
        }
    }
}
