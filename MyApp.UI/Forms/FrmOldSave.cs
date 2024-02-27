using MyApp.BusinessLayer;
using MyApp.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp.UI.Forms.OldSave
{
    public partial class FrmOldSave : Form
    {
        public FrmOldSave()
        {
            InitializeComponent();
        }

        private void FrmOldSave_Load(object sender, EventArgs e)
        {
            FillCombobox();
            
        }

        void FillCombobox()
        {
            Cls_OldSave cls_OldSave = new Cls_OldSave();
            SqlDataReader sdr = cls_OldSave.SelectByAppName();

            while (sdr.Read())
            {
                cmb_App.Items.Add(sdr[1]);
            }
        }

        void ChangeLabel()
        {
            
            SqlConnection sqlcon = Connection.baglanti;
            SqlCommand cmd = new SqlCommand("select UserName,Password from Tbl_App where AppName = '" + cmb_App.Text + "'", sqlcon);
            sqlcon.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                
                lbl_UserName.Text = sdr[0].ToString();
                lbl_Password.Text = sdr[1].ToString();
            }
        }


        private void cmb_App_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeLabel();
        }
    }
}
