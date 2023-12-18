using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        SifreOlustur();
       
    }

    static public void Selamlama(/*parametre*/)
    {
        Console.WriteLine("Merhaba");
    }

    static public string SelamlamaIki()
    { 
        return "Nasılsın";
    }

    static public string SelamlamaUc(string ad)
    {
        return ("İyi misiniz,Sayın " + ad);
    }

    static public void Dongu()
    {
        Console.WriteLine("***********For************");
        for(int i=0;i<=24;i++)
        {
            if(i%3==0)
                Console.WriteLine(i);
        }

        Console.WriteLine("***********Do-While************");
        int sayi = 0;
        do
        {
            if(sayi%3==0)
                Console.WriteLine(sayi);
            sayi++;
        } while (sayi <= 24);

        Console.WriteLine("***********While************");
        int sayi2 = 0;
        while(sayi2<=24)
        {
            if(sayi2%3==0)
                Console.WriteLine(sayi2);
            sayi2++;
        }
    }

    static public void CarpimTablosu() 
    { 
        for(int a=1;a<=10;a++)
        {
            for(int b=1;b<=10;b++)
            {
                // Console.Write(b + "*" + a + "=" + (b * a) + "  ||");
                if ((a * b) % 3 == 0 && (a*b)%5==0 && (a*b)%2==0)
                    Console.Write("{0}*{1} = {2}||", b, a, (a * b));
                else
                    Console.Write("        ||");
            }
            Console.WriteLine();
;        }
    }

    static public void SifreOlustur()
    {
        Random rastgele = new Random();
        object[] karakter = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'ı', '>', '<', '#', '*', '+', '-', '/', '(', ')'];

        string sifre="";

        for(int i=0;i<10;i++)
        {
            int index = rastgele.Next(0, 27);
            sifre += karakter[index];//sifre=sifre+karakter[index]
        }

        Console.WriteLine(sifre);
    }
}