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
using MyApp.BusinessLayer;
using MyApp.TypeLayer;
using MyApp.UI;

namespace MyApp.UI.Forms
{
    public partial class FrmUpdate : Form
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            FillCombobox();
        }

        void FillCombobox()
        {
            Cls_OldSave cls_OldSave = new Cls_OldSave();
            SqlDataReader sdr = cls_OldSave.SelectByAppName();

            while (sdr.Read())
            {
                cmb_Degistirilecek.Items.Add(sdr[1]);
            }
        }

        private void cmb_Degistirilecek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_FormUpdate_Click(object sender, EventArgs e)
        {
            Cls_Update cls_Update = new Cls_Update();

            cls_Update.AppName = cmb_Degistirilecek.SelectedItem.ToString();
            cls_Update.UserName = txt_UserName.Text;
            cls_Update.Password = txt_Password.Text;
            cls_Update.UpdateData();

            bool result = cls_Update.UpdateData();
            if (result)
            {
                MessageBox.Show(Common_Messages.Common_Messages_Method(true));
            }
            else
            {
                MessageBox.Show(Common_Messages.Common_Messages_Method(false));
            }
            clear();
        }
        void clear()
        {
            txt_UserName.Text = txt_Password.Text = "";
            cmb_Degistirilecek.SelectedIndex = -1;
        }

    

      
    }
}
