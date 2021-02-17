using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace eczsistemi
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-C6I80RT\\SQLEXPRESS;Initial Catalog=EczSistemProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }


    
    

    
}
