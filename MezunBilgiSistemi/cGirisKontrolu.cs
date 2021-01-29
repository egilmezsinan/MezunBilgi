using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace MezunBilgiSistemi
{
   public class cGirisKontrolu
    {
        public Boolean KullaniciTuru { get; set; }
        public string TC { get; set; }
        cBaglanti baglanti = new cBaglanti();
       
        public bool KullaniciDogrula(string Tc, string sifre)
        {

            SqlCommand komut = new SqlCommand("Select * From Login where TC=@Tc and Password = @sifre", baglanti.Baglanti());
            komut.Parameters.AddWithValue("@TC", Tc);
            komut.Parameters.AddWithValue("@sifre", sifre);
            SqlDataReader dr1 = komut.ExecuteReader();
            if (dr1.Read())
            {

                KullaniciTuru = Convert.ToBoolean(dr1["KullaniciTur"]);
                TC = dr1["TC"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
