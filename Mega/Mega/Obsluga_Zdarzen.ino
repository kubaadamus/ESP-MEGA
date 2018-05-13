void obsluga_zdarzenESP(String InputFromESP)
{

//========================================= P O D S T A W O W E   K O M E N D Y ====================================//
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
//========================================= R E A K C J E  ====================================//

//===== L E D  B U I L T I N =======//
  else if(InputFromESP=="led_on"){ // prosty test
  digitalWrite(LED_BUILTIN,HIGH);
  Print("Zapalam leda");
  }
  else if(InputFromESP=="led_off"){ // prosty test
  digitalWrite(LED_BUILTIN,LOW);
  Print("Gaszę leda");
  }

//===== S E R V O =======//
  else if(zawiera(InputFromESP,"srv:")){
  InputFromESP.remove(0,4);
  s1.write(InputFromESP.toInt());

  analogWrite(7,InputFromESP.toInt());
  }
}




void obsluga_zdarzenCOM(String InputFromCOM){

}

