using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//E.S.
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace Serial8bitsSTM32
{
    public partial class Form1 : Form
    {
        public char[] data = { '0', '0', '0', '0', '0', '0', '0', '0' };
        public string dataStr = "";
        public int SerialBaudrate = 0;
        public string SerialPR = "";
        public bool srlOPN = false;
        public string textRec = "";

        public Form1()
        {
            InitializeComponent();
            SerialBaudrate = serialPort1.BaudRate;
        }

        internal void updateDataForInfo()
        {
            SerialBaudrate = serialPort1.BaudRate;
            SerialPR = serialPort1.PortName;
            srlOPN = (serialPort1.IsOpen) ? true : false;
        }

        internal void dataReset()
        {
            for(int i = 0; i < 8; i++)
            {
                data[i] = '0';
            }
        }
        
        internal void SerialBaud(int b)
        {
            serialPort1.BaudRate = b;
            SerialBaudrate = serialPort1.BaudRate;
        }

        internal void SerialStart(string s)
        {
            if (serialPort1.IsOpen)
                MessageBox.Show("Serial port is already open");
            else
            {
                try
                {
                    serialPort1.PortName = s;
                    serialPort1.Open();
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialReceived);
                    MessageBox.Show("Serial port is open");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void serialReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                textRec = serialPort1.ReadExisting();
                foreach (Form f in Application.OpenForms)
                    if (f.Text == "Receiver")
                    {
                        (f as Form5).updConsl();
                        break;
                    }
            }
            catch
            {
                MessageBox.Show("Receiver window not open", "Error");
            }
        }

        internal void SerialClose()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                MessageBox.Show("Serial port closed");
            }
            else
                MessageBox.Show("Serial port is not open");

        }

        internal void sendData()
        {
            // use for bit by bit
            if(serialPort1.IsOpen)
                foreach (char d in data)
                    serialPort1.Write(d.ToString());
            /*
            //use for string
            string sat = "";
            if (serialPort1.IsOpen)
            {
                foreach (char d in data)
                    sat += d.ToString();
                serialPort1.Write(sat);
            }*/
            else
                MessageBox.Show("Serial port is not open");
        }

        private void BTN_ConfigSerial_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
                if(f.Text == "Configure Serial")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            if (isOpen == false)
            {
                Form2 frm2 = new Form2(this);
                frm2.Show();
                frm2.Focus();
            }
        }

        private void BTN_AutoSend_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
                if (f.Text == "Automatic Send")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            if (isOpen == false)
            {
                Form3 frm3 = new Form3(this);
                frm3.Show();
                frm3.Focus();
            }
        }

        private void BTN_ManuSend_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
                if (f.Text == "Manual Send")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            if (isOpen == false)
            {
                Form4 frm4 = new Form4(this);
                frm4.Show();
                frm4.Focus();
            }
        }

        private void BTN_Receiver_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
                if (f.Text == "Receiver")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            if (isOpen == false)
            {
                Form5 frm5 = new Form5(this);
                frm5.Show();
                frm5.Focus();
            }
        }
    }
}
