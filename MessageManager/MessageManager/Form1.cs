using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PortSetTest; // For com port settings dialog

namespace MessageManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear the rich text box used to display messages from the device
            rtbDeviceLog.Text = "";
        }

        private void btnClearLCD_Click(object sender, EventArgs e)
        {
            // Clear the textboxes used for entering LCD text
            txtRow1.Text = "";
            txtRow2.Text = "";
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make sure the port isnt already open
            if (serialPort1.IsOpen)
            {
                MessageBox.Show("The port must be closed before changing the settings.");
                return;
            }
            else
            {
                // Create an instance of the settings form
                PortSettings settings = new PortSettings();

                if (settings.ShowDialog() == DialogResult.OK)
                {
                    if (settings.selectedPort != "")
                    {
                        // Set the serial port to the new settings
                        serialPort1.PortName = settings.selectedPort;
                        serialPort1.BaudRate = settings.selectedBaudrate;
                        serialPort1.DataBits = settings.selectedDataBits;
                        serialPort1.Parity = settings.selectedParity;
                        serialPort1.StopBits = settings.selectedStopBits;

                        // Show the new settings in the form text line
                        showSettings();
                    }
                    else
                    {
                        MessageBox.Show("Error: Settings form returned with no seiral port selected");
                        return; // Bail out
                    }
                }
                else
                {
                    MessageBox.Show("Error: buttonSetup_Click - Settings dialog box did not return Okay.");
                    return; // bail out
                }

                // Open the port
                try
                {
                    serialPort1.Close();
                    serialPort1.Open();

                    menuStrip1.Items[1].Text = "Close Port";
                    showSettings();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error - setupToolStripMenuItem_Click Exception: " + ex);
                }
            }
        }

        // show the settings in the form text line
        private void showSettings()
        {
            this.Text = "LCD Message Manager - " +
            serialPort1.PortName + " " +
            serialPort1.BaudRate.ToString() + "," +
            serialPort1.Parity + "," +
            serialPort1.DataBits.ToString() + "," +
            serialPort1.StopBits;

            if (serialPort1.IsOpen)
            {
                this.Text += " - Port is open";
            }
            else
            {
                this.Text += " - Port is closed";
            }
        }

        private void openPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    openPortToolStripMenuItem.Text = "Open Port";
                }
                else
                {
                    serialPort1.Open();
                    openPortToolStripMenuItem.Text = "Close Port";
                }

                showSettings();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error - openPortToolStripMenuItem_Click Exception: " + ex);
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            // Send the text entered by user to the LCD
            string LCDRow1 = "";
            string LCDRow2 = "";

            LCDRow1 = "LCD00" + txtRow1.Text;
            LCDRow2 = "LCD01" + txtRow2.Text;

            try
            {
                serialPort1.WriteLine(LCDRow1);
                serialPort1.WriteLine(LCDRow2);
            }
            catch
            {
                MessageBox.Show("Error: sendByte - failed to send.\nIs the port open?");
            }

        }

        private void btnLEDFlash_Click(object sender, EventArgs e)
        {
            // Send a message to flash the LED
            try
            {
                serialPort1.WriteLine("LED FLASH");
            }
            catch
            {
                MessageBox.Show("Error: sendByte - failed to send.\nIs the port open?");
            }
        }

        private void btnLEDOff_Click(object sender, EventArgs e)
        {
            // Send a message to turn off the LED
            try
            {
                serialPort1.WriteLine("LED OFF");
            }
            catch
            {
                MessageBox.Show("Error: sendByte - failed to send.\nIs the port open?");
            }
        }

        private void btnBuzzerOn_Click(object sender, EventArgs e)
        {
            // Send a message to turn on the buzzer
            try
            {
                serialPort1.WriteLine("BUZZER ON");
            }
            catch
            {
                MessageBox.Show("Error: sendByte - failed to send.\nIs the port open?");
            }
        }

        private void btnBuzzerOff_Click(object sender, EventArgs e)
        {
            // Send a message to turn off the buzzer
            try
            {
                serialPort1.WriteLine("BUZZER OFF");
            }
            catch
            {
                MessageBox.Show("Error: sendByte - failed to send.\nIs the port open?");
            }
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            string file_name = "\\Device Log.txt";
            file_name = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + file_name;

            System.IO.StreamWriter objwriter;
            objwriter = new System.IO.StreamWriter(file_name, true);

            objwriter.Write(rtbDeviceLog.Text);
            objwriter.Close();

            MessageBox.Show("Device Log Saved\nin MyDocuments folder");


            // The method below uses a file dialog object
            /*string save_path = "";
            saveFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFD.Title = "Save the device log";
            saveFD.FileName = "Device Log Test";
            saveFD.Filter = "Text Files|.txt|All Files|*.*";



            if (saveFD.ShowDialog() != DialogResult.Cancel)
            {
                save_path = saveFD.FileName;

                System.IO.StreamWriter objwriter;
                objwriter = new System.IO.StreamWriter(save_path, true);

                objwriter.Write(rtbDeviceLog.Text);
                objwriter.Close();

                MessageBox.Show("Device Log Saved"); 
            }
            */
        }

        #region receive functions
        // we want to have the serial port thread report back data received, but to
        // display that data we must create a delegate function to show the data in the
        // richTextBox

        // define the delegate
        public delegate void SetText();
        // define an instance of the delegate
        SetText setText;

        // create a string that will be loaded with the data received from the port
        public string str = "";

        // note that this function runs in a separate thread and thus we must use a
        // delegate in order
        // to display the results in the richTextBox.
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            // instantiate the delegate to be invoked by this thread
            setText = new SetText(mySetText);
            // load the data into the string
            try
            {
                //str = serialPort1.ReadExisting();
                str = serialPort1.ReadLine(); // Read until we have a linefeed
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error – port_DataReceived Exception: " + ex);
            }

            // invoke the delegate in the MainForm thread
            this.Invoke(setText);
        }
        // create the instance of the delegate to be used to write the received data to
        // the richTextBox
        public void mySetText()
        {
            // Get the current date and time
            DateTime theDate;
            theDate = DateTime.Now;

            // show the timestamp and text
            rtbDeviceLog.Text += theDate.ToString() + "  " + str.ToString();
            //rtbDeviceLog.Text += str.ToString();
            moveCaretToEnd();
        }

        // This rigaramole is needed to keep the last received item displayed
        // it kind of flickers and should be fixed
        private void rtbDeviceLog_TextChanged(object sender, EventArgs e)
        {
            moveCaretToEnd();
        }
        private void moveCaretToEnd()
        {
            rtbDeviceLog.SelectionStart = rtbDeviceLog.Text.Length;
            rtbDeviceLog.SelectionLength = 0;
            rtbDeviceLog.ScrollToCaret();
        }
        #endregion
    }
}
