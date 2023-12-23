// See https://aka.ms/new-console-template for more information

using System.Collections;

namespace SinavCalisma;
internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList kisiler = new ArrayList();

        char secim;

        do{
            Console.WriteLine("Yeni çalışan oluşturma..........1");
            Console.WriteLine("Çalışan bilgileri Güncelleme....2");
            Console.WriteLine("Çalışan Maaş Güncelleme.........3");
            Console.WriteLine("Sistemden Çıkma.................E");
            Console.Write("Tuşlarını kullanın.............:");
            secim=char.Parse(Console.ReadLine());

            switch(secim)
            {
                case '1':
                    KisiOlustur(kisiler);
                    break;
                case '2':
                    KisiGuncelle(kisiler);
                    break;
                case '3':
                    YeniMaas(kisiler);
                    break;
            }

        }while(secim != 'E');
    }

    static public void KisiOlustur(ArrayList array)
    {
        Kisi p=new Kisi();
        Console.Write("Ad:");
        string ad=Console.ReadLine();
        Console.Write("Soyad:");
        string soyad=Console.ReadLine();
        Console.Write("T.C. No:");
        string tcNo=Console.ReadLine();
        Console.Write("Maaş:");
        double maas=double.Parse(Console.ReadLine());

        p.BilgiGir(ad,soyad,tcNo,maas);

        array.Add(p);

        Console.WriteLine("Kişi Eklendi");
    }

    static public void KisiGuncelle(ArrayList array)
    {
        Console.Write("TC No:");
        string arananTcNo=Console.ReadLine();
        bool arananIndex=false;
        foreach(Kisi p in array)
        {
            if(p.tcNo==arananTcNo)
            {
                    Console.Write("Güncellenecek Kişinin\nAd:");
                    p.ad=Console.ReadLine();
                    Console.Write("Soyad:");
                    p.soyad=Console.ReadLine();

                    Console.WriteLine("Kişi Güncellendi");
                    arananIndex=true;
            }
        }

        if(arananIndex==false)
        {
           Console.WriteLine("Kişi Bulunamadı");
        }     
    }

    static public void YeniMaas(ArrayList array)
    {
        Console.Write("Maaşı güncellenecek kişinin kimlik numarası:");
        string maasTcNo=Console.ReadLine();
        
        int arananIndex=-1;

        foreach(Kisi p in array)
        {
            if(p.tcNo==maasTcNo)
            {
                arananIndex=0;
                Console.Write("Maaş oranı gir:");
                double oran=double.Parse(Console.ReadLine());

                double yeniMaas=p.MaasGuncelle(oran);

                Console.WriteLine("Yeni Maaş={0}",yeniMaas);
            }
        }
        if(arananIndex==-1)
        {
            Console.WriteLine("Kişi Bulunamadı");
        }
    }

}



