using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Proje
{
    internal class sqlBaglantı
    {
        public SqlConnection baglantı()
        {

           SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-H2V6Q7S\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
           baglan.Open();
           return baglan;
        }


    }

}
