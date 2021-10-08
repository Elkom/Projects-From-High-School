namespace Projektni_Zadatak_Programiranje
{
    partial class DBManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBManager));
            this.LSTBX_Users = new System.Windows.Forms.ListBox();
            this.LSTBX_Passw = new System.Windows.Forms.ListBox();
            this.LB_Users = new System.Windows.Forms.Label();
            this.LB_Pass = new System.Windows.Forms.Label();
            this.BTN_LoadDB = new System.Windows.Forms.Button();
            this.GB_UserAddCont = new System.Windows.Forms.GroupBox();
            this.BTN_AddUsr = new System.Windows.Forms.Button();
            this.LB_Pss = new System.Windows.Forms.Label();
            this.TXTB_Pass = new System.Windows.Forms.TextBox();
            this.LB_Usr = new System.Windows.Forms.Label();
            this.TXTB_User = new System.Windows.Forms.TextBox();
            this.BTN_RemUsr = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initialPopulateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_UserAddCont.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LSTBX_Users
            // 
            this.LSTBX_Users.FormattingEnabled = true;
            this.LSTBX_Users.Location = new System.Drawing.Point(12, 43);
            this.LSTBX_Users.Name = "LSTBX_Users";
            this.LSTBX_Users.Size = new System.Drawing.Size(171, 251);
            this.LSTBX_Users.TabIndex = 0;
            this.LSTBX_Users.SelectedIndexChanged += new System.EventHandler(this.LSTBX_Users_SelectedIndexChanged);
            // 
            // LSTBX_Passw
            // 
            this.LSTBX_Passw.Enabled = false;
            this.LSTBX_Passw.FormattingEnabled = true;
            this.LSTBX_Passw.Location = new System.Drawing.Point(189, 43);
            this.LSTBX_Passw.Name = "LSTBX_Passw";
            this.LSTBX_Passw.Size = new System.Drawing.Size(171, 251);
            this.LSTBX_Passw.TabIndex = 1;
            // 
            // LB_Users
            // 
            this.LB_Users.AutoSize = true;
            this.LB_Users.Location = new System.Drawing.Point(9, 27);
            this.LB_Users.Name = "LB_Users";
            this.LB_Users.Size = new System.Drawing.Size(37, 13);
            this.LB_Users.TabIndex = 2;
            this.LB_Users.Text = "Users:";
            // 
            // LB_Pass
            // 
            this.LB_Pass.AutoSize = true;
            this.LB_Pass.Location = new System.Drawing.Point(186, 27);
            this.LB_Pass.Name = "LB_Pass";
            this.LB_Pass.Size = new System.Drawing.Size(61, 13);
            this.LB_Pass.TabIndex = 3;
            this.LB_Pass.Text = "Passwords:";
            // 
            // BTN_LoadDB
            // 
            this.BTN_LoadDB.Location = new System.Drawing.Point(366, 43);
            this.BTN_LoadDB.Name = "BTN_LoadDB";
            this.BTN_LoadDB.Size = new System.Drawing.Size(140, 23);
            this.BTN_LoadDB.TabIndex = 4;
            this.BTN_LoadDB.Text = "Load DB";
            this.BTN_LoadDB.UseVisualStyleBackColor = true;
            this.BTN_LoadDB.Click += new System.EventHandler(this.BTN_LoadDB_Click);
            // 
            // GB_UserAddCont
            // 
            this.GB_UserAddCont.Controls.Add(this.BTN_AddUsr);
            this.GB_UserAddCont.Controls.Add(this.LB_Pss);
            this.GB_UserAddCont.Controls.Add(this.TXTB_Pass);
            this.GB_UserAddCont.Controls.Add(this.LB_Usr);
            this.GB_UserAddCont.Controls.Add(this.TXTB_User);
            this.GB_UserAddCont.Location = new System.Drawing.Point(12, 300);
            this.GB_UserAddCont.Name = "GB_UserAddCont";
            this.GB_UserAddCont.Size = new System.Drawing.Size(168, 110);
            this.GB_UserAddCont.TabIndex = 5;
            this.GB_UserAddCont.TabStop = false;
            this.GB_UserAddCont.Text = "Add User";
            // 
            // BTN_AddUsr
            // 
            this.BTN_AddUsr.Location = new System.Drawing.Point(87, 71);
            this.BTN_AddUsr.Name = "BTN_AddUsr";
            this.BTN_AddUsr.Size = new System.Drawing.Size(75, 23);
            this.BTN_AddUsr.TabIndex = 9;
            this.BTN_AddUsr.Text = "Add User";
            this.BTN_AddUsr.UseVisualStyleBackColor = true;
            this.BTN_AddUsr.Click += new System.EventHandler(this.BTN_AddUsr_Click);
            // 
            // LB_Pss
            // 
            this.LB_Pss.AutoSize = true;
            this.LB_Pss.Location = new System.Drawing.Point(6, 48);
            this.LB_Pss.Name = "LB_Pss";
            this.LB_Pss.Size = new System.Drawing.Size(33, 13);
            this.LB_Pss.TabIndex = 7;
            this.LB_Pss.Text = "Pass:";
            // 
            // TXTB_Pass
            // 
            this.TXTB_Pass.Location = new System.Drawing.Point(44, 45);
            this.TXTB_Pass.MaxLength = 25;
            this.TXTB_Pass.Name = "TXTB_Pass";
            this.TXTB_Pass.Size = new System.Drawing.Size(118, 20);
            this.TXTB_Pass.TabIndex = 8;
            // 
            // LB_Usr
            // 
            this.LB_Usr.AutoSize = true;
            this.LB_Usr.Location = new System.Drawing.Point(6, 22);
            this.LB_Usr.Name = "LB_Usr";
            this.LB_Usr.Size = new System.Drawing.Size(32, 13);
            this.LB_Usr.TabIndex = 6;
            this.LB_Usr.Text = "User:";
            // 
            // TXTB_User
            // 
            this.TXTB_User.Location = new System.Drawing.Point(44, 19);
            this.TXTB_User.MaxLength = 25;
            this.TXTB_User.Name = "TXTB_User";
            this.TXTB_User.Size = new System.Drawing.Size(118, 20);
            this.TXTB_User.TabIndex = 6;
            // 
            // BTN_RemUsr
            // 
            this.BTN_RemUsr.Location = new System.Drawing.Point(366, 72);
            this.BTN_RemUsr.Name = "BTN_RemUsr";
            this.BTN_RemUsr.Size = new System.Drawing.Size(140, 23);
            this.BTN_RemUsr.TabIndex = 6;
            this.BTN_RemUsr.Text = "Remove User";
            this.BTN_RemUsr.UseVisualStyleBackColor = true;
            this.BTN_RemUsr.Click += new System.EventHandler(this.BTN_RemUsr_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.initialPopulateToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // initialPopulateToolStripMenuItem
            // 
            this.initialPopulateToolStripMenuItem.Name = "initialPopulateToolStripMenuItem";
            this.initialPopulateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.initialPopulateToolStripMenuItem.Text = "Initial Populate";
            this.initialPopulateToolStripMenuItem.Click += new System.EventHandler(this.initialPopulateToolStripMenuItem_Click);
            // 
            // DBManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 422);
            this.Controls.Add(this.BTN_RemUsr);
            this.Controls.Add(this.GB_UserAddCont);
            this.Controls.Add(this.BTN_LoadDB);
            this.Controls.Add(this.LB_Pass);
            this.Controls.Add(this.LB_Users);
            this.Controls.Add(this.LSTBX_Passw);
            this.Controls.Add(this.LSTBX_Users);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBManager";
            this.Load += new System.EventHandler(this.DBManager_Load);
            this.GB_UserAddCont.ResumeLayout(false);
            this.GB_UserAddCont.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LSTBX_Users;
        private System.Windows.Forms.ListBox LSTBX_Passw;
        private System.Windows.Forms.Label LB_Users;
        private System.Windows.Forms.Label LB_Pass;
        private System.Windows.Forms.Button BTN_LoadDB;
        private System.Windows.Forms.GroupBox GB_UserAddCont;
        private System.Windows.Forms.Button BTN_AddUsr;
        private System.Windows.Forms.Label LB_Pss;
        private System.Windows.Forms.TextBox TXTB_Pass;
        private System.Windows.Forms.Label LB_Usr;
        private System.Windows.Forms.TextBox TXTB_User;
        private System.Windows.Forms.Button BTN_RemUsr;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initialPopulateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}