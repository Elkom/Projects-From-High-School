namespace Serial8bitsSTM32
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.CB_BitFOUR = new System.Windows.Forms.CheckBox();
            this.CB_BitSEVEN = new System.Windows.Forms.CheckBox();
            this.CB_BitSIX = new System.Windows.Forms.CheckBox();
            this.CB_BitFIVE = new System.Windows.Forms.CheckBox();
            this.CB_BitTHREE = new System.Windows.Forms.CheckBox();
            this.CB_BitTWO = new System.Windows.Forms.CheckBox();
            this.CB_BitONE = new System.Windows.Forms.CheckBox();
            this.CB_BitZERO = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_BitFOUR
            // 
            this.CB_BitFOUR.AutoSize = true;
            this.CB_BitFOUR.Location = new System.Drawing.Point(11, 143);
            this.CB_BitFOUR.Name = "CB_BitFOUR";
            this.CB_BitFOUR.Size = new System.Drawing.Size(47, 17);
            this.CB_BitFOUR.TabIndex = 17;
            this.CB_BitFOUR.Text = "Bit 4";
            this.CB_BitFOUR.UseVisualStyleBackColor = true;
            this.CB_BitFOUR.CheckedChanged += new System.EventHandler(this.CB_BitFOUR_CheckedChanged);
            // 
            // CB_BitSEVEN
            // 
            this.CB_BitSEVEN.AutoSize = true;
            this.CB_BitSEVEN.Location = new System.Drawing.Point(11, 214);
            this.CB_BitSEVEN.Name = "CB_BitSEVEN";
            this.CB_BitSEVEN.Size = new System.Drawing.Size(47, 17);
            this.CB_BitSEVEN.TabIndex = 16;
            this.CB_BitSEVEN.Text = "Bit 7";
            this.CB_BitSEVEN.UseVisualStyleBackColor = true;
            this.CB_BitSEVEN.CheckedChanged += new System.EventHandler(this.CB_BitSEVEN_CheckedChanged);
            // 
            // CB_BitSIX
            // 
            this.CB_BitSIX.AutoSize = true;
            this.CB_BitSIX.Location = new System.Drawing.Point(11, 190);
            this.CB_BitSIX.Name = "CB_BitSIX";
            this.CB_BitSIX.Size = new System.Drawing.Size(47, 17);
            this.CB_BitSIX.TabIndex = 15;
            this.CB_BitSIX.Text = "Bit 6";
            this.CB_BitSIX.UseVisualStyleBackColor = true;
            this.CB_BitSIX.CheckedChanged += new System.EventHandler(this.CB_BitSIX_CheckedChanged);
            // 
            // CB_BitFIVE
            // 
            this.CB_BitFIVE.AutoSize = true;
            this.CB_BitFIVE.Location = new System.Drawing.Point(11, 166);
            this.CB_BitFIVE.Name = "CB_BitFIVE";
            this.CB_BitFIVE.Size = new System.Drawing.Size(47, 17);
            this.CB_BitFIVE.TabIndex = 14;
            this.CB_BitFIVE.Text = "Bit 5";
            this.CB_BitFIVE.UseVisualStyleBackColor = true;
            this.CB_BitFIVE.CheckedChanged += new System.EventHandler(this.CB_BitFIVE_CheckedChanged);
            // 
            // CB_BitTHREE
            // 
            this.CB_BitTHREE.AutoSize = true;
            this.CB_BitTHREE.Location = new System.Drawing.Point(11, 120);
            this.CB_BitTHREE.Name = "CB_BitTHREE";
            this.CB_BitTHREE.Size = new System.Drawing.Size(47, 17);
            this.CB_BitTHREE.TabIndex = 13;
            this.CB_BitTHREE.Text = "Bit 3";
            this.CB_BitTHREE.UseVisualStyleBackColor = true;
            this.CB_BitTHREE.CheckedChanged += new System.EventHandler(this.CB_BitTHREE_CheckedChanged);
            // 
            // CB_BitTWO
            // 
            this.CB_BitTWO.AutoSize = true;
            this.CB_BitTWO.Location = new System.Drawing.Point(11, 96);
            this.CB_BitTWO.Name = "CB_BitTWO";
            this.CB_BitTWO.Size = new System.Drawing.Size(47, 17);
            this.CB_BitTWO.TabIndex = 12;
            this.CB_BitTWO.Text = "Bit 2";
            this.CB_BitTWO.UseVisualStyleBackColor = true;
            this.CB_BitTWO.CheckedChanged += new System.EventHandler(this.CB_BitTWO_CheckedChanged);
            // 
            // CB_BitONE
            // 
            this.CB_BitONE.AutoSize = true;
            this.CB_BitONE.Location = new System.Drawing.Point(11, 72);
            this.CB_BitONE.Name = "CB_BitONE";
            this.CB_BitONE.Size = new System.Drawing.Size(47, 17);
            this.CB_BitONE.TabIndex = 11;
            this.CB_BitONE.Text = "Bit 1";
            this.CB_BitONE.UseVisualStyleBackColor = true;
            this.CB_BitONE.CheckedChanged += new System.EventHandler(this.CB_BitONE_CheckedChanged);
            // 
            // CB_BitZERO
            // 
            this.CB_BitZERO.AutoSize = true;
            this.CB_BitZERO.Location = new System.Drawing.Point(11, 48);
            this.CB_BitZERO.Name = "CB_BitZERO";
            this.CB_BitZERO.Size = new System.Drawing.Size(47, 17);
            this.CB_BitZERO.TabIndex = 10;
            this.CB_BitZERO.Text = "Bit 0";
            this.CB_BitZERO.UseVisualStyleBackColor = true;
            this.CB_BitZERO.CheckedChanged += new System.EventHandler(this.CB_BitZERO_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Podaci se salju nakon sto pritisnemo dugme\r\n\"Send\"";
            // 
            // BTN_Send
            // 
            this.BTN_Send.Location = new System.Drawing.Point(161, 208);
            this.BTN_Send.Name = "BTN_Send";
            this.BTN_Send.Size = new System.Drawing.Size(75, 23);
            this.BTN_Send.TabIndex = 18;
            this.BTN_Send.Text = "Send";
            this.BTN_Send.UseVisualStyleBackColor = true;
            this.BTN_Send.Click += new System.EventHandler(this.BTN_Send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Podatak:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "00000000";
            // 
            // BTN_Close
            // 
            this.BTN_Close.Location = new System.Drawing.Point(161, 241);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(75, 23);
            this.BTN_Close.TabIndex = 21;
            this.BTN_Close.Text = "Close";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 276);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_Send);
            this.Controls.Add(this.CB_BitFOUR);
            this.Controls.Add(this.CB_BitSEVEN);
            this.Controls.Add(this.CB_BitSIX);
            this.Controls.Add(this.CB_BitFIVE);
            this.Controls.Add(this.CB_BitTHREE);
            this.Controls.Add(this.CB_BitTWO);
            this.Controls.Add(this.CB_BitONE);
            this.Controls.Add(this.CB_BitZERO);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual Send";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_BitFOUR;
        private System.Windows.Forms.CheckBox CB_BitSEVEN;
        private System.Windows.Forms.CheckBox CB_BitSIX;
        private System.Windows.Forms.CheckBox CB_BitFIVE;
        private System.Windows.Forms.CheckBox CB_BitTHREE;
        private System.Windows.Forms.CheckBox CB_BitTWO;
        private System.Windows.Forms.CheckBox CB_BitONE;
        private System.Windows.Forms.CheckBox CB_BitZERO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Close;
    }
}