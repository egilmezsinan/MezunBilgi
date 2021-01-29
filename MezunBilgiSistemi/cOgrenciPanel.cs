using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MezunBilgiSistemi
{
    public class cOgrenciPanel
    {
        public string Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int MezuniyetYili { get; set; }
        public int PlakaKod { get; set; }
        public string Sirket { get; set; }
        public string Pozisyon { get; set; }
        public string Alan { get; set; }
        public string Email { get; set; }
        public long Telefon { get; set; }
       
        cBaglanti baglanti =new cBaglanti();

        public void KullaniciGetir(string TC)
        {
            SqlCommand getir = new SqlCommand("select * from Mezun where TC=@Tc ", baglanti.Baglanti());
            getir.Parameters.AddWithValue("@Tc", TC);
            SqlDataReader dr = getir.ExecuteReader();

            if (dr.Read())
            {
                Tc= dr["TC"].ToString();
                Ad = dr["Ad"].ToString();
                Soyad = dr["Soyad"].ToString();
                MezuniyetYili = Convert.ToInt32(dr["MezuniyetYılı"]);
                PlakaKod = Convert.ToInt32(dr["PlakaKod"]);
                Sirket = dr["Sirket"].ToString();
                Pozisyon = dr["Pozisyon"].ToString();
                Alan = dr["Alan"].ToString();
                Email = dr["Email"].ToString();
                Telefon = Convert.ToInt64(dr["Telefon"]);

            }

            baglanti.Baglanti().Close();

        }

      

        public void KartGuncelle(string TC)
        {
            SqlCommand ekle = new SqlCommand("exec MezunGuncelle @TC,@PlakaKod,@Sirket,@Pozisyon,@Alan,@Email,@Telefon", baglanti.Baglanti());

            ekle.Parameters.AddWithValue("@TC", TC);
            ekle.Parameters.AddWithValue("@PlakaKod", PlakaKod);
            ekle.Parameters.AddWithValue("@Sirket", Sirket);
            ekle.Parameters.AddWithValue("@Pozisyon", Pozisyon);
            ekle.Parameters.AddWithValue("@Alan", Alan);
            ekle.Parameters.AddWithValue("@Email", Email);
            ekle.Parameters.AddWithValue("@Telefon", Telefon);
            ekle.ExecuteNonQuery();
            baglanti.Baglanti().Close();
        }
    }
}
