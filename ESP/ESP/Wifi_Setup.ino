void wifi_setup(){
    Print("Zmieniamy parametry wifi. Wpisz nowe SSID:");
    String ssid = read_async();
    Print("Nowe SSID to: " + ssid);
    Print("Wpisz hasło sieci");
    String password = read_async();
    Print("Nowe hasło to:" + password);
    Print("Zmiana parametrów wifi przebiegła pomyślnie");
}

void wifi_request(){
  Print("wifi_request"); // poproś megę o dane
  String wifi_coordinates = read_async();
  Print("Otrzymalem koordynaty wifi");
  wifi_connect(wifi_coordinates);
}
