using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Msg
{
    class veritabani
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader oku;

        public veritabani()
        {
            baglanti = new SqlConnection("Data Source=EBRU\\SQLEXPRESS;Initial Catalog=MSG;Integrated Security=True");   
        }




        int girisId;
        public int Giris(string kAd, string sifre)
        {
            baglanti.Close();    
            komut = new SqlCommand("Select * from Kisiler where kullanici_ad='" + kAd + "' and sifre='" + sifre + "'", baglanti);
            baglanti.Open();
            oku = komut.ExecuteReader();    
            if (oku.Read()==true)
            {
                if (sifre == oku["sifre"].ToString().Trim())
                {
                    girisId = Convert.ToInt32(oku["id"].ToString());
                    MessageBox.Show("giren kişi id : "+girisId);
                    return girisId; 
                }
                else
                {
                    MessageBox.Show("Şifrenizi tekrar deneyin !", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                }  
            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol edin !","Erorr",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            baglanti.Close();
            return 0;
        }





        public int RehberKayitEkleKontrol(string ad, string soyad,string tel)
        {
            baglanti.Close();
            komut = new SqlCommand("Select * from Kisiler where ad='" + ad.Trim() + "' and soyad='" + soyad.Trim() + "' and tel='" + tel + "'", baglanti);
            baglanti.Open();
            oku = komut.ExecuteReader();
            if (oku.Read() == true)
            {
                    return 1;
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı !", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
            baglanti.Dispose();
            return 0;
        }





        public int id = 0;
        public int idbul()
        {
            baglanti.Close();
            baglanti.Open();

            komut = new SqlCommand("Select id From Kisiler where tel='" + frmKullaniciEkleDuzenle.gidenTel.ToString() + "'", baglanti);
            oku = komut.ExecuteReader();
            if (oku.Read() == true)
            {
                id = Convert.ToInt32(oku["id"].ToString());
                return id;
            }
            else
            {
            }
            baglanti.Close();
            return 0;

        }






        public int secID = 0;
        public int secileninID(string tel)
        {
            baglanti.Close();
            baglanti.Open();

            komut = new SqlCommand("Select id From Kisiler where tel='" + tel + "'", baglanti);
            oku = komut.ExecuteReader();
            if (oku.Read() == true)
            {
                id = Convert.ToInt32(oku["id"].ToString());
                return id;
            }
            else
            {
            }
            baglanti.Close();
            return 0;

        }




        public void RehberdekiKaydıTabloyaEkleme()
        {
            try
            {
                if (id==0)
                {                   
                }
                else
                {
                    baglanti.Close();
                    baglanti.Open();
                    komut = new SqlCommand("insert into Rehber(kullanici_id,kisi_id) values(@kullanici_id, @kisi_id)", baglanti);
                    komut.Parameters.AddWithValue("@kullanici_id", girisId);
                    komut.Parameters.AddWithValue("kisi_id", id);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }





        public void RehberdeSecilenKaydiSil(string tel)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                komut = new SqlCommand("Delete from Rehber where kisi_id=(Select id from Kisiler where tel='"+tel+"')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }





        public void YeniKullaniciEkleme(string ad, string soyad, string kullaniciAd, string tel, string Eposta, string sifre)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                komut = new SqlCommand("insert into Kisiler(ad,soyad,kullanici_ad,tel,eposta,sifre) values(@ad, @soyad,@kullanici_ad,@tel,@eposta,@sifre)", baglanti);

                komut.Parameters.AddWithValue("@ad", ad.Trim());
                komut.Parameters.AddWithValue("@soyad", soyad.Trim().ToUpper());
                komut.Parameters.AddWithValue("@kullanici_ad", kullaniciAd.Trim());
                komut.Parameters.AddWithValue("@tel", tel);
                komut.Parameters.AddWithValue("@eposta", Eposta.Trim());
                komut.Parameters.AddWithValue("@sifre", sifre.Trim());

                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }




        string isim;
        public string ChatSayfasiİsimGetirme(string tel)
        {
            baglanti.Close();
            baglanti.Open();

            komut = new SqlCommand("Select ad,soyad From Kisiler where tel='" + tel + "'", baglanti);
            oku = komut.ExecuteReader();
            if (oku.Read() == true)
            {
                isim =oku["ad"].ToString()+" "+ oku["soyad"].ToString();
                return isim;
            }
            else
            {
            }
            baglanti.Close();
            return null;

        }



        int AcilanKisiID = 0;
        public int ChatSayfasındaAcilanKisiID(string tel)
        {
            baglanti.Close();
            baglanti.Open();

            komut = new SqlCommand("Select id From Kisiler where tel='" + tel + "'", baglanti);
            oku = komut.ExecuteReader();
            if (oku.Read() == true)
            {
                AcilanKisiID = Convert.ToInt32(oku["id"].ToString());
                return AcilanKisiID;
            }
            else
            {
            }
            baglanti.Close();
            return 0;

        }




        public void KullaniciGuncelleme(int ID, string ad, string soyad, string kullaniciAd, string tel, string Eposta, string sifre)
        {
            try
            {
                baglanti.Close();
                baglanti.Open();
                string sql = "update Kisiler set ad='"+ad+"',soyad='"+soyad+"',kullanici_ad='"+kullaniciAd+"',tel='"+tel+"',eposta='"+Eposta+"',sifre='"+sifre+"' where id="+ID+"";
                komut = new SqlCommand(sql, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }


    }
}
