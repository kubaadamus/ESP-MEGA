using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;

namespace LahoreSocketAsync
{
    public class LahoreSocketServer
    {
        IPAddress mIP;
        int mPort;

        TcpListener mTCPListener;

        List<TcpClient> mClients;

        public EventHandler<ClientConnectedEventArgs> RaiseClientConnectedEvent;

        public EventHandler<TextReceivedEventArgs> RaiseTextReceivedEvent;

        protected virtual void OnRaiseClientConnectedEvent(ClientConnectedEventArgs e)
        {
            EventHandler<ClientConnectedEventArgs> handler = RaiseClientConnectedEvent;

            if(handler != null
                )
            {
                handler(this, e);
            }
        }

        protected virtual void OnRaiseTextReceivedEvent(TextReceivedEventArgs trea)
        {
            EventHandler<TextReceivedEventArgs> handler = RaiseTextReceivedEvent;

            if (handler != null
                )
            {
                handler(this, trea);
            }
        }

        public bool KeepRunning { get; set; }

        public LahoreSocketServer()
        {
            mClients = new List<TcpClient>();
        }

        public async void StartListeningForIncomingConnection(IPAddress ipaddr = null, int port = 16010)
        {
            if(ipaddr == null)
            {
                ipaddr = IPAddress.Any;
            }
            if (port <=0)
            {
                port = 16010;
            }

            mIP = ipaddr;
            mPort = port;

            System.Diagnostics.Debug.WriteLine(string.Format("IP Address: {0} - Port: {1}", mIP.ToString(), mPort.ToString()));

            mTCPListener = new TcpListener(mIP, mPort);

            try
            {

                mTCPListener.Start();

                KeepRunning = true;
                while (KeepRunning)
                {
                    var returnedByAccept = await mTCPListener.AcceptTcpClientAsync();

                    mClients.Add(returnedByAccept);

                    Debug.WriteLine("Client Connected Succesfully, count: {0} - {1}",mClients.Count, returnedByAccept.Client.RemoteEndPoint);

                    TakeCareOfTCPClient(returnedByAccept);

                    ClientConnectedEventArgs eaClientConnected;
                    eaClientConnected = new ClientConnectedEventArgs(returnedByAccept.Client.RemoteEndPoint.ToString());
                    OnRaiseClientConnectedEvent(eaClientConnected);
                }
            }
            catch(Exception excp)
            {
                System.Diagnostics.Debug.WriteLine(excp);
            }


        }

        public void StopServer()
        {
            try
            {
                if (mTCPListener != null)
                {
                    mTCPListener.Stop();
                }
                foreach(TcpClient c in mClients)
                {
                    c.Close();
                }

                mClients.Clear();
            }
            catch (Exception excp)
            {

                Debug.WriteLine(excp);
            }
        }

        private async void TakeCareOfTCPClient(TcpClient paramClient)
        {
            NetworkStream stream = null;

            StreamReader reader = null;

            try
            {
                stream = paramClient.GetStream();

                reader = new StreamReader(stream);

                char[] buff = new char[64];

                while(KeepRunning)
                {
                    Debug.WriteLine("*** Ready to read");

                    int nRet = await reader.ReadAsync(buff,0,buff.Length);

                    Debug.WriteLine("Returned: " + nRet);

                    if(nRet ==0)
                    {
                        RemoveClient(paramClient);
                        Debug.WriteLine("Socket disconnected");
                        break;
                    }

                    string receivedText = new string(buff);

                    //EKSPERYMENT

                    Debug.WriteLine(receivedText);

                    
                    

                    

                    OnRaiseTextReceivedEvent(new TextReceivedEventArgs(paramClient.Client.RemoteEndPoint.ToString(), receivedText));
                    Array.Clear(buff, 0, buff.Length);
                }
            }
            catch(Exception excp)
            {
                RemoveClient(paramClient);
                System.Diagnostics.Debug.WriteLine(excp);
            }
        }

        private void RemoveClient(TcpClient paramClient)
        {
            if(mClients.Contains(paramClient))
            {
                mClients.Remove(paramClient);
                Debug.WriteLine(string.Format("Client removed, count {0}", mClients.Count));
            }
        }

        public async void SendToAll (string leMessage)
        {
            if(string.IsNullOrEmpty(leMessage))
            {
                return;
            }
            try
            {
                byte[] buffMessage = Encoding.ASCII.GetBytes(leMessage);
                foreach(TcpClient c in mClients)
                {
                    c.GetStream().WriteAsync(buffMessage,0,buffMessage.Length);
                }
            }
            catch(Exception excp)
            {
                Debug.WriteLine(excp.ToString());
            }
        }
    }
}
