void obsluga_zdarzenESP(String InputFromESP)
{
if(InputFromESP=="ODPOWIADAM NA TEST"){
  Serial.print("MEGA mówi:");
  Serial.println("DZIAŁA!");
}
  else if(InputFromESP=="wifi_request"){
  Serial.println("MEGA wysyła dane połączenia do ESP:"+sd_read());
  Print(sd_read());
  }
  else if(InputFromESP=="ftp_request"){ // Mega po otrzymaniu od ESP prośby o ftp, rozkazuje ESP ftp_connecta
  Print("ftp_connect");
  }
  else if(InputFromESP=="server_request"){ // ESP po wczytaniu koordynatów serwera poprosi megę o pozwolenie na połączenie z serwerem
  Print("server_connect");
  }
  else if(InputFromESP=="test"){ // prosty test
  Print("test OK");
  Serial.println("test OK");
  }

  else if(InputFromESP=="led_on"){ // prosty test
  digitalWrite(LED_BUILTIN,HIGH);
  Print("Zapalam leda");
  }
  else if(InputFromESP=="led_off"){ // prosty test
  digitalWrite(LED_BUILTIN,LOW);
  Print("Gaszę leda");
  }
}




void obsluga_zdarzenCOM(String InputFromCOM){

}

