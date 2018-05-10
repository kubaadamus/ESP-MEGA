String wifi_coordinates_array[2];
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
}

