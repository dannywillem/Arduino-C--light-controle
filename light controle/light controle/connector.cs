using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace light_controle
{
    public partial class connector : Form
    {
        static SerialPort port;

        public connector()
        {
            InitializeComponent();

            string[] portlist = SerialPort.GetPortNames();

            foreach (String s in portlist)
            {
                portcombobox.Items.Add(s);
            }
        }

        private void connect_Click(object sender, EventArgs e)
        {
            if (port != null)
            {
                port.Close();
                port.Dispose();
            }
            port = new SerialPort(portcombobox.SelectedItem.ToString(), 9600, Parity.None, 8, StopBits.One);
            port.Open();
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            port.Close();
        }

        private void Onbutton_Click(object sender, EventArgs e)
        {
            port.Write("N"); //on command
        }

        private void Offbutton_Click(object sender, EventArgs e)
        {
            port.Write("F"); //off command
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port.Write("T"); //Led on delay 1500 led off
        }

    }
}
