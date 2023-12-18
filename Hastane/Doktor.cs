using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    internal class Doktor
    {
        public string Ad;
        public string Soyad;
        public string TcNo;
        public string Brans;
        public string CalistigiHastane;
    
        public void MuayeneEtmek() //Metot
        {//Metot veya Sınıfın başlangıcı
            Console.WriteLine("Doktor "+Ad+" suan muayenede");
        }//Metot veya sınıfın bitişi
        
        public void AmeliyatYapmak()
        {
            Console.WriteLine("Doktor "+Ad+" suan ameliyatta");
        }

        public void NobetTutmak()
        {
            Console.WriteLine("Doktor "+Ad+" nöbette");
        }

        public void EkranaYaz()
        {
            Console.WriteLine("Doktor Bilgileri:");
            Console.WriteLine(Ad+"\n"+Soyad+"\n"
                +Brans+"\n"+CalistigiHastane
                +"\n"+TcNo);
            // /n-->SatırBaşı Yapar 
        }
    }
}
