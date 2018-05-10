String wifi_coordinates_array[5];
void wifi_connect(String wifi_coordinates){
  Print("Lacze z wifi za pomoca danych:"+wifi_coordinates);

  for(int i=0; i<5; i++){wifi_coordinates_array[i]="";}

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

  Print("Wypisuje tabele coordinatow");

  for(int i=0; i<5; i++)
  {
    Print(wifi_coordinates_array[i]);
  }
}

