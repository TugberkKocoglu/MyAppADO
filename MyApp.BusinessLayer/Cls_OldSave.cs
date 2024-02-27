using MyApp.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.BusinessLayer
{
    public class Cls_OldSave
    {
        public SqlDataReader SelectByAppName()
        {
			try
			{
				SqlConnection sqlcon = Connection.baglanti;
				SqlCommand sqlcmd = new SqlCommand("select * from Tbl_App",sqlcon);
				sqlcon.Open();

				SqlDataReader sdr=sqlcmd.ExecuteReader();
				return sdr;
			}
			catch (Exception)
			{
				return null;
				
			}
        }
    }
}
