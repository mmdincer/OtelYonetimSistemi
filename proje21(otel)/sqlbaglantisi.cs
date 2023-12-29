using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje21_otel_
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=MMD\\SQLEXPRESS;Initial Catalog=Otel;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
