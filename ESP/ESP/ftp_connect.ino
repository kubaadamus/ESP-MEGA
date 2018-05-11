
String payload = "";
String ftp_connect(){ 

  Print("ESP wszedł w ftp_connect");
  if (WiFi.status() == WL_CONNECTED) 
  { //Check WiFi connection status
 
    HTTPClient http;  //Declare an object of class HTTPClient
 Print("ESP zadeklarował dokument html");
    http.begin("http://jakubadamus.cba.pl/test.txt");  //Specify request destination
    int httpCode = http.GET();                                                                  //Send the request
 Print("ESP wykonał http.get");
    if (httpCode > 0) { //Check the returning code
 Print("httpCpde > 0");
      payload = http.getString();   //Get the request response payload
      //Serial.println(payload);                     //Print the response payload
 Print("ESP wykonał http.getString");
    }
 
    http.end();   //Close connection
 Print("ESP zakonczył http");
  }

  return payload;

  
}

