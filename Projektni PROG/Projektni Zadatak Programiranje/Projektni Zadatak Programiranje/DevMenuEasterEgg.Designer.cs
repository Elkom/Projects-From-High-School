namespace Projektni_Zadatak_Programiranje
{
    partial class DevMenuEasterEgg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevMenuEasterEgg));
            this.RTB_Welcome = new System.Windows.Forms.RichTextBox();
            this.LB_MMD = new System.Windows.Forms.Label();
            this.CHB_MMD_EN = new System.Windows.Forms.CheckBox();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Apply = new System.Windows.Forms.Button();
            this.BTN_DBManager = new System.Windows.Forms.Button();
            this.LB_InfoLocationLabel = new System.Windows.Forms.Label();
            this.RTB_ProgramLocation = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RTB_Welcome
            // 
            this.RTB_Welcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTB_Welcome.Location = new System.Drawing.Point(12, 12);
            this.RTB_Welcome.Name = "RTB_Welcome";
            this.RTB_Welcome.ReadOnly = true;
            this.RTB_Welcome.Size = new System.Drawing.Size(382, 70);
            this.RTB_Welcome.TabIndex = 0;
            this.RTB_Welcome.TabStop = false;
            this.RTB_Welcome.Text = "This is a little easter egg menu I added for debug and other purposes such as hav" +
    "ing something hidden in the program\n\n-Dev";
            // 
            // LB_MMD
            // 
            this.LB_MMD.AutoSize = true;
            this.LB_MMD.Location = new System.Drawing.Point(15, 89);
            this.LB_MMD.Name = "LB_MMD";
            this.LB_MMD.Size = new System.Drawing.Size(110, 13);
            this.LB_MMD.TabIndex = 0;
            this.LB_MMD.Text = "Mega Menu for Demo";
            // 
            // CHB_MMD_EN
            // 
            this.CHB_MMD_EN.AutoSize = true;
            this.CHB_MMD_EN.Location = new System.Drawing.Point(131, 88);
            this.CHB_MMD_EN.Name = "CHB_MMD_EN";
            this.CHB_MMD_EN.Size = new System.Drawing.Size(65, 17);
            this.CHB_MMD_EN.TabIndex = 1;
            this.CHB_MMD_EN.Text = "Enabled";
            this.CHB_MMD_EN.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(319, 343);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 5;
            this.BTN_Cancel.Text = "&Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Apply
            // 
            this.BTN_Apply.Location = new System.Drawing.Point(213, 343);
            this.BTN_Apply.Name = "BTN_Apply";
            this.BTN_Apply.Size = new System.Drawing.Size(100, 23);
            this.BTN_Apply.TabIndex = 4;
            this.BTN_Apply.Text = "&Apply and close";
            this.BTN_Apply.UseVisualStyleBackColor = true;
            this.BTN_Apply.Click += new System.EventHandler(this.BTN_Apply_Click);
            // 
            // BTN_DBManager
            // 
            this.BTN_DBManager.Location = new System.Drawing.Point(12, 343);
            this.BTN_DBManager.Name = "BTN_DBManager";
            this.BTN_DBManager.Size = new System.Drawing.Size(75, 23);
            this.BTN_DBManager.TabIndex = 6;
            this.BTN_DBManager.Text = "DB Manager";
            this.BTN_DBManager.UseVisualStyleBackColor = true;
            this.BTN_DBManager.Click += new System.EventHandler(this.BTN_DBManager_Click);
            // 
            // LB_InfoLocationLabel
            // 
            this.LB_InfoLocationLabel.AutoSize = true;
            this.LB_InfoLocationLabel.Location = new System.Drawing.Point(15, 262);
            this.LB_InfoLocationLabel.Name = "LB_InfoLocationLabel";
            this.LB_InfoLocationLabel.Size = new System.Drawing.Size(89, 13);
            this.LB_InfoLocationLabel.TabIndex = 7;
            this.LB_InfoLocationLabel.Text = "Program location:";
            // 
            // RTB_ProgramLocation
            // 
            this.RTB_ProgramLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTB_ProgramLocation.Location = new System.Drawing.Point(12, 278);
            this.RTB_ProgramLocation.Name = "RTB_ProgramLocation";
            this.RTB_ProgramLocation.ReadOnly = true;
            this.RTB_ProgramLocation.Size = new System.Drawing.Size(382, 45);
            this.RTB_ProgramLocation.TabIndex = 9;
            this.RTB_ProgramLocation.TabStop = false;
            this.RTB_ProgramLocation.Text = "";
            // 
            // DevMenuEasterEgg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 378);
            this.Controls.Add(this.RTB_ProgramLocation);
            this.Controls.Add(this.BTN_DBManager);
            this.Controls.Add(this.LB_InfoLocationLabel);
            this.Controls.Add(this.BTN_Apply);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.CHB_MMD_EN);
            this.Controls.Add(this.LB_MMD);
            this.Controls.Add(this.RTB_Welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DevMenuEasterEgg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Developer Menu - Easter Egg";
            this.Load += new System.EventHandler(this.DevMenuEasterEgg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Welcome;
        private System.Windows.Forms.Label LB_MMD;
        private System.Windows.Forms.CheckBox CHB_MMD_EN;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Apply;
        private System.Windows.Forms.Button BTN_DBManager;
        private System.Windows.Forms.Label LB_InfoLocationLabel;
        private System.Windows.Forms.RichTextBox RTB_ProgramLocation;
    }
}