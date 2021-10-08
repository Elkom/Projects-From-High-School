namespace Serial8bitsSTM32
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.BTN_ClearConsole = new System.Windows.Forms.Button();
            this.RTB_Console = new System.Windows.Forms.RichTextBox();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_ClearConsole
            // 
            this.BTN_ClearConsole.Location = new System.Drawing.Point(12, 156);
            this.BTN_ClearConsole.Name = "BTN_ClearConsole";
            this.BTN_ClearConsole.Size = new System.Drawing.Size(75, 23);
            this.BTN_ClearConsole.TabIndex = 6;
            this.BTN_ClearConsole.Text = "Clear";
            this.BTN_ClearConsole.UseVisualStyleBackColor = true;
            this.BTN_ClearConsole.Click += new System.EventHandler(this.BTN_ClearConsole_Click);
            // 
            // RTB_Console
            // 
            this.RTB_Console.Location = new System.Drawing.Point(12, 12);
            this.RTB_Console.Name = "RTB_Console";
            this.RTB_Console.ReadOnly = true;
            this.RTB_Console.Size = new System.Drawing.Size(291, 138);
            this.RTB_Console.TabIndex = 5;
            this.RTB_Console.Text = "";
            // 
            // BTN_Close
            // 
            this.BTN_Close.Location = new System.Drawing.Point(228, 156);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(75, 23);
            this.BTN_Close.TabIndex = 7;
            this.BTN_Close.Text = "Close";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 189);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.BTN_ClearConsole);
            this.Controls.Add(this.RTB_Console);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receiver";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_ClearConsole;
        private System.Windows.Forms.RichTextBox RTB_Console;
        private System.Windows.Forms.Button BTN_Close;
    }
}