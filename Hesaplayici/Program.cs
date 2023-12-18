// See https://aka.ms/new-console-template for more information

using Hesaplayici;

HseapMak hesapYap = new HseapMak();//NESNE 
char secim;
do
{
    Console.WriteLine("Toplama için.....T");
    Console.WriteLine("Çarpma için......X");
    Console.WriteLine("Bölme için.......B");
    Console.WriteLine("Çıkarma için.....C");
    Console.WriteLine("Çıkmak için......E");
    Console.Write("Tuşlarını Kullanın:");

    secim = Convert.ToChar(Console.ReadLine().ToUpper());

    int sayi1, sayi2;

    
        Console.Write("1.Sayı:");
        sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("2.Sayı:");
        sayi2 = int.Parse(Console.ReadLine());
  
  

    switch (secim)
    {
        case 'T':

            Console.WriteLine("Sonuc:" + hesapYap.Topla(sayi1, sayi2));
            break;

        case 'X':

            Console.WriteLine("Sonuc:" + hesapYap.Carpma(sayi1, sayi2));
            break;
        case 'B':
            Console.WriteLine("Sonuc:" + hesapYap.Bol(sayi1, sayi2));
            break;

        case 'C':
            Console.WriteLine("Sonuc:" + hesapYap.Cikarma(sayi1, sayi2));
            break;
        default:
            Console.WriteLine("Hatalı İşlem");
            break;
    }
} while (secim != 'E');