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
    public partial class Form4 : Form
    {
        Form1 OGForm;
        public Form4(Form1 form1)
        {
            OGForm = form1;
            OGForm.dataReset();
            InitializeComponent();
        }

        private void updateLabel()
        {
            label3.Text = "";
            foreach (char d in OGForm.data)
                label3.Text += d;
            OGForm.dataStr = label3.Text;
        }

        private void CB_BitZERO_CheckedChanged(object sender, EventArgs e)
        {
            if (OGForm.data[0] == '0')
                OGForm.data[0] = '1';
            else
                OGForm.data[0] = '0';
            updateLabel();
        }

        private void CB_BitONE_CheckedChanged(object sender, EventArgs e)
        {
            if (OGForm.data[1] == '0')
                OGForm.data[1] = '1';
            else
                OGForm.data[1] = '0';
            updateLabel();
        }

        private void CB_BitTWO_CheckedChanged(object sender, EventArgs e)
        {
            if (OGForm.data[2] == '0')
                OGForm.data[2] = '1';
            else
                OGForm.data[2] = '0';
            updateLabel();
        }

        private void CB_BitTHREE_CheckedChanged(object sender, EventArgs e)
        {
            if (OGForm.data[3] == '0')
                OGForm.data[3] = '1';
            else
                OGForm.data[3] = '0';
            updateLabel();
        }

        private void CB_BitFOUR_CheckedChanged(object sender, EventArgs e)
        {
            if (OGForm.data[4] == '0')
                OGForm.data[4] = '1';
            else
                OGForm.data[4] = '0';
            updateLabel();
        }

        private void CB_BitFIVE_CheckedChanged(object sender, EventArgs e)
        {
            if (OGForm.data[5] == '0')
                OGForm.data[5] = '1';
            else
                OGForm.data[5] = '0';
            updateLabel();
        }

        private void CB_BitSIX_CheckedChanged(object sender, EventArgs e)
        {
            if (OGForm.data[6] == '0')
                OGForm.data[6] = '1';
            else
                OGForm.data[6] = '0';
            updateLabel();
        }

        private void CB_BitSEVEN_CheckedChanged(object sender, EventArgs e)
        {
            if (OGForm.data[7] == '0')
                OGForm.data[7] = '1';
            else
                OGForm.data[7] = '0';
            updateLabel();
        }

        private void BTN_Send_Click(object sender, EventArgs e)
        {
            OGForm.sendData();
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            OGForm.Focus();
            this.Close();
        }
    }
}
