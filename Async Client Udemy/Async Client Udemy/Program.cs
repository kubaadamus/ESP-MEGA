using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LahoreSocketAsync;

namespace Async_Client_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            LahoreSocketClient client = new LahoreSocketClient();
            client.RaiseTextreceivedEvent += HandleTextReceived;

            Console.WriteLine("Welcome to socket Client Starter Eample :D");
            Console.WriteLine("Please type a valid server IP Address and press enter");

            string strIPAddress = "89.228.240.20";//Console.ReadLine();



            Console.WriteLine("Please Supply a Valid port Number 0 - 65335 and press Enter: ");
            string strPortInput = "16010";//Console.ReadLine();
            

            if (!client.SetServerIPAdress(strIPAddress) || !client.SetPortNumber(strPortInput))
            {
                Console.WriteLine("Wront IP Address or port nymber suppliet - {0} - {1} - Press a ke y to exit", strIPAddress, strPortInput);
                Console.ReadKey();
                return;
            }

            client.ConnectToServer();


            string strInputUser = null;
            
            do
            {
                strInputUser = Console.ReadLine();
                if (strInputUser.Trim() != "<EXIT>")
                {
                    client.SendToServer(strInputUser);
                }
                else if(strInputUser.Equals("<EXIT>"))
                {
                    client.CloseAndDisconnect();
                }

            } while (strInputUser!="<EXIT>");


        }

        private static void HandleTextReceived(object sender, TextReceivedEventArgs trea)
        {
            //Console.WriteLine(trea.TextReceived);
        }
    }
}
