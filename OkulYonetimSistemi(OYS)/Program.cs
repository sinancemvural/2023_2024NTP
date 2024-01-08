// See https://aka.ms/new-console-template for more information

using OkulYonetimSistemi_OYS_;
using System.Collections;

List<Ogrenci> ogrenciler=new List<Ogrenci>();

Ogrenci og1 = new Ogrenci("Ali", "Veli", "10B", 123, "11");
Ogrenci og2 = new Ogrenci("Ayşe", "Veli", "10B", 135, "12");
Ogrenci og3 = new Ogrenci("Mehmet", "Veli", "10A", 245, "90");

ogrenciler.Add(og1);
ogrenciler.Add(og2);
ogrenciler.Add(og3);

foreach(Ogrenci og in ogrenciler)
{
    if (og.sinif == "10A")
        og.EkranaYaz();
}


/* LİST GENEL KULLANIIM */
List<string> isimler = new List<string>();//List oluşturma 
isimler.Add("Ahmet");//Deger ekleme için Add kullanılır.
isimler.Add("Isıl");
isimler.Add("Cem");
isimler.Add("Ahmet");
isimler.Add("Mehmet");
isimler.Add("Samet");
isimler.Add("Efe");
isimler.Add("Arda");

isimler.Remove("Ahmet");
isimler.Remove(isimler[0]);

foreach(string ad in isimler)
{
    Console.WriteLine(ad);
}

isimler.RemoveAt(0);
foreach (string ad in isimler)
{
    Console.WriteLine(ad);
}

int C=isimler.Capacity;//Dizinin kapladıgı alan
Console.WriteLine("Kapasite:" + C);
int L = isimler.Count;//Diziinin içerisinde o an bulunan eleman sayısı
Console.WriteLine("Count:" + L);
bool V=isimler.Contains("Cem");//Aranan eleman varsa TRUE yoksa FALSE bilgisi döner
Console.WriteLine("Contains:" + V);
isimler.Insert(2, "Ali");//İstenilen Index numarasına ekleme işlemi yapar.
foreach (string ad in isimler)
{
    Console.WriteLine(ad);
}

int index = isimler.IndexOf("Mehmet");//Aranan degerin index numarasını döndürür.
Console.WriteLine("İndex No:" + index);

isimler.Reverse();//Diziyi ters çevirme
foreach (string ad in isimler)
{
    Console.WriteLine(ad);
}
isimler.Sort();//Dizi elemanlarını küçükten büyüge dogru sıralama
foreach (string ad in isimler)
{
    Console.WriteLine(ad);
}


isimler.Clear();//Dizinin içindeki bütün degerleri siler


