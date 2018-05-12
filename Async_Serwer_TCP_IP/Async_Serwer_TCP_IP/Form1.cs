using System;
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
        LahoreSocketServer mServer;
        public Form1()
        {
            InitializeComponent();
            mServer = new LahoreSocketServer();

            mServer.RaiseClientConnectedEvent += HandleClientConnected;

            mServer.RaiseTextReceivedEvent += HandleTextReceived;

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
            mServer.SendToAll(("led_on").Trim());
            txtConsole.AppendText(string.Format("Sent to clients: {0}", ("led_on").ToString()));
            txtConsole.AppendText(Environment.NewLine);
            textMessage.Clear();
            textMessage.Focus();
        }

        private void LED_OFF_BTN_Click(object sender, EventArgs e)
        {
            mServer.SendToAll(("led_off").Trim());
            txtConsole.AppendText(string.Format("Sent to clients: {0}", ("led_off").ToString()));
            txtConsole.AppendText(Environment.NewLine);
            textMessage.Clear();
            textMessage.Focus();
        }

        private void Serwo_0_Click(object sender, EventArgs e)
        {
            mServer.SendToAll(("A.SERVO(" + 0 + ")").Trim());
            txtConsole.AppendText(string.Format("Sent to clients: {0}", ("A.SERVO(" + 0 + ")").ToString()));
            txtConsole.AppendText(Environment.NewLine);
            textMessage.Clear();
            textMessage.Focus();
        }

        private void Serwo_20_Click(object sender, EventArgs e)
        {
            mServer.SendToAll(("A.SERVO(" + 20 + ")").Trim());
            txtConsole.AppendText(string.Format("Sent to clients: {0}", ("A.SERVO(" + 20 + ")").ToString()));
            txtConsole.AppendText(Environment.NewLine);
            textMessage.Clear();
            textMessage.Focus();
        }

        private void Serwo_40_Click(object sender, EventArgs e)
        {
            mServer.SendToAll(("A.SERVO(" + 40 + ")").Trim());
            txtConsole.AppendText(string.Format("Sent to clients: {0}", ("A.SERVO(" + 40 + ")").ToString()));
            txtConsole.AppendText(Environment.NewLine);
            textMessage.Clear();
            textMessage.Focus();
        }

        private void Serwo_60_Click(object sender, EventArgs e)
        {
            mServer.SendToAll(("A.SERVO(" + 60 + ")").Trim());
            txtConsole.AppendText(string.Format("Sent to clients: {0}", ("A.SERVO(" + 60 + ")").ToString()));
            txtConsole.AppendText(Environment.NewLine);
            textMessage.Clear();
            textMessage.Focus();
        }

        private void Serwo_80_Click(object sender, EventArgs e)
        {
            mServer.SendToAll(("A.SERVO(" + 80 + ")").Trim());
            txtConsole.AppendText(string.Format("Sent to clients: {0}", ("A.SERVO(" + 80 + ")").ToString()));
            txtConsole.AppendText(Environment.NewLine);
            textMessage.Clear();
            textMessage.Focus();
        }

        private void Serwo_100_Click(object sender, EventArgs e)
        {
            mServer.SendToAll(("A.SERVO(" + 100 + ")").Trim());
            txtConsole.AppendText(string.Format("Sent to clients: {0}", ("A.SERVO(" + 100 + ")").ToString()));
            txtConsole.AppendText(Environment.NewLine);
            textMessage.Clear();
            textMessage.Focus();
        }

        private void Serwo_120_Click(object sender, EventArgs e)
        {
            mServer.SendToAll(("A.SERVO(" + 120 + ")").Trim());
            txtConsole.AppendText(string.Format("Sent to clients: {0}", ("A.SERVO(" + 120 + ")").ToString()));
            txtConsole.AppendText(Environment.NewLine);
            textMessage.Clear();
            textMessage.Focus();
        }

        private void Serwo_140_Click(object sender, EventArgs e)
        {
            mServer.SendToAll(("A.SERVO(" + 140 + ")").Trim());
            txtConsole.AppendText(string.Format("Sent to clients: {0}", ("A.SERVO(" + 140 + ")").ToString()));
            txtConsole.AppendText(Environment.NewLine);
            textMessage.Clear();
            textMessage.Focus();
        }

        private void Serwo_160_Click(object sender, EventArgs e)
        {
            mServer.SendToAll(("A.SERVO(" + 160 + ")").Trim());
            txtConsole.AppendText(string.Format("Sent to clients: {0}", ("A.SERVO(" + 160 + ")").ToString()));
            txtConsole.AppendText(Environment.NewLine);
            textMessage.Clear();
            textMessage.Focus();
        }

        private void Serwo_180_Click(object sender, EventArgs e)
        {
            mServer.SendToAll(("A.SERVO(" + 180 + ")").Trim());
            txtConsole.AppendText(string.Format("Sent to clients: {0}", ("A.SERVO(" + 180 + ")").ToString()));
            txtConsole.AppendText(Environment.NewLine);
            textMessage.Clear();
            textMessage.Focus();
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
    }
}
