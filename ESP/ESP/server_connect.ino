void server_connect()
{
String IP="";
String Port="16010";
IPAddress server(89,229,73,230);
Print("Łączę z serwerem ");
int Attempt=0;
while(!client.connect(server, Port.toInt()))
{
  Print(".");
  delay(500);
  Attempt++;
  if(Attempt>=5)
  {
    Print("CONNECTION FAILED BECAUSE OF: REASONS.");
    return;
  }
}

      Print("connected");
      client.print("ESP8266 Connected to the server");

Print("IP:");Print(IP);
Print("Port:");Print(Port);
}


