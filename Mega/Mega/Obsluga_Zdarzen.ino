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
digitalWrite(LED_BUILTIN,InputFromESP.substring(5,6).toInt());
//===== S E R V O =======//


  s1.write(InputFromESP.substring(0,1).toInt()*20);
  s2.write(InputFromESP.substring(1,2).toInt()*20);
  s3.write(InputFromESP.substring(2,3).toInt()*20);
  s4.write(InputFromESP.substring(3,4).toInt()*20);
  s5.write(InputFromESP.substring(4,5).toInt()*20);

}




void obsluga_zdarzenCOM(String InputFromCOM){

}

