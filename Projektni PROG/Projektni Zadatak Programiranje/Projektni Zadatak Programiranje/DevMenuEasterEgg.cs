using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projektni_Zadatak_Programiranje
{
    public partial class DevMenuEasterEgg : Form
    {
        Welcome_Form data;
        public DevMenuEasterEgg(Welcome_Form f)
        {
            InitializeComponent();
            data = f;
        }

        private void DevMenuEasterEgg_Load(object sender, EventArgs e)
        {
            if (data.MegaMenu) CHB_MMD_EN.Checked = true;
            else CHB_MMD_EN.Checked = false;
            RTB_ProgramLocation.Text = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Apply_Click(object sender, EventArgs e)
        {
            data.MegaMenu = (CHB_MMD_EN.Checked) ? true : false;
            Close();
        }

        private void BTN_DBManager_Click(object sender, EventArgs e)
        {
            DBManager dbm = new DBManager();
            dbm.Show();
            dbm.Focus();
        }
    }
}
