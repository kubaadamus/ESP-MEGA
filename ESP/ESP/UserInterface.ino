void user_interface(String InputFromMEGA)
{
    if((InputFromMEGA=="TEST"))
    {
      Print("ODPOWIADAM NA TEST");
    }
    else if((InputFromMEGA=="INFO"))
    {
      Print("PODAJĘ CENNE INFORMACJE");
    }
    else if((InputFromMEGA=="wifi_setup")) // wifi setup czyli cała procedura podłączania się do wifi
    {
      Print("Uruchamiam wifi_setup");
      wifi_setup();
    }
    else if((InputFromMEGA=="wifi_request"))
    {
      wifi_request();
    }
    else if((InputFromMEGA=="wifi_check"))
    {
      wifi_check();
    }
    else if((InputFromMEGA=="ftp_connect"))
    {
      Print("ESP odbiera z ftp" + ftp_connect());
      Print("server_request");
    }
    else if((InputFromMEGA=="server_connect"))
    {
      server_connect();
    }
    else{
      Print("ESP nie rozpoznaje komendy: "+InputFromMEGA);
    }
}



void kreska()
{
  Print("=========================================");
}

