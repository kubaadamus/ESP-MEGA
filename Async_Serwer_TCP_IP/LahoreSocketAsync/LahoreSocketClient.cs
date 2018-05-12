using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace LahoreSocketAsync
{
    public class LahoreSocketClient
    {

        IPAddress mServerIPAdress;
        int mServerPort;
        TcpClient mClient;


        public EventHandler<TextReceivedEventArgs> RaiseTextreceivedEvent;

        protected virtual void OnRaiseTextReveivedEvent(TextReceivedEventArgs trea)
        {
            EventHandler<TextReceivedEventArgs> handler = RaiseTextreceivedEvent;
            if(handler != null)
            {
                handler(this, trea);
            }
        }

        public LahoreSocketClient()
        {
            mClient = null;
            mServerPort = -1;
            mServerIPAdress = null;
        }
        
        public IPAddress ServerIPAddress
        {
            get
            {
                return mServerIPAdress;
            }
        }    
        public int ServerPort
        {
            get
            {
                return mServerPort;
            }
        }

        public bool SetServerIPAdress(string _IPAdressServer)
        {
            IPAddress ipaddr = null;

            if(!IPAddress.TryParse(_IPAdressServer, out ipaddr))
            {
                Console.WriteLine("Invalid server IP supplied");
                return false;
            }

            mServerIPAdress = ipaddr;

            return true;
        }

    public bool SetPortNumber(string _ServerPort)
        {
            int portNumber = 0;

            if(!int.TryParse(_ServerPort.Trim(),out portNumber))
            {
                Console.WriteLine("Invalid port number supplied, return.");
                return false;
            }

            if(portNumber <=0 || portNumber > 65535)
            {
                Console.WriteLine("Port number must be between 0 and 65535");
                return false;
            }

            mServerPort = portNumber;

            return true;
        }

        public void CloseAndDisconnect()
        {
            if (mClient !=null)
            {
                if (mClient.Connected)
                {
                    mClient.Close();
                }
            }
        }

        public async Task SendToServer(string strInputUser)
        {
            if(string.IsNullOrEmpty(strInputUser))
            {
                Console.WriteLine("Empty string supplied to send.");
                return;
            }

            if(mClient != null)
            {
                if(mClient.Connected)
                {
                    StreamWriter clientStreamWriter = new StreamWriter(mClient.GetStream());
                    clientStreamWriter.AutoFlush = true;

                    await clientStreamWriter.WriteAsync(strInputUser);
                    Console.WriteLine("Data sent..."+strInputUser);
                }
            }
        }

        public async Task ConnectToServer()
        {
            if(mClient == null)
            {
                mClient = new TcpClient();
            }

            try
            {
                await mClient.ConnectAsync(mServerIPAdress,mServerPort);
                Console.WriteLine("Connected to server IP/PORT {0} / {1}",mServerIPAdress,mServerPort);

                ReadDataAsync(mClient);

            }
            catch (Exception excp)
            {

                Console.WriteLine(excp);
                throw;
            }
        }

        private async Task ReadDataAsync(TcpClient mClient)
        {
            try
            {
                StreamReader clientStreamReader = new StreamReader(mClient.GetStream());
                char[] buff = new char[20000];
                long readByteCount = 0;

                while(true)
                {
                    readByteCount = await clientStreamReader.ReadAsync(buff, 0, buff.Length);

                    if(readByteCount <=0 )
                    {
                        Console.WriteLine("Disconnected grom the server.");
                        mClient.Close();
                        break;
                    }
                    Console.WriteLine(string.Format("Received bytes: {0} - Message: {1}", readByteCount, new string(buff)));

                    OnRaiseTextReveivedEvent(new TextReceivedEventArgs(mClient.Client.RemoteEndPoint.ToString(), new string(buff)));

                    Array.Clear(buff,0,buff.Length);
                }
            }
            catch (Exception excp)
            {

                Console.WriteLine(excp.ToString());
                throw;
            }
        }
    }
}
