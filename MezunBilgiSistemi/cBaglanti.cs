using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MezunBilgiSistemi
{
   public class cBaglanti
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-BKRH9DR;Initial Catalog=MezunBilgiSistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
