using MyApp.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.BusinessLayer
{
    public class Cls_Update
    {
        public string AppName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
        public  bool UpdateData()
        {
			
			

			try
			{
				SqlConnection sqlcon = Connection.baglanti;
				SqlCommand sqlcmd = new SqlCommand("sp_UpdateSaves",sqlcon);
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;

                sqlcmd.Parameters.AddWithValue("@AppName",AppName);
                sqlcmd.Parameters.AddWithValue("@UserName",UserName);
				sqlcmd.Parameters.AddWithValue("@Password",Password);
				
				sqlcon.Open();
				sqlcmd.ExecuteNonQuery();
				sqlcon.Close();

                return true;
			}
			catch (Exception)
			{
				return false;
				
				
			}

			
        }
    }
}
