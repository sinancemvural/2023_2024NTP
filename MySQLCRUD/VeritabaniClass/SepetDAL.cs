using MySql.Data;//MYSQL komutlarını projede kullanmamızı saglayan kütüphane
using MySql.Data.MySqlClient;

class SepetDAL{

    string connectionString;//VeriTabanının bulundugu adresi içinde barındıracak.

    MySqlConnection conn;//Veritabanı ile haberlemeyi saglayacak degişkenim.

    public SepetDAL(){//KURUCU METOT

        connectionString="Server=localhost;Database=yonetimsistemi;Uid=root;Pwd=";
    } 

    public void Baglan()
    {
        conn=new MySqlConnection(connectionString);

       try{//HATA Yapılma ihtimali olan kısım
        conn.Open();
        Console.WriteLine("OK!");
       }
       catch(Exception e){//Hata olursa hatayı yakalayacak kısım
        Console.WriteLine(e);
       }
    }

    public void GetAll()
    {
        Baglan();
        string query="SELECT S.sepetId AS SepetNo , M.ad AS MusteriAd, M.soyad AS MusteriSoyad,U.ad as UrunAdı,U.fiyat as Fiyat FROM sepet S,musteriler M, urun U WHERE S.sepetId=M.musteriID AND S.urunId=U.urunid";

        MySqlCommand cmd=new MySqlCommand(query,conn);

        MySqlDataReader dr=cmd.ExecuteReader();

        Console.WriteLine("No--Must.Ad--Must.Soyad--UrunAd--Fiyat");
        while(dr.Read())
        {
            Console.WriteLine(dr["SepetNo"].ToString()
            +"--"+dr["MusteriAd"].ToString()
            +"--"+dr["MusteriSoyad"].ToString()
            +"--"+dr["UrunAdı"].ToString()
            +"--"+dr["Fiyat"].ToString());
        }
        dr.Close();
        conn.Close();
    }

    public void Insert()
    {
    }

    public void Delete(int sID)
    {
      
    }

    public void Update(int sID)
    {
       
    }
}