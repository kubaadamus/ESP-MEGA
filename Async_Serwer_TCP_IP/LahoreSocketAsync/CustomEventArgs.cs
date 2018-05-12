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
    public class ClientConnectedEventArgs : EventArgs
    {
        public string NewClient { get; set; }

        public ClientConnectedEventArgs(string _newClient)
        {
            NewClient = _newClient;
        }

    }

    public class TextReceivedEventArgs : EventArgs
    {
        public string ClientWhoSentText { get; set; }
        public string TextReceived { get; set; }
        public TextReceivedEventArgs(string _clientWhoSentText, string _textReceived)
        {
            ClientWhoSentText = _clientWhoSentText;
            TextReceived = _textReceived;
        }

    }

}