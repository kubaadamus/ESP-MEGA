//POŁĄCZENIE WIFI//
String host="";
String dataClient;
String dataServer;
bool ServerSend=false;
bool ServerReceive=false;
WiFiClient client;
WiFiServer server(16010);


String wifi_coordinates_array[2];
char* ssid;
char* password;

void wifi_connect(String wifi_coordinates){
  

  for(int i=0; i<2; i++){wifi_coordinates_array[i]="";}

  int index=0;
  for(int i=0; i<wifi_coordinates.length(); i++) // przelec przez całe wifi coordinates
  {
    if(wifi_coordinates[i]=='.' || wifi_coordinates[i]==':')
    {
      index++;
    }
    else{
      wifi_coordinates_array[index]+=wifi_coordinates[i];
    }
  }

  Print("Lacze z wifi za pomoca danych:");

  for(int i=0; i<2; i++)
  {
    Print(wifi_coordinates_array[i]);
  }

  wifi_coordinates_array[0].toCharArray(ssid, wifi_coordinates_array[0].length());
  wifi_coordinates_array[0].toCharArray(password, wifi_coordinates_array[1].length());
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) 
  {
    delay(500);
    Print(".");
  }
    Print("Połączono");
    Print(WiFi.localIP());
}

void wifi_check()
{
  kreska();
  Print("Połączono");
  Print(WiFi.localIP());
  kreska();
}
