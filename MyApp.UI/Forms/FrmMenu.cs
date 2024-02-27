using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyApp.UI.Forms;
using MyApp.UI.Forms.NewSave;
using MyApp.UI.Forms.OldSave;


namespace MyApp.UI.Forms
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btn_NewSave_Click(object sender, EventArgs e)
        {
            FrmNewSave frmNewSave = new FrmNewSave();   
            frmNewSave.ShowDialog();
        }

        private void btn_OldSave_Click(object sender, EventArgs e)
        {
            FrmOldSave frmOldSave = new FrmOldSave();
            frmOldSave.ShowDialog();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            FrmUpdate frmUpdate = new FrmUpdate();
            frmUpdate.ShowDialog();
        }
    }
}
