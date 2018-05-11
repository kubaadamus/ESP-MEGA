#include "ESP8266WiFi.h"
#include <ESP8266HTTPClient.h>
#include <WiFiClient.h>
#include <WiFiServer.h>



String InputFromMEGA="";
void setup() {
Serial.begin(115200);
}

void loop() {

//============= E S P  C Z Y T A  Z  M E G A ==========//
while(Serial.available() > 0)
{
    int inChar = Serial.read();
    InputFromMEGA += (char)inChar;
    if (inChar == '|') 
    {
      InputFromMEGA = Przytnij(InputFromMEGA);
    //======== METODY OBSŁUGUJĄCE INPUT Z ESP=====//

    user_interface(InputFromMEGA);

    //============================================//
    InputFromMEGA="";
    }
}
//=====================================================//



}
