String InputRead="";

void server_read()
{
  String InputFromServer="";
  while(InputFromServer!="server_send_stop")
  {
    InputFromServer = "";
    while(client.available() > 0)
    {
      char inChar = char(client.read());
      InputFromServer += (char)inChar;
    }
    if(InputFromServer!="")
    {
      Print(InputFromServer);
    }

    //Jesli w czasie trwanie tej pętli dostaniesz coś od arduino to przekaż to do serwera
  while(Serial.available() > 0)
  {
    int inChar = Serial.read();
    InputRead += (char)inChar;
    if (inChar == '|') 
    {
      InputRead = Przytnij(InputRead);
      //=============================TUTAJ RÓB RZECZY Z INPUTEM==============//
      client.print(InputRead);
      InputRead="";
    }
  } 

if (!client.connected()) {
    Print("disconnected_from_server, reconnecting...");
    server_connect();
    delay(1000);
}

  
  } 
}





