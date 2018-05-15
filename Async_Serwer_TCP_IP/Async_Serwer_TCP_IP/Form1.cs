using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LahoreSocketAsync;

namespace Async_Serwer_TCP_IP
{

    public partial class Form1 : Form
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static int alarmCounter = 1;
        static bool exitFlag = false;
        Random rand = new Random();

        int[] TablicaDlaArduino = new int[60];

        private void TimerEventProcessor(Object myObject,
                                        EventArgs myEventArgs)
        {
            if(checkBox1.Checked)
            {
                WyslijDoArduino();
            }
           
        }





        LahoreSocketServer mServer;
        public Form1()
        {
            InitializeComponent();
            mServer = new LahoreSocketServer();

            mServer.RaiseClientConnectedEvent += HandleClientConnected;

            mServer.RaiseTextReceivedEvent += HandleTextReceived;

            /* Adds the event and the event handler for the method that will 
          process the timer event to the timer. */
            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = 300;
            myTimer.Start();

        }

        private void btnAcceptIncomingAsync_Click(object sender, EventArgs e)
        {
            mServer.StartListeningForIncomingConnection();
        }

        private void btnSenAll_Click(object sender, EventArgs e)
        {
            mServer.SendToAll(textMessage.Text.Trim());
            txtConsole.AppendText(string.Format("Sent to clients: {0}", textMessage.Text.ToString()));
            txtConsole.AppendText(Environment.NewLine);
            textMessage.Clear();
            textMessage.Focus();
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            mServer.StopServer();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mServer.StopServer();
        }

        void HandleClientConnected(object sender, ClientConnectedEventArgs ccea)
        {
            txtConsole.AppendText(string.Format("{0} - New client connected: {1}{2}", DateTime.Now, ccea.NewClient, Environment.NewLine));
        }

        void HandleTextReceived(object sender, TextReceivedEventArgs trea)
        {
            if(trea.TextReceived.Substring(0, trea.TextReceived.IndexOf('\0'))!= "status_check")
            {
                txtConsole.AppendText(string.Format("{0} - Received from: {3}, {1}{2}", DateTime.Now, trea.TextReceived, Environment.NewLine, trea.ClientWhoSentText));
                txtConsole.AppendText(Environment.NewLine);


                String TEKST_Z_ARDUINO = trea.TextReceived.Replace("\0", "");








            }

            //EKSPERYMENT

            if (trea.TextReceived.IndexOf('\0') > 0)
            {
                
                string chuj = trea.TextReceived.Substring(0, trea.TextReceived.IndexOf('\0'));
                

                if (chuj == "status_check")
                {
                    if(StatusCheckBox.Checked)
                    {
                        SendDataToClient("ok", true);
                    }
                    else
                    {
                        SendDataToClient("ok", false);
                    }
                        
                }
            }
        }
        private void SendDataToClient(string Data, bool AppendToTextConsole)
        {
            mServer.SendToAll((Data).Trim());
            if(AppendToTextConsole)
            {
                txtConsole.AppendText(string.Format("Sent to clients: {0}", (Data).ToString()));
                txtConsole.AppendText(Environment.NewLine);
            }
        }
        private void LED_ON_BTN_Click(object sender, EventArgs e)
        {
            TablicaDlaArduino[5] = 1;
        }

        private void LED_OFF_BTN_Click(object sender, EventArgs e)
        {
            TablicaDlaArduino[5] = 0;
        }

        private void txtConsole_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            mServer.SendToAll(("A.PIEZO(" + hScrollBar1.Value*110 + ")").Trim());
            txtConsole.AppendText(string.Format("Sent to clients: {0}", ("A.PIEZO(" + hScrollBar1.Value*110 + ")").ToString()));
            txtConsole.AppendText(Environment.NewLine);
            textMessage.Clear();
            textMessage.Focus();
        }

        private void WyslijDoArduino()
        {
            string result = string.Join("", TablicaDlaArduino);
            mServer.SendToAll(result);
            txtConsole.AppendText(string.Format("Sent to clients: {0}", (result)));
            txtConsole.AppendText(Environment.NewLine);
            textMessage.Clear();
            textMessage.Focus();
        }

        private void hScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            myTimer.Interval = hScrollBar2.Value;
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            TablicaDlaArduino[0] = vScrollBar1.Value;
           
        }

        private void vScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            TablicaDlaArduino[1] = vScrollBar2.Value;
        }

        private void vScrollBar3_ValueChanged(object sender, EventArgs e)
        {
            TablicaDlaArduino[2] = vScrollBar3.Value;
        }

        private void vScrollBar4_ValueChanged(object sender, EventArgs e)
        {
            TablicaDlaArduino[3] = vScrollBar4.Value;
        }

        private void vScrollBar5_ValueChanged(object sender, EventArgs e)
        {
            TablicaDlaArduino[4] = vScrollBar5.Value;
        }
    }
}
