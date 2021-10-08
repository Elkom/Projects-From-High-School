using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace Projektni_Zadatak_Programiranje
{
    public partial class MainMenu_Form : Form
    {
        bool[] binar = { false, false, false };
        bool MegaMenu = false;
        Random rnd = new Random();
        bool LBDemoBold = false;
        bool LBDemoItalic = false;

        public MainMenu_Form(bool MM)
        {
            InitializeComponent();
            MegaMenu = MM;
        }

        private void MainMenu_Form_Load(object sender, EventArgs e)
        {
            HideWall.BringToFront();
            HideWall.Location = new Point(11, 27);
            LB_StartInstruction.Show();
            LB_LDText.Hide();
            progressBar1.Hide();
            megaMenuToolStripMenuItem.Visible = MegaMenu;
            RB_Sel1.Select();
            DTP_Time.Value = DateTime.Now;
            PctBox_Demo.ImageLocation = Environment.CurrentDirectory + Path.DirectorySeparatorChar + "Demo Files" + Path.DirectorySeparatorChar + "DemoPicture.png";
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program made by Elmin Softic\nVersion: 1.15\nReleased: 2019", "About");
        }

        private void MainMenu_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                foreach (Form f in Application.OpenForms)
                    if (f.Text == "Visual Studio 2017 Demo")
                    {
                        (f as Welcome_Form).Show();
                        break;
                    }
            }
            catch
            {
                //If this error appears the user has bigger problems to worry about...
                MessageBox.Show("This error is impossible, if you see it, seek help", "An Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //****Button Demo****//
        //Single function
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This was just a button that has an event that shows a message box.\nThe button is the most simple and commonly used object", "Button", MessageBoxButtons.OK);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LB_StartInstruction.Hide();
            LB_LDText.Show();
            progressBar1.Show();
            timer1.Start();
        }

        internal void ProgressBarStop()
        {
            timer1.Stop();
            startToolStripMenuItem.Enabled = false;
            HideWall.Hide();
            MessageBox.Show("Loading of demo done.", "Loading", MessageBoxButtons.OK);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(4);
            if (progressBar1.Value >= progressBar1.Maximum - 1)
                ProgressBarStop();
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Do you really want to end the demo?", "End?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }

        }

        //****MegaMenu options****//
        //Multiple options
        private void skipLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideWall.Hide();
            startToolStripMenuItem.Enabled = false;
        }

        private void openDBManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBManager dbm = new DBManager();
            dbm.Show();
            dbm.Focus();
        }

        //****RadioButton Demo****//
        //Multiple functions
        private void RB_Sel1_CheckedChanged(object sender, EventArgs e)
        {
            RadioColor.BackColor = System.Drawing.Color.Red;
        }

        private void RB_Sel2_CheckedChanged(object sender, EventArgs e)
        {
            RadioColor.BackColor = System.Drawing.Color.Green;
        }

        private void RB_Sel3_CheckedChanged(object sender, EventArgs e)
        {
            RadioColor.BackColor = System.Drawing.Color.Blue;
        }

        //****CheckBox Demo****//
        //Multiple functions
        private void updateBinary()
        {
            string bin = "";
            int dec = 0;
            int i = 0;
            foreach (bool b in binar)
            {
                bin += (b) ? "1" : "0"; //if else for adding 1 or 0 to a string
                dec |= Convert.ToInt16(b) << i;
                i++;
            }
            char[] bn = bin.ToCharArray();
            Array.Reverse(bn);
            bin = new string(bn);
            LB_CHBBin.Text = bin;
            LB_CHBDec.Text = dec.ToString();
        }

        private void CHB_Bit0_CheckedChanged(object sender, EventArgs e)
        {
            binar[0] ^= true;
            updateBinary();
        }

        private void CHB_Bit1_CheckedChanged(object sender, EventArgs e)
        {
            binar[1] ^= true;
            updateBinary();
        }

        private void CHB_Bit2_CheckedChanged(object sender, EventArgs e)
        {
            binar[2] ^= true;
            updateBinary();
        }

        //****Label Demo****//
        //Multiple functions
        private void BTN_LabelColor_Click(object sender, EventArgs e)
        {
            LB_LabelDemo.ForeColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void CHB_LabelBold_CheckedChanged(object sender, EventArgs e)
        {
            Font f1, f2;
            if (LBDemoItalic)
            {
                f1 = new Font(LB_LabelDemo.Font, FontStyle.Italic | FontStyle.Bold);
                f2 = new Font(LB_LabelDemo.Font, FontStyle.Regular | FontStyle.Italic);
            }
            else
            {
                f1 = new Font(LB_LabelDemo.Font, FontStyle.Bold);
                f2 = new Font(LB_LabelDemo.Font, FontStyle.Regular);
            }
            LBDemoBold ^= true;
            LB_LabelDemo.Font = (LBDemoBold) ? f1 : f2;
        }

        private void CHB_LabelItalic_CheckedChanged(object sender, EventArgs e)
        {
            Font f1, f2;
            if (LBDemoBold)
            {
                f1 = new Font(LB_LabelDemo.Font, FontStyle.Italic | FontStyle.Bold);
                f2 = new Font(LB_LabelDemo.Font, FontStyle.Regular | FontStyle.Bold);
            }
            else
            {
                f1 = new Font(LB_LabelDemo.Font, FontStyle.Italic);
                f2 = new Font(LB_LabelDemo.Font, FontStyle.Regular);
            }
            LBDemoItalic ^= true;
            LB_LabelDemo.Font = (LBDemoItalic) ? f1 : f2;
        }

        private void LLB_LinkLabelDemo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://example.com");
        }

        //****TextBox Demo****//
        private void BTN_Login_Click(object sender, EventArgs e)
        {
            string usr = TXB_User.Text;
            string pas = TXB_Pass.Text;
            string datasource = "DATA SOURCE = " + System.Environment.CurrentDirectory + Path.DirectorySeparatorChar + "DBDemoFile.db";
            if (File.Exists(datasource.Substring(13)))
            {
                string ps;
                using(SQLiteConnection conn = new SQLiteConnection(datasource))
                {
                    string qry = @"SELECT pass FROM UserPassTable WHERE user = '" + usr + "';";
                    using (SQLiteCommand com = new SQLiteCommand(qry, conn))
                    {
                        try
                        {
                            conn.Open();
                            using (SQLiteDataReader rdr = com.ExecuteReader())
                            {
                                rdr.Read();
                                ps = rdr.GetString(rdr.GetOrdinal("pass"));
                                if (ps == pas)
                                    MessageBox.Show("User logged in", "Login successful", MessageBoxButtons.OK);
                                else
                                    MessageBox.Show("Password incorrect", "Login failed", MessageBoxButtons.OK);
                            }
                            conn.Close();
                        }
                        catch
                        {
                            MessageBox.Show("User does not exist", "Error", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("The database does not exist. Create and populate it using the DB Manager from the dev menu.", "Error", MessageBoxButtons.OK);
            }
        }

        //****ListBox Demo****//
        //Multiple functions
        private void BTN_IdemAdd_Click(object sender, EventArgs e)
        {
            LSTB_Items.Items.Add(TXB_ItemAdd.Text);
            TXB_ItemAdd.Clear();
            TXB_ItemAdd.Focus();
        }

        private void BTN_ItemRemove_Click(object sender, EventArgs e)
        {
            try
            {
                LSTB_Items.Items.Remove(LSTB_Items.SelectedItem);
                LSTB_Items.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Item not selected.\nSelect an item from the listbox by clicking on it.", "Error", MessageBoxButtons.OK);
            }
        }

        private void BTN_SelectItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("You have selected: " + LSTB_Items.SelectedItem, "Item Selection", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Item not selected.\nSelect an item from the listbox by clicking on it.", "Error", MessageBoxButtons.OK);
            }
        }

        //****DateTime Picker Demo****//
        //Multiple functions
        DateTime time;
        private void BTN_AlarmSet_Click(object sender, EventArgs e)
        {
            time = new DateTime();
            time = DTP_Time.Value;
            if (time < DateTime.Now)
                MessageBox.Show("Time in the past. Please select a future time.", "Error", MessageBoxButtons.OK);
            else
            {
                timer2.Start();
                MessageBox.Show("Alarm set", "Alarm", MessageBoxButtons.OK);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (time < DateTime.Now)
            {
                timer2.Stop();
                MessageBox.Show("Alarm is ringing.\nIt is " + DateTime.Now.ToLongTimeString(), "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //****Calendar Demo****//
        //Single function
        private void BTN_CalendarDemo_Click(object sender, EventArgs e)
        {
            TimeSpan times = MonCal_Demo.SelectionEnd - MonCal_Demo.SelectionStart;
            if (times.Days < 1)
            {
                MessageBox.Show("Select the start\nPress and hold the Shift key and select the end", "Error");
                return;
            }
            MessageBox.Show("You have selected " + times.Days.ToString() + " days.\nStart day: " +
                            MonCal_Demo.SelectionStart.ToShortDateString() + "\nEnd day:" +
                            MonCal_Demo.SelectionEnd.ToShortDateString(), "Days", MessageBoxButtons.OK);
        }
        
        //****Save and Open File Demo****//
        //Multiple functions
        private void BTN_SaveFile_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = saveFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
                RTB_TextFileSODemo.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void BTN_OpenFile_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Opening a file will delete the current text in the box. Proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(d == DialogResult.Yes)
            {
                d = openFileDialog1.ShowDialog();
                if (d == DialogResult.OK)
                {
                    RTB_TextFileSODemo.Clear();
                    RTB_TextFileSODemo.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        //****Color Dialog Demo****//
        //Single function
        private void BTN_ColorDemo_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                GB_DialogColorDemo.BackColor = colorDialog1.Color;
        }

        //****Font Dialog Demo****//
        //Single function
        private void BTN_ChangeFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                RTB_FontChange.Font = fontDialog1.Font;
        }

        //****Track Bar Demo****//
        //Single function
        private void TrackBar_SliderDemo_Scroll(object sender, EventArgs e)
        {
            LB_ValueSliderDemo.Text = TrackBar_SliderDemo.Value.ToString();
        }

        //****Progress Bar Demo****//
        //Multiple functions
        private void BTN_IncrProgress_Click(object sender, EventArgs e)
        {
            ProgBar_Generic.Increment(5);
        }

        private void BTN_DecrProgressBar_Click(object sender, EventArgs e)
        {
            ProgBar_Generic.Increment(-5);
        }

        //****ComboBox Demo****//
        //Single function
        private void BTN_Order_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order placed.\nYour order: " + CMB_Food.SelectedItem.ToString(), "Order", MessageBoxButtons.OK);
        }
    }
}
