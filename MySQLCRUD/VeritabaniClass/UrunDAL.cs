using MySql.Data;//MYSQL komutlarını projede kullanmamızı saglayan kütüphane
using MySql.Data.MySqlClient;

class UrunDAL{

    string connectionString;//VeriTabanının bulundugu adresi içinde barındıracak.

    MySqlConnection conn;//Veritabanı ile haberlemeyi saglayacak degişkenim.

    public UrunDAL(){//KURUCU METOT

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
        string query="select * from urun";

        MySqlCommand cmd=new MySqlCommand(query,conn);
        
        MySqlDataReader dr=cmd.ExecuteReader();

        while(dr.Read())
        {
            Console.WriteLine(dr["urunid"].ToString()
            +" "+dr["ad"].ToString()+" "
            +dr["adet"].ToString()+" "+dr["fiyat".ToString()]);
        }
        dr.Close();
        conn.Close();
    }

    public void GetName(string ad)
    {
        Baglan();
        string query="Select * from urun where ad=@ad";
        MySqlCommand cmd=new MySqlCommand(query,conn);
        cmd.Parameters.AddWithValue("@ad",ad);
        MySqlDataReader dr=cmd.ExecuteReader();

        while(dr.Read())
        {
            Console.WriteLine(dr["ad"].ToString()+" "+dr["adet"].ToString()+" "+dr["fiyat"].ToString());
        }

        dr.Close();
        conn.Close();
    }

    public void GetNameLike(string a)
    {
        Baglan();
        string query="Select * from urun where ad  Like @a";
        MySqlCommand cmd=new MySqlCommand(query,conn);
        cmd.Parameters.AddWithValue("@a",$"%{a}%");
        MySqlDataReader dr=cmd.ExecuteReader();

         while(dr.Read())
        {
            Console.WriteLine(dr["ad"].ToString()+" "+dr["adet"].ToString()+" "+dr["fiyat"].ToString());
        }


        dr.Close();
        conn.Close();
    }

    public void Insert()
    {
        Console.Write("Urun ad:");
        string ad=Console.ReadLine();
        Console.Write("Fiyat:");
        int fiyat=int.Parse(Console.ReadLine());
         Console.Write("Adet:");
        int adet=int.Parse(Console.ReadLine());
        Baglan();
        string query="Insert Into urun (ad,adet,fiyat) values (@ad,@adet,@fiyat)";
        MySqlCommand cmd=new MySqlCommand(query,conn);
        cmd.Parameters.AddWithValue("@ad",ad);
        cmd.Parameters.AddWithValue("@adet",adet);
        cmd.Parameters.AddWithValue("@fiyat",fiyat);
        cmd.ExecuteNonQuery();
        conn.Close();
        GetAll();
    }

    public void Delete(int uID)
    {
        Baglan();
        string query="Delete from urun where urunid=@uId";
        MySqlCommand cmd=new MySqlCommand(query,conn);
        cmd.Parameters.AddWithValue("@uId",uID);
        cmd.ExecuteNonQuery();
        conn.Close();
        GetAll();
    }

    public void Update(int uID)
    {
        Console.Write("Adet:");
        int adet=int.Parse(Console.ReadLine());
        Console.Write("Fiyat:");
        int fiyat=int.Parse(Console.ReadLine());
        Baglan();
        string query="Update urun Set adet=@adet,fiyat=@fiyat where urunid=@uId";
        MySqlCommand cmd=new MySqlCommand(query,conn);
        cmd.Parameters.AddWithValue("@adet",adet);
        cmd.Parameters.AddWithValue("@fiyat",fiyat);
        cmd.Parameters.AddWithValue("@uId",uID);
        cmd.ExecuteNonQuery();
        conn.Close();

        GetAll();

    }
}