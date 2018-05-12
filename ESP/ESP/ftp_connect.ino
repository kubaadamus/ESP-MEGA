String URL = "http://jakubadamus.cba.pl/test.txt";
String payload = "";
String ftp_connect(){ 
  if (WiFi.status() == WL_CONNECTED) 
  { //Check WiFi connection status
    HTTPClient http;  //Declare an object of class HTTPClient
    http.begin(URL);  //Specify request destination
    int httpCode = http.GET();                                                                  //Send the request
    if (httpCode > 0) { //Check the returning code
      payload = http.getString();   //Get the request response payload
    }
    http.end();   //Close connection
  }
  return payload;
}
