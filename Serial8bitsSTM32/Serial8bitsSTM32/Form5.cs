using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Serial8bitsSTM32
{
    public partial class Form5 : Form
    {
        Form1 OGForm;
        public Form5(Form1 incomingForm)
        {
            OGForm = incomingForm;
            InitializeComponent();
        }

        public void updConsl()
        {
            RTB_Console.Invoke(new Action(() => RTB_Console.Text += OGForm.textRec));
            RTB_Console.Invoke(new Action(() => RTB_Console.Select(RTB_Console.Text.Length - 1, 0)));
            RTB_Console.Invoke(new Action(() => RTB_Console.ScrollToCaret()));
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_ClearConsole_Click(object sender, EventArgs e)
        {
            RTB_Console.Clear();
        }
    }
}
