// See https://aka.ms/new-console-template for more information
using System.Collections;

ArrayList yeniListe=new ArrayList();
yeniListe.Add(3);
yeniListe.Add("Merhaba");
yeniListe.Add('k');
yeniListe.Add(true);

foreach (var eleman in yeniListe)
{
    Console.WriteLine(eleman);
}

Console.WriteLine("******************INSERT**************************");
yeniListe.Insert(1, "Nasılsın");//İstenilen index No ekleme yapar.
foreach (var eleman in yeniListe)
{
    Console.WriteLine(eleman);
}


Console.WriteLine("******************REMOVE**************************");
yeniListe.Remove('k');
foreach (var eleman in yeniListe)
{
    Console.WriteLine(eleman);
}