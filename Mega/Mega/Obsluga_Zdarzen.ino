void obsluga_zdarzenESP(String InputFromESP)
{
if(InputFromESP=="ODPOWIADAM NA TEST"){
  Serial.print("Wypisuję jako MEGA:");
  Serial.println("DZIAŁA!");
}
else if(InputFromESP=="wifi_request"){
  delay(500);
  Serial.print("Wysyłam dane połączenia do ESP:");
  Print("82.160.252.229:16010");
}
}




void obsluga_zdarzenCOM(String Input){
  
}

