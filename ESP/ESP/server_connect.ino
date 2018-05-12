void server_connect()
{
IPAddress server(0,0,0,0);
//FUNKCJA SERVER COORDINATES
String server_coordinates_array_string[5];
int server_coordinates_array_int[5];
String InputFromHttp = ftp_connect();

Print("ESP pobrało InputFromHttp: "+InputFromHttp);

for(int i=0; i<5; i++){server_coordinates_array_string[i]=""; server_coordinates_array_int[i]=0;}

  int index=0;
  for(int i=0; i<InputFromHttp.length(); i++) // przelec przez całego stringa InputFromHttp
  {
    if(InputFromHttp[i]=='.' || InputFromHttp[i]==':')
    {
      index++;
    }
    else{
      server_coordinates_array_string[index]+=InputFromHttp[i];
    }
  }


for(int i=0; i<5; i++){
  server_coordinates_array_int[i] = server_coordinates_array_string[i].toInt();
  delay(100);
  Print("ESP operuje na danych: "); Print(server_coordinates_array_int[i]);
}

//===============================


int a=server_coordinates_array_int[0];
int b=server_coordinates_array_int[1];
int c=server_coordinates_array_int[2];
int d=server_coordinates_array_int[3];


String Port=String(server_coordinates_array_int[4]);
server[0]=a;
server[1]=b;
server[2]=c;
server[3]=d;
Print("Łączę z serwerem ");
int Attempt=0;
while(!client.connect(server, Port.toInt()))
{
  Print(".");
  delay(1000);
  Attempt++;
}

      Print("connected");
      client.print("ESP8266 Connected to the server");
      

      delay(500);
      server_read();

}


