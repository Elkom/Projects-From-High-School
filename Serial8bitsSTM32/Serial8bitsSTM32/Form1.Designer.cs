namespace Serial8bitsSTM32
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTN_AutoSend = new System.Windows.Forms.Button();
            this.BTN_ManuSend = new System.Windows.Forms.Button();
            this.BTN_ConfigSerial = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.BTN_Receiver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_AutoSend
            // 
            this.BTN_AutoSend.Location = new System.Drawing.Point(12, 60);
            this.BTN_AutoSend.Name = "BTN_AutoSend";
            this.BTN_AutoSend.Size = new System.Drawing.Size(111, 42);
            this.BTN_AutoSend.TabIndex = 0;
            this.BTN_AutoSend.Text = "Automatic Send";
            this.BTN_AutoSend.UseVisualStyleBackColor = true;
            this.BTN_AutoSend.Click += new System.EventHandler(this.BTN_AutoSend_Click);
            // 
            // BTN_ManuSend
            // 
            this.BTN_ManuSend.Location = new System.Drawing.Point(12, 108);
            this.BTN_ManuSend.Name = "BTN_ManuSend";
            this.BTN_ManuSend.Size = new System.Drawing.Size(111, 42);
            this.BTN_ManuSend.TabIndex = 1;
            this.BTN_ManuSend.Text = "Manual Send";
            this.BTN_ManuSend.UseVisualStyleBackColor = true;
            this.BTN_ManuSend.Click += new System.EventHandler(this.BTN_ManuSend_Click);
            // 
            // BTN_ConfigSerial
            // 
            this.BTN_ConfigSerial.Location = new System.Drawing.Point(12, 12);
            this.BTN_ConfigSerial.Name = "BTN_ConfigSerial";
            this.BTN_ConfigSerial.Size = new System.Drawing.Size(111, 42);
            this.BTN_ConfigSerial.TabIndex = 2;
            this.BTN_ConfigSerial.Text = "Configure Serial";
            this.BTN_ConfigSerial.UseVisualStyleBackColor = true;
            this.BTN_ConfigSerial.Click += new System.EventHandler(this.BTN_ConfigSerial_Click);
            // 
            // BTN_Receiver
            // 
            this.BTN_Receiver.Location = new System.Drawing.Point(12, 156);
            this.BTN_Receiver.Name = "BTN_Receiver";
            this.BTN_Receiver.Size = new System.Drawing.Size(111, 42);
            this.BTN_Receiver.TabIndex = 5;
            this.BTN_Receiver.Text = "Receiver";
            this.BTN_Receiver.UseVisualStyleBackColor = true;
            this.BTN_Receiver.Click += new System.EventHandler(this.BTN_Receiver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(136, 209);
            this.Controls.Add(this.BTN_Receiver);
            this.Controls.Add(this.BTN_ConfigSerial);
            this.Controls.Add(this.BTN_ManuSend);
            this.Controls.Add(this.BTN_AutoSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial 8bits";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_AutoSend;
        private System.Windows.Forms.Button BTN_ManuSend;
        private System.Windows.Forms.Button BTN_ConfigSerial;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button BTN_Receiver;
    }
}

