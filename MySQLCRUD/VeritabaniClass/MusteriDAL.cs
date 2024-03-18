using MySql.Data;//MYSQL komutlarını projede kullanmamızı saglayan kütüphane
using MySql.Data.MySqlClient;

class MusteriDAL{

    string connectionString;//VeriTabanının bulundugu adresi içinde barındıracak.

    MySqlConnection conn;//Veritabanı ile haberlemeyi saglayacak degişkenim.

    public MusteriDAL(){//KURUCU METOT

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
        string query="select * from musteriler";

        MySqlCommand cmd=new MySqlCommand(query,conn);
        
        MySqlDataReader dr=cmd.ExecuteReader();

        while(dr.Read())
        {
            Console.WriteLine(dr["musteriID"].ToString()
            +" "+dr["ad"].ToString()+" "
            +dr["soyad"].ToString());
        }
        dr.Close();
        conn.Close();
    }

    public void GetName(string ad)
    {
        Baglan();
        string query="Select * from musteriler where ad=@ad";
        MySqlCommand cmd=new MySqlCommand(query,conn);
        cmd.Parameters.AddWithValue("@ad",ad);
        MySqlDataReader dr=cmd.ExecuteReader();

        while(dr.Read())
        {
            Console.WriteLine(dr["ad"].ToString()+" "+dr["soyad"].ToString());
        }

        dr.Close();
        conn.Close();
    }

    public void GetNameLike(string a)
    {
        Baglan();
        string query="Select * from musteriler where ad  Like @a";
        MySqlCommand cmd=new MySqlCommand(query,conn);
        cmd.Parameters.AddWithValue("@a",$"%{a}%");
        MySqlDataReader dr=cmd.ExecuteReader();

        while(dr.Read())
        {
            Console.WriteLine(dr["ad"].ToString()+" "+dr["soyad"].ToString());
        }

        dr.Close();
        conn.Close();
    }

    public void Insert()
    {
        Console.Write("Ad:");
        string ad=Console.ReadLine();
        Console.Write("Soyad:");
        string soyad=Console.ReadLine();
        Baglan();
        string query="Insert Into musteriler (ad,soyad) values (@ad,@soyad)";
        MySqlCommand cmd=new MySqlCommand(query,conn);
        cmd.Parameters.AddWithValue("@ad",ad);
        cmd.Parameters.AddWithValue("@soyad",soyad);
        cmd.ExecuteNonQuery();
        conn.Close();
        GetAll();
    }

    public void Delete(int mId)
    {
        Baglan();
        string query="Delete from musteriler where musteriID=@mId";
        MySqlCommand cmd=new MySqlCommand(query,conn);
        cmd.Parameters.AddWithValue("@mId",mId);
        cmd.ExecuteNonQuery();
        conn.Close();
        GetAll();
    }

    public void Update(int mId)
    {
        Console.Write("Soyad:");
        string soyad=Console.ReadLine();
        Baglan();
        string query="Update musteriler Set soyad=@soyad where musteriID=@mId";
        MySqlCommand cmd=new MySqlCommand(query,conn);
        cmd.Parameters.AddWithValue("@soyad",soyad);
        cmd.Parameters.AddWithValue("@mId",mId);
        cmd.ExecuteNonQuery();
        conn.Close();

        GetAll();

    }
}