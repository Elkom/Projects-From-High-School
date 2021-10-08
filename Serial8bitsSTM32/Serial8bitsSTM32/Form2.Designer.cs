namespace Serial8bitsSTM32
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_StartSerial = new System.Windows.Forms.Button();
            this.BTN_SerialClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBaud = new System.Windows.Forms.ComboBox();
            this.BTN_BaudChange = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LB_BDR = new System.Windows.Forms.Label();
            this.LB_Status = new System.Windows.Forms.Label();
            this.LB_COM = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.CMB_Ports = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unesite broj COM porta";
            // 
            // BTN_StartSerial
            // 
            this.BTN_StartSerial.Location = new System.Drawing.Point(91, 67);
            this.BTN_StartSerial.Name = "BTN_StartSerial";
            this.BTN_StartSerial.Size = new System.Drawing.Size(75, 23);
            this.BTN_StartSerial.TabIndex = 3;
            this.BTN_StartSerial.Text = "Otvori Port";
            this.BTN_StartSerial.UseVisualStyleBackColor = true;
            this.BTN_StartSerial.Click += new System.EventHandler(this.BTN_StartSerial_Click);
            // 
            // BTN_SerialClose
            // 
            this.BTN_SerialClose.Location = new System.Drawing.Point(10, 67);
            this.BTN_SerialClose.Name = "BTN_SerialClose";
            this.BTN_SerialClose.Size = new System.Drawing.Size(75, 23);
            this.BTN_SerialClose.TabIndex = 4;
            this.BTN_SerialClose.Text = "Zatvori Port";
            this.BTN_SerialClose.UseVisualStyleBackColor = true;
            this.BTN_SerialClose.Click += new System.EventHandler(this.BTN_SerialClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Configure baudrate";
            // 
            // ComboBaud
            // 
            this.ComboBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBaud.FormattingEnabled = true;
            this.ComboBaud.Location = new System.Drawing.Point(10, 118);
            this.ComboBaud.Name = "ComboBaud";
            this.ComboBaud.Size = new System.Drawing.Size(156, 21);
            this.ComboBaud.TabIndex = 6;
            // 
            // BTN_BaudChange
            // 
            this.BTN_BaudChange.Location = new System.Drawing.Point(91, 145);
            this.BTN_BaudChange.Name = "BTN_BaudChange";
            this.BTN_BaudChange.Size = new System.Drawing.Size(75, 23);
            this.BTN_BaudChange.TabIndex = 7;
            this.BTN_BaudChange.Text = "Change";
            this.BTN_BaudChange.UseVisualStyleBackColor = true;
            this.BTN_BaudChange.Click += new System.EventHandler(this.BTN_BaudChange_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LB_BDR);
            this.groupBox1.Controls.Add(this.LB_Status);
            this.groupBox1.Controls.Add(this.LB_COM);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(172, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 126);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monitor";
            // 
            // LB_BDR
            // 
            this.LB_BDR.AutoSize = true;
            this.LB_BDR.Location = new System.Drawing.Point(80, 54);
            this.LB_BDR.Name = "LB_BDR";
            this.LB_BDR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_BDR.Size = new System.Drawing.Size(35, 13);
            this.LB_BDR.TabIndex = 5;
            this.LB_BDR.Text = "label9";
            // 
            // LB_Status
            // 
            this.LB_Status.AutoSize = true;
            this.LB_Status.Location = new System.Drawing.Point(80, 37);
            this.LB_Status.Name = "LB_Status";
            this.LB_Status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_Status.Size = new System.Drawing.Size(35, 13);
            this.LB_Status.TabIndex = 4;
            this.LB_Status.Text = "label8";
            // 
            // LB_COM
            // 
            this.LB_COM.AutoSize = true;
            this.LB_COM.Location = new System.Drawing.Point(80, 20);
            this.LB_COM.Name = "LB_COM";
            this.LB_COM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_COM.Size = new System.Drawing.Size(35, 13);
            this.LB_COM.TabIndex = 3;
            this.LB_COM.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Baudrate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "COM:";
            // 
            // BTN_Close
            // 
            this.BTN_Close.Location = new System.Drawing.Point(227, 145);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(75, 23);
            this.BTN_Close.TabIndex = 9;
            this.BTN_Close.Text = "Close";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // CMB_Ports
            // 
            this.CMB_Ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_Ports.FormattingEnabled = true;
            this.CMB_Ports.Location = new System.Drawing.Point(50, 40);
            this.CMB_Ports.Name = "CMB_Ports";
            this.CMB_Ports.Size = new System.Drawing.Size(116, 21);
            this.CMB_Ports.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 177);
            this.Controls.Add(this.CMB_Ports);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_BaudChange);
            this.Controls.Add(this.ComboBaud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_SerialClose);
            this.Controls.Add(this.BTN_StartSerial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure Serial";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_StartSerial;
        private System.Windows.Forms.Button BTN_SerialClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBaud;
        private System.Windows.Forms.Button BTN_BaudChange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LB_BDR;
        private System.Windows.Forms.Label LB_Status;
        private System.Windows.Forms.Label LB_COM;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.ComboBox CMB_Ports;
    }
}