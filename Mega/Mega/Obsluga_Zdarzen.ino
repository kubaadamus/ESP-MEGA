void obsluga_zdarzenESP(String InputFromESP)
{
if(InputFromESP=="ODPOWIADAM NA TEST"){
  Serial.print("MEGA mówi:");
  Serial.println("DZIAŁA!");
}
else if(InputFromESP=="wifi_request"){
  delay(500);
  Serial.println("MEGA wysyła dane połączenia do ESP:"+sd_read());
  Print(sd_read());
}
}




void obsluga_zdarzenCOM(String InputFromCOM){
if(InputFromCOM=="biacz"){
Print("wifi_request");
}
}

