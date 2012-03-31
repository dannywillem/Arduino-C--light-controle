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
            Statusbox.Text = "connect";  //Says that the light is off
            Offbutton.Enabled = true; //enable the off button
            Onbutton.Enabled = true; //enable the on button
            button1.Enabled = true;   //enable the test button
            disconnect.Enabled = true;  //enable disconnect button
            connect.Enabled = false;  //disable connect button
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            port.Close();
            Statusbox.Text = "disconnect";  //Says that the light is off
            Offbutton.Enabled = true; //enable the off button
            Onbutton.Enabled = true; //enable the on button
            button1.Enabled = true;   //enable the test button
            disconnect.Enabled = false;  //disable disconnect button
            connect.Enabled = true;  //enable connect button
        }

        private void Onbutton_Click(object sender, EventArgs e)
        {
            if (port.IsOpen == true)
            {
                port.Write("N");  //Command for arduino to turn on light
                Statusbox.Text = "THE LED IS ON";  //Says that the light is off
                Offbutton.Enabled = true; //enable the off button
                Onbutton.Enabled = false; //disable the on button
                button1.Enabled = true;   //enable the test button
            }
            else
            {
                MessageBox.Show("There is no Serial Port open.");  //warning box that the port is not open.
            }
        }

        private void Offbutton_Click(object sender, EventArgs e)
        {
            if (port.IsOpen == true)
            {
                port.Write("F");  //Command for arduino to turn off light
                Statusbox.Text = "THE LED IS OFF";  //Says that the light is off
                Offbutton.Enabled = false;  //disable the off button
                Onbutton.Enabled = true;   //enable the on button
                button1.Enabled = true;   //enable the test button
            }
            else
            {
                MessageBox.Show("There is no Serial Port open.");  //warning box that the port is not open.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (port.IsOpen == true)
            {
                port.Write("T");  //Command for arduino to turn off light
                Statusbox.Text = "Arduino is testing";  //Says that the light is on/off
                Offbutton.Enabled = true;  //enable the off button
                Onbutton.Enabled = true;   //enable the on button
                button1.Enabled = false;   //disable the test button
            }
            else
            {
                MessageBox.Show("There is no Serial Port open.");  //warning box that the port is not open.
            }
        }

    }
}
