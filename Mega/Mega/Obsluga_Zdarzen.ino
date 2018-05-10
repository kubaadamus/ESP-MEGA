void obsluga_zdarzenESP(String InputFromESP)
{
if(InputFromESP=="ODPOWIADAM NA TEST"){
  Serial.print("MEGA mówi:");
  Serial.println("DZIAŁA!");
}
else if(InputFromESP=="wifi_request"){
  delay(500);
  Serial.print("MEGA wysyła dane połączenia do ESP:");
  Print("82.160.252.229:16010");
}
}




void obsluga_zdarzenCOM(String InputFromCOM){
if(InputFromCOM=="biacz"){
Print("wifi_request");
}
}

