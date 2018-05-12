int a,b,c,d=0;
String Port="";
String server_coordinates_array_string[5];
int server_coordinates_array_int[5];
String InputFromHttp;
IPAddress server(0,0,0,0);
void server_connect()
{


Print("ESP pobrało InputFromHttp: "+InputFromHttp);

get_coordinates_from_ftp();


Print("Łączę z serwerem ");
int Attempt=0;
while(!client.connect(server, Port.toInt()))
{
  Print(".");
  delay(1000);
  Attempt++;

        //CO około 5 minut ATTEMPTÓW POBIERZ Z SIECI NOWE KOORDYNATY SERWERA//
      if(Attempt>=10)
      {
        Print("Pobieram nowe koordynaty z serwera");
        get_coordinates_from_ftp();
        Attempt=0;
      }
}

      Print("connected");
      client.print("ESP8266 Connected to the server");
      delay(500);
      server_read();




}


void get_coordinates_from_ftp()
{
  InputFromHttp = ftp_connect();
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


a=server_coordinates_array_int[0];
b=server_coordinates_array_int[1];
c=server_coordinates_array_int[2];
d=server_coordinates_array_int[3];


Port=String(server_coordinates_array_int[4]);
server[0]=a;
server[1]=b;
server[2]=c;
server[3]=d;
}
