using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projektni_Zadatak_Programiranje
{
    public partial class Welcome_Form : Form
    {
        public bool MegaMenu = false;

        public Welcome_Form()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu_Form wf = new MainMenu_Form(MegaMenu);
            wf.Show();
            wf.Focus();
            this.Hide();
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to exit the application?", "End?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                MessageBox.Show("Thanks for using our program", "Notice", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void Welcome_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult d = MessageBox.Show("Are you sure you want to exit the application?", "End?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    MessageBox.Show("Thanks for using our program", "Notice", MessageBoxButtons.OK);
                    Application.Exit();
                }
                if (d == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void Welcome_Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '~')
            {
                DevMenuEasterEgg dmee = new DevMenuEasterEgg(this);
                dmee.Show();
                dmee.Focus();
            }
        }
    }
}
