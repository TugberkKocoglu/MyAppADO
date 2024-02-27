using MyApp.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.BusinessLayer
{
    public class Cls_NewSave
    {
        public static bool NewSave(string AppName, string UserName, string Password)
        {
			try
			{
				SqlConnection sqlcon = Connection.baglanti;
				SqlCommand sqlcmd = new SqlCommand("insert into Tbl_App (AppName,UserName,Password) values(@AppName,@UserName,@Password)", sqlcon);
				sqlcmd.Parameters.AddWithValue("@AppName", AppName);
                sqlcmd.Parameters.AddWithValue("@UserName", UserName);
                sqlcmd.Parameters.AddWithValue("@Password", Password);
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
