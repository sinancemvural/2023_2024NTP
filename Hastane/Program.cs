// See https://aka.ms/new-console-template for more information


using Hastane;

Doktor dr1 = new Doktor();//NESNE
dr1.Ad = "İsmail Efe";
dr1.Soyad = "Çalışkan";
dr1.Brans = "KBB";
dr1.CalistigiHastane = "Acıbadem Koşuyolu";
dr1.TcNo = "55686933215";

dr1.NobetTutmak();
dr1.MuayeneEtmek();
dr1.EkranaYaz();


Hemsire hemsire = new Hemsire();
hemsire.ad = "İsmail Efe";
hemsire.soyad = "Çalışan";
hemsire.brans = "Çocuk Bölümü";
hemsire.calistigiHastane = "Acıbadem Koşuyolu";
hemsire.tcNo = "3344556789";
hemsire.dogumTarihi = 1992;

hemsire.EkranaYaz();