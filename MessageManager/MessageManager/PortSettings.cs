﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace PortSetTest
{
    public partial class PortSettings : Form
    {
        public PortSettings()
        {
            InitializeComponent();

            // Get a list of Serial port names
            string[] ports = SerialPort.GetPortNames();
          
            int i = 0;
            foreach (string s in ports) 
            {
                if (s != "") 
                {
                    listBoxPorts.Items.Insert(i++,s);
                }
            }

            // Initialize baudrates in combobox;
            comboBoxBaud.Items.AddRange(new object[] {
                                    "75",
                                    "110",
                                    "134",
                                    "150",
                                    "300",
                                    "600",
                                    "1200",
                                    "1800",
                                    "2400",
                                    "4800",
                                    "7200",
                                    "9600",
                                    "14400",
                                    "19200",
                                    "38400",
                                    "57600",
                                    "115200",
                                    "128000"});

            // Set Handshaking selection
            // We will only use these handshaking types
            comboBoxHandshaking.Items.Add("None");
            comboBoxHandshaking.Items.Add("RTS/CTS");
            comboBoxHandshaking.Items.Add("Xon/Xoff");

            // Set Parity types
            comboBoxParity.Items.Add("None");
            comboBoxParity.Items.Add("Even");
            comboBoxParity.Items.Add("Odd");
            comboBoxParity.Items.Add("Mark");
            comboBoxParity.Items.Add("Space");


            // Set Databits
            // FT232R UART interface supports only 7 or 8 data bits
            //comboBoxDataBits.Items.Add("5"); // not supported
            //comboBoxDataBits.Items.Add("6"); // not supported
            comboBoxDataBits.Items.Add("7");
            comboBoxDataBits.Items.Add("8");
            // Set Stopbits
            // FT232R UART interface supports only 1 or 2 stop bits
            //comboBoxStopBits.Items.Add("None"); // not supported
            comboBoxStopBits.Items.Add("1");
            //comboBoxStopBits.Items.Add("1.5"); // not supported
            comboBoxStopBits.Items.Add("2");

            comboBoxBaud.Text = "19200";
            comboBoxParity.Text = "None";
            comboBoxDataBits.Text = "8";
            comboBoxStopBits.Text = "1";
            comboBoxHandshaking.Text = "None";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #region Data Assessors
        // Data assessors and index changed functions
        // FT232R UART interface supporta
        // 7 or 8 data bits
        // 1 or 2 stop bits
        // odd / even / mark / space / no parity.
        // So these will be the only options available

        #region Port Name
        // Assessor for the selected port name
        private string SelectedPort = "";
        public string selectedPort
        {
            get
            {
                return SelectedPort;
            }
            set
            {
                SelectedPort = value;
                labelPort.Text = "Selected Port = " + SelectedPort;
            }
        }

        private void listBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void listBoxPorts_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                SelectedPort = Convert.ToString(listBoxPorts.Items[listBoxPorts.SelectedIndex]);
                labelPort.Text = "Selected Port = " + SelectedPort;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                // Get a list of Serial port names
                string[] ports = SerialPort.GetPortNames();
                //MessageBox.Show(excep.Message);

                // If there are ports available
                if (ports.GetUpperBound(0) > 0)
                {
                    MessageBox.Show("Double click on a port to select it");
                }
            }
        }
        #endregion

        #region Baudrate
        private int SelectedBaudrate;
        public int selectedBaudrate
        {
            get
            {
                return SelectedBaudrate;
            }
            set
            {
                SelectedBaudrate = value;
                comboBoxBaud.Text = value.ToString();
            }
        }

        private void comboBoxBaud_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBaudrate = Convert.ToInt32(comboBoxBaud.Items[comboBoxBaud.SelectedIndex]);
        }
        #endregion

        #region Parity
        private Parity SelectedParity;// = Parity.None;
        public Parity selectedParity
        {
            get
            {
                return SelectedParity;
            }
            set
            {
                SelectedParity = value;
                comboBoxParity.Text = value.ToString();
            }
        }

        private void comboBoxParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBoxParity.Items[comboBoxParity.SelectedIndex].ToString();
            switch (temp)
            {
                case "Even":
                    selectedParity = Parity.Even;
                    break;
                case "Mark":
                    selectedParity = Parity.Mark;
                    break;
                case "None":
                    selectedParity = Parity.None;
                    break;
                case "Odd":
                    selectedParity = Parity.Odd;
                    break;
                case "Space":
                    selectedParity = Parity.Space;
                    break;
                default:
                    selectedParity = Parity.None;
                    break;
            }
        }

        #endregion

        #region StobBits
        private StopBits SelectedStopBits = StopBits.One;
        public StopBits selectedStopBits
        {
            get
            {
                return SelectedStopBits;
            }
            set
            {
                SelectedStopBits = value;
                comboBoxStopBits.Text = value.ToString();
            }
        }

        private void comboBoxStopBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBoxStopBits.Items[comboBoxStopBits.SelectedIndex].ToString();

            switch (temp)
            {
                case "None":
                    selectedStopBits = StopBits.None;
                    break;
                case "1":
                    selectedStopBits = StopBits.One;
                    break;
                //case "1.5": // not supported by FT232R
                //SelectedStopBits = StopBits.OnePointFive;
                //break;
                case "2":
                    selectedStopBits = StopBits.Two;
                    break;
                default:
                    selectedStopBits = StopBits.One;
                    break;
            }
        }
        #endregion

        #region DataBits
        private int SelectedDataBits = 8;
        public int selectedDataBits
        {
            get
            {
                return SelectedDataBits;
            }
            set
            {
                SelectedDataBits = value;
                comboBoxDataBits.Text = value.ToString();
            }
        }

        private void comboBoxDataBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDataBits.SelectedIndex == 0) selectedDataBits = 7;
            else selectedDataBits = 8;
        }

    #endregion

        #region Handshaking
        // We will only use None, Xon/Xoff, or Hardware (which is RTS/CTS)
        private Handshake SelectedHandshaking = Handshake.None;
        public Handshake selectedHandshaking
        {
            get
            {
                return SelectedHandshaking;
            }
            set
            {
                SelectedHandshaking = value;
                comboBoxHandshaking.Text = value.ToString();
            }
        }

        private void comboBoxHandshaking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxHandshaking.SelectedIndex == 0) selectedHandshaking = Handshake.None;
            else if (comboBoxHandshaking.SelectedIndex == 1) selectedHandshaking = Handshake.RequestToSend;
            else if (comboBoxHandshaking.SelectedIndex == 2) selectedHandshaking = Handshake.XOnXOff;
            else selectedHandshaking = Handshake.None;
        }
        #endregion

        #endregion
    }
}