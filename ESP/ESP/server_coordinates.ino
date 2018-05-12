String server_coordinates_array_string[5];
int server_coordinates_array_int[5];
void server_coordinates()
{
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


}





