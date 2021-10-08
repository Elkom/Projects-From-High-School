using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//E.S.
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial8bitsSTM32
{
    public partial class Form2 : Form
    {
        private int[] bdRates = {300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 128000};
        Form1 OGForm;
        public Form2(Form1 incomingForm)
        {
            OGForm = incomingForm;
            InitializeComponent();
            foreach (String s in System.IO.Ports.SerialPort.GetPortNames())
                CMB_Ports.Items.Add(s);
        }

        private void updateStatus()
        {
            OGForm.updateDataForInfo();
            LB_COM.Text = OGForm.SerialPR;
            LB_BDR.Text = OGForm.SerialBaudrate.ToString();
            if (OGForm.srlOPN)
                LB_Status.Text = "Open";
            else
                LB_Status.Text = "Closed";
        }

        private void BTN_StartSerial_Click(object sender, EventArgs e)
        {
            try
            {
                string s = CMB_Ports.SelectedItem.ToString();
                OGForm.SerialStart(s);
                updateStatus();
            }
            catch
            {
                MessageBox.Show("Please select a port");
            }
        }

        private void BTN_SerialClose_Click(object sender, EventArgs e)
        {
            OGForm.SerialClose();
            updateStatus();
        }

        private void BTN_BaudChange_Click(object sender, EventArgs e)
        {
            int b = int.Parse(ComboBaud.SelectedItem.ToString());
            OGForm.SerialBaud(b);
            updateStatus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            updateStatus();
            foreach (int i in bdRates)
                ComboBaud.Items.Add(i);
            ComboBaud.SelectedIndex = 5;
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            OGForm.Focus();
            this.Close();
        }
    }
}
