//VERİ_TİPİ[] DİZİ_İSMİ=NEW VERİ_TİPİ[ELEMAN_SAYISI];

int[] notOrtalaması = new int[5];//DİZİ OLUŞTURMA

for(int i = 0; i < 5; i++)
{
    notOrtalaması[i] = int.Parse(Console.ReadLine());
}

foreach(int sayi in notOrtalaması)
{
    Console.WriteLine(sayi);
}




Console.WriteLine("Eleman Sayısı:"+notOrtalaması.Length);
Console.WriteLine("En Büyük Deger:" + notOrtalaması.Max());
Console.WriteLine("En Küçük Deger:" + notOrtalaması.Min());
Console.WriteLine("Toplam:" + notOrtalaması.Sum());
Console.WriteLine("Ortalama:" + notOrtalaması.Average());


/*using Diziler;

Loto sayisalLoto=new Loto();
sayisalLoto.SayiBul();
sayisalLoto.Yaz();*/
