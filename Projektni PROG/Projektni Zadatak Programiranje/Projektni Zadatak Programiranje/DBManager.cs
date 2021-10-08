using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projektni_Zadatak_Programiranje
{
    public partial class DBManager : Form
    {
        public DBManager()
        {
            InitializeComponent();
        }

        string datasource = "DATA SOURCE = " + System.Environment.CurrentDirectory + Path.DirectorySeparatorChar + "DBDemoFile.db";

        private void BTN_LoadDB_Click(object sender, EventArgs e)
        {
            try
            {
                LSTBX_Users.Items.Clear();
                LSTBX_Passw.Items.Clear();
                DataTable dt = new DataTable();
                using (SQLiteConnection conn = new SQLiteConnection(datasource))
                {
                    string sql = $"SELECT * FROM UserPassTable;";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
                    da.Fill(dt);
                    conn.Close();
                }
                foreach (DataRow a in dt.Rows)
                {
                    LSTBX_Users.Items.Add(a[1].ToString());
                    LSTBX_Passw.Items.Add(a[2].ToString());
                }
            }
            catch
            {
                MessageBox.Show("The DB or the table doesn't exit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTN_AddUsr_Click(object sender, EventArgs e)
        {
            if (TXTB_User.Text != "" && TXTB_Pass.Text != "")
            {

                using (SQLiteConnection con = new SQLiteConnection(datasource))
                {
                    using (SQLiteCommand com = new SQLiteCommand(con))
                    {
                        con.Open();
                        com.CommandText = $"INSERT INTO UserPassTable(user, pass) VALUES ('" + TXTB_User.Text + "', '" + TXTB_Pass.Text + "');";
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                LSTBX_Users.Items.Add(TXTB_User.Text);
                LSTBX_Passw.Items.Add(TXTB_Pass.Text);
                TXTB_Pass.Clear();
                TXTB_User.Clear();
            }
            else
                MessageBox.Show("Username and/or password cannot be empty", "Error", MessageBoxButtons.OK);
        }

        private void LSTBX_Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            LSTBX_Passw.SelectedIndex = LSTBX_Users.SelectedIndex;
        }

        private void BTN_RemUsr_Click(object sender, EventArgs e)
        {
            try
            {
                string usr = LSTBX_Users.SelectedItem.ToString();
                string pas = LSTBX_Passw.SelectedItem.ToString();

                using (SQLiteConnection con = new SQLiteConnection(datasource))
                {
                    using (SQLiteCommand com = new SQLiteCommand(con))
                    {
                        con.Open();
                        com.CommandText = $"DELETE FROM UserPassTable WHERE user = '" + usr + "' AND pass = '" + pas + "';";
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
                LSTBX_Passw.Items.Remove(LSTBX_Passw.SelectedItem);
                LSTBX_Users.Items.Remove(LSTBX_Users.SelectedItem);
            }
            catch
            {
                MessageBox.Show("You must select a user from the users list in order to remove them.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DBManager_Load(object sender, EventArgs e)
        {
            if (!File.Exists(datasource.Substring(13)))
            {
                MessageBox.Show("DataBase does not exist. Create one from the menu above", "Error", MessageBoxButtons.OK);
                createToolStripMenuItem.Enabled = true;
            }
            else
            {
                createToolStripMenuItem.Enabled = false;
            }
            initialPopulateToolStripMenuItem.Enabled = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DBManager V2.1\nCreated by Elmin Softic, 2019", "Info", MessageBoxButtons.OK);
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = @"CREATE TABLE IF NOT EXISTS 'UserPassTable' ('Id' INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, 'user' VARCHAR(25) NOT NULL, 'pass' VARCHAR(25) NOT NULL);";

            SQLiteConnection.CreateFile("DBDemoFile.db");
            using (SQLiteConnection con = new SQLiteConnection(datasource))
            {
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    con.Open();
                    com.CommandText = sql;
                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
            createToolStripMenuItem.Enabled = false;
            initialPopulateToolStripMenuItem.Enabled = true;
        }

        private void initialPopulateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(datasource))
            {
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    con.Open();
                    com.CommandText = $"INSERT INTO UserPassTable(user, pass) VALUES ('admin', 'admin'), ('root', 'root'), ('user1', 'pass1'), ('user', 'user');";
                    com.ExecuteNonQuery();
                    con.Close();
                }
            }
            initialPopulateToolStripMenuItem.Enabled = false;
        }
    }
}
