// See https://aka.ms/new-console-template for more information

MusteriDAL mdb=new MusteriDAL();
UrunDAL udb=new UrunDAL();
SepetDAL sdb=new SepetDAL();
char secim='1';
do{
    Console.WriteLine("Sepet Listeleme......0");
    Console.WriteLine("Listeleme............1");
    Console.WriteLine("Ada Göre Listeleme...2");
    Console.WriteLine("Silme................3");
    Console.WriteLine("Güncelleme...........4");
    Console.WriteLine("Ekleme...............5");
    Console.WriteLine("Çıkış................9");
    Console.Write("Tuşlarını kullanın:");
    secim=char.Parse(Console.ReadLine());
    Islem(secim);
}while(secim!='9');


void Islem(char d)
{
    switch (d)
    {
        case '0':
                Console.Clear();
                sdb.GetAll();
                break;
        case '1':
                Console.Clear();
                udb.GetAll();
                break;
        case '2':
                Console.Clear();
                Console.Write("Aranan isim:");
                string isim=Console.ReadLine();
                udb.GetNameLike(isim);
                break;
        case '3':
                Console.Clear();
                Console.Write("Silinecek ID:");
                int mId=int.Parse(Console.ReadLine());
                udb.Delete(mId);
                break;
        case '4':
                Console.Clear();
                Console.Write("Güncellenecek ID:");
                int gId=int.Parse(Console.ReadLine());
                udb.Update(gId);
                break;
        case '5':
                Console.Clear();
                udb.Insert();
                break;
        default:
                break;
    }
}