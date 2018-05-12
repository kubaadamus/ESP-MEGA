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
  else if(InputFromESP=="ftp_request"){ // Mega po otrzymaniu od ESP prośby o ftp, rozkazuje ESP ftp_connecta
  delay(500);
  Print("ftp_connect");
  }
  else if(InputFromESP=="server_request"){ // ESP po wczytaniu koordynatów serwera poprosi megę o pozwolenie na połączenie z serwerem
  delay(500);
  Print("server_connect");
  }
  else if(InputFromESP=="test"){ // prosty test
  delay(500);
  Print("test OK");
  Serial.println("test OK");
  }
}




void obsluga_zdarzenCOM(String InputFromCOM){

}

