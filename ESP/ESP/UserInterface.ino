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
    else if((InputFromMEGA=="wifi_setup"))
    {
      Print("Uruchamiam wifi_setup");
      wifi_setup();
    }
    else{
      Print("ESP nie rozpoznaje komendy: "+InputFromMEGA);
    }
}

