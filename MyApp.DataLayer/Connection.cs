using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.DataLayer
{
    public class Connection
    {
        public static SqlConnection baglanti
        {
            get
            {
                SqlConnection sqlcon=new SqlConnection
                    ("Server=DESKTOP-TCALSD6;Trusted_Connection=True;Database=Application;");
                return sqlcon;
            }
        }
    }
}
