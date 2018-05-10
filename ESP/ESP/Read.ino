String ReadAsync()
{
String InputRead="";
while(true)
{
  while(Serial.available() > 0)
  {
    int inChar = Serial.read();
    InputRead += (char)inChar;
    if (inChar == '|') 
    {
      InputRead = Przytnij(InputRead);
      //=============================TUTAJ RÓB RZECZY Z INPUTEM==============//
      return InputRead;
      InputRead="";
    }
  }
  
}
}
