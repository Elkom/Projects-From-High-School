namespace Projektni_Zadatak_Programiranje
{
    partial class Welcome_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_Form));
            this.RTB_Welcome = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTB_Welcome
            // 
            this.RTB_Welcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTB_Welcome.Location = new System.Drawing.Point(12, 12);
            this.RTB_Welcome.Name = "RTB_Welcome";
            this.RTB_Welcome.ReadOnly = true;
            this.RTB_Welcome.Size = new System.Drawing.Size(407, 137);
            this.RTB_Welcome.TabIndex = 0;
            this.RTB_Welcome.Text = resources.GetString("RTB_Welcome.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Location = new System.Drawing.Point(309, 155);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(110, 52);
            this.BTN_Exit.TabIndex = 2;
            this.BTN_Exit.Text = "Exit";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // Welcome_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 219);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RTB_Welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visual Studio 2017 Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Welcome_Form_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Welcome_Form_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB_Welcome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_Exit;
    }
}

