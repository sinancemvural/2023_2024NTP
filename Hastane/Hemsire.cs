using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    internal class Hemsire
    {
        //Properties

        public string ad, soyad, brans, calistigiHastane, tcNo;
        public int dogumTarihi;
        //Metotlar
        public void HastaKontrolEt()
        {
            Console.WriteLine("Hemşire " + ad + " şuanda hasta kontrolünde");
        }
        public void NobetTut()
        {
            Console.WriteLine("Hemşire " + ad + " şuan nöbette");
        }
        public void EkranaYaz()
        {
            Console.WriteLine("Hemşire Bilgileri:");
            /* Console.WriteLine("Ad:"+ad +"\n"+"Soyad:"+soyad+"\n"
                 +"Çalıştıgı Hastane:"+calistigiHastane+"\n"+
                 "T.C. No:"+tcNo+"\n"+"Branş:"+brans);*/

            Console.WriteLine("Ad:" + ad);
            Console.WriteLine("Soyad:" + soyad);
            Console.WriteLine("Branş:" + brans);
            Console.WriteLine("Hastane:" + calistigiHastane);
            Console.WriteLine("T.C. No:" + tcNo);
        }
    }
}
