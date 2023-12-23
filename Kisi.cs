namespace SinavCalisma;

class Kisi{
    public string ad,soyad,tcNo;
    public double maas;

    public void BilgiGir(string ad,string soyad,string tcNo,double maas)
    {
        this.ad=ad;
        this.soyad=soyad;
        this.tcNo=tcNo;
        this.maas=maas;
    }

    public double MaasGuncelle(double oran)
    {
        maas += ((maas*oran)/100);
        return maas;
    }

    public void Bilgiler()
    {
        Console.WriteLine("Ad Soyad:{0} {1}\nMaaş:{2}",ad,soyad,maas);
    }
}