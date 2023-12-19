// See https://aka.ms/new-console-template for more information


using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList kisiler = new ArrayList();
        kisiler.Add("Ahmet");
        kisiler.Add("Ali");
        kisiler.Add("Selma");
        kisiler.Add("Fatma");
        kisiler.Add("Cem");
        kisiler.Add("İsmail");
        kisiler.Add("Celal");
        kisiler.Add("Sidal");

        char secim;
        do
        {
            Console.WriteLine("Arama için......1");
            Console.WriteLine("Silme için......2");
            Console.WriteLine("Ekleme için.....3");
            Console.WriteLine("Listeleme için..4");
            Console.WriteLine("Çıkmak için.....X");
            Console.Write("Tuşuna basın:");
            secim = char.Parse(Console.ReadLine());
            Console.Clear();
            switch (secim)
            {
                case '1':
                    Arama(kisiler);
                    break;
                case '2':
                    Silme(kisiler);
                    break;
                case '3':
                    Ekleme(kisiler);
                    break;
                case '4':
                    Listele(kisiler);
                    break;
                default:
                    Console.WriteLine("Yanlış Seçim");
                    break;

            }
        } while (secim != 'X');

    }

    private static void Listele(ArrayList kisiler)
    {
       foreach(var isim in kisiler)
        {
            Console.WriteLine(isim);
        }
    }

    private static void Ekleme(ArrayList kisiler)
    {
        Console.Write("Eklenecek isim:");
        string isim = Console.ReadLine();

        kisiler.Add(isim);
    }

    private static void Silme(ArrayList kisiler)
    {

        Console.Write("Silinecek isim:");
        string isim = Console.ReadLine();
        bool var = kisiler.Contains(isim);

        if(var)
        {
            Console.Write("Silmek için...Y \n İptal için...N:");
            char secim = char.Parse(Console.ReadLine());
            if(secim=='Y')
            {
                kisiler.Remove(isim);
                Console.WriteLine("Kişi silindi");
            }
            else
            {
                Console.WriteLine("Kişi Silinmedi");
            }
        }
        else
        {
            Console.WriteLine("Kişi Bulunamadı");
        }

       
    }

    private static void Arama(ArrayList kisiler)
    {
        Console.Write("Kisi ismi:");
        string arananKisi = Console.ReadLine();

        bool var=kisiler.Contains(arananKisi);

        if (var)
            Console.WriteLine("Kişi Ekli!!!");
        else
            Console.WriteLine("Kişi Ekli Degil!!!");
    }
}