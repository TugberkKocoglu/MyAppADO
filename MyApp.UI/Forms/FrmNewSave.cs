using MyApp.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyApp.TypeLayer;

namespace MyApp.UI.Forms.NewSave
{
    public partial class FrmNewSave : Form
    {
        public FrmNewSave()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool result = Cls_NewSave.NewSave(txt_AppName.Text, txt_UserName.Text, txt_Password.Text);
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
            txt_AppName.Text = txt_UserName.Text = txt_Password.Text = "";
        }
    }
}
