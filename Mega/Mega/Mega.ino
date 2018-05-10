String InputFromESP="";
String InputFromCOM="";
void setup() {
Serial1.begin(115200);
Serial.begin(115200);

pinMode(LED_BUILTIN,OUTPUT);
}

void loop() {


//============= M E G A  C Z Y T A  Z  E S P ==========//
while(Serial1.available() > 0)
{
    int inChar = Serial1.read();
    InputFromESP += (char)inChar;
    if (inChar == '|') 
    {
    InputFromESP = Przytnij(InputFromESP);
    Serial.print("Odbieram z ESP:");
    Serial.println(InputFromESP);
    //======== METODY OBSŁUGUJĄCE INPUT Z ESP=====//
    if(InputFromESP=="ODPOWIADAM NA TEST"){
      Serial.print("Wypisuję jako MEGA:");
      Serial.println("DZIAŁA!");
    }

    //============================================//
    InputFromESP="";
    }
}
//=====================================================//
while(Serial.available() > 0)
{
    int inChar = Serial.read();
    InputFromCOM += (char)inChar;
    if (inChar == '\n') 
    {
    Serial.print("Przesyłam do ESP:");
    Serial.println(InputFromCOM);
    //======== METODY OBSŁUGUJĄCE INPUT Z ESP=====//
      Print(InputFromCOM);
    //============================================//
    InputFromCOM="";
    }
}

}
