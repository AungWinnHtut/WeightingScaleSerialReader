//Programmer Dr. Aung Win Htut
//This program is reading data from 
// XK3190-A9+ weithting scale
//Date: 21-11-2017 Tuesday 1521

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Serial_data
{
    public partial class frmSerial : Form
    {
        public string myComPortName = "";
        public frmSerial()
        {
            InitializeComponent();
        }

        private void frmSerial_Load(object sender, EventArgs e)
        {
            string[] comPortArray = null;
            comPortArray = SerialPort.GetPortNames();
            Array.Sort(comPortArray);
            foreach (string portname in comPortArray)
            {
                cboCOM.Items.Add(portname);
            }
            cboCOM.SelectedIndex = 1;
           
        }

        private void frmSerial_FormClosing(object sender, FormClosingEventArgs e)
        {
            disConnect();
            serialPort1.Dispose();
            Application.Exit();
        }

      

        private void btnConnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = cboCOM.SelectedItem.ToString();
            try
            {
                if (!(serialPort1.IsOpen))
                {
                    serialPort1.Open();
                }
                else
                {
                    serialPort1.Close();
                    serialPort1.Open();
                }
                btnON.Enabled = true;
                btnOFF.Enabled = true;
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                txtMessage.Enabled = true;
                lblStart.Enabled = true;
                lblStop.Enabled = true;
                cboStart.Enabled = true;
                cboStop.Enabled = true;
                cboStop.Enabled = true ;
                cboStart.SelectedIndex = 0;
                cboStop.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnON_Click(object sender, EventArgs e)
        {
            //funSendCommand("0");
            int start,stop;
            int k=0;
            char[] newArray = new char[10];
            start = int.Parse(cboStart.SelectedItem.ToString());
            stop = int.Parse(cboStop.SelectedItem.ToString());
            for (int i = start; i <= stop; i++)
            {
                newArray [k++]=charray [i];
            }
            string result = new string (newArray );
            txtMessage.Text = result;
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            //funSendCommand("1");
            txtMessage.Text = "";
        }

        public void funSendCommand(string command)
        {
            try
            {
                serialPort1.WriteLine(command );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        bool flag = false; //to carry flag after new data
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {            
            int ch;
            char c;
            if (serialPort1.BytesToRead > 0)
            {
               // receivedData = serialPort1.ReadLine();
                ch = serialPort1.ReadChar();
                if (ch == 2)
                {
                    flag = true;                 
                }
                if ((flag == true)&&(ch!=2)&&(ch!=3))
                {
                    c = (char)ch;
                    funSendChar(c);
                    //funSendText(c.ToString ());                 
                }
                if (ch == 3)
                {
                    flag = false;                    
                }               
            }           
        }

        delegate void SetTextCallback(string text);
        char[] charray = new char[10];
        int j = 0;
        private void funSendChar(char cc)
        {
            if (j < 10)
            {
                charray[j] = cc;
            }
            else
            {
                j = 0;
                charray[j] = cc;
            }
            j++;
        }
        
        private void funSendText(string text)
        {
            if (this.txtMessage.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(funSendText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtMessage.Text += text + "\n\r";
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            disConnect();
        }

        private void frmSerial_FormClosed(object sender, FormClosedEventArgs e)
        {
            disConnect();
            serialPort1.Dispose();
            Application.Exit();
        }


        private void disConnect()
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            btnON.Enabled = false;
            btnOFF.Enabled = false;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            txtMessage.Enabled = false;
            lblStart.Enabled = false;
            lblStop.Enabled = false;
            cboStart.Enabled = false;
            cboStop.Enabled = false;
            cboStop.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            disConnect();
            Application.Exit();
        }

    }
}
