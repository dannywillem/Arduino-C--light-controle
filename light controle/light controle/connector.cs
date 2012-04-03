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
 
        // The serial connections in combobox
        public connector()
        {
            InitializeComponent();

            string[] portlist = SerialPort.GetPortNames();

            foreach (String s in portlist)
            {
                portcombobox.Items.Add(s);
            }
        }

        // The connect button
        private void connect_Click(object sender, EventArgs e)
        {

            if (port != null)
            {
                port.Close();
                port.Dispose();
            }

            if (portcombobox.Text !=string.Empty)
            {
                port.PortName = portcombobox.SelectedItem.ToString();
                port.Open();

                if (port.IsOpen == true)
                {
                    Statusbox.Text = "connect";  //Says that the light is off
                    Statusbox.BackColor = Color.Green;  //green background color for connect box
                    Offbutton.Enabled = true; //enable the off button
                    Onbutton.Enabled = true; //enable the on button
                    button1.Enabled = true;   //enable the test button
                    disconnect.Enabled = true;  //enable disconnect button
                    connect.Enabled = false;  //disable connect button
                }
                else
                {
                    MessageBox.Show("There is no Serial Port open.");
                }
            }
            else 
            {
                MessageBox.Show("Select a port first.");
            }


        }

        // The disconnect button
        private void disconnect_Click(object sender, EventArgs e)
        {

            if (port.IsOpen == true)
            {
                port.Close();
                Statusbox.Text = "disconnect";  //Says that the light is off
                Statusbox.BackColor = Color.Red;  //red background color for connect box
                Offbutton.Enabled = true; //enable the off button
                Onbutton.Enabled = true; //enable the on button
                button1.Enabled = true;   //enable the test button
                disconnect.Enabled = false;  //disable disconnect button
                connect.Enabled = true;  //enable connect button
            }
            else
            {
                MessageBox.Show("There is no serial Port open.");
            }
        }

        // The led on button
        private void Onbutton_Click(object sender, EventArgs e)
        {
            if (port.IsOpen == true)
            {
                port.Write("N");  //Command for arduino to turn on light
                //Statusbox.Text = "THE LED IS ON";  //Says that the light is off
                //Statusbox.BackColor = Color.Green;
                Offbutton.Enabled = true; //enable the off button
                Onbutton.Enabled = false; //disable the on button
                button1.Enabled = true;   //enable the test button
            }
            else
            {
                MessageBox.Show("There is no Serial Port open.");  //warning box that the port is not open.
            }
        }

        // The off button
        private void Offbutton_Click(object sender, EventArgs e)
        {
            if (port.IsOpen == true)
            {
                port.Write("F");  //Command for arduino to turn off light
                //Statusbox.Text = "THE LED IS OFF";  //Says that the light is off
                //Statusbox.BackColor = Color.Red;
                Offbutton.Enabled = false;  //disable the off button
                Onbutton.Enabled = true;   //enable the on button
                button1.Enabled = true;   //enable the test button
            }
            else
            {
                MessageBox.Show("There is no Serial Port open.");  //warning box that the port is not open.
            }
        }

        //The test button
        private void button1_Click(object sender, EventArgs e)
        {
            if (port.IsOpen == true)
            {
                port.Write("T");  //Command for arduino to turn off light
                //Statusbox.Text = "Arduino is testing";  //Says that the light is on/off
                Offbutton.Enabled = true;  //enable the off button
                Onbutton.Enabled = true;   //enable the on button
                button1.Enabled = false;   //disable the test button
            }
            else
            {
                MessageBox.Show("There is no Serial Port open.");  //warning box that the port is not open.
            }
        }

        private void connector_close(object sender, EventArgs e)
        {
            if (port.IsOpen == true)
            {
                port.Close();
            }
            else
            {

            }
        }

        // todo: Get this work :)
        // read data from serial and display it on ledbox
        private void ledbox_TextChanged(object sender, EventArgs e)
        {
            String line = port.ReadLine();
            ledbox.Text = line;
        }
        

    }
}
