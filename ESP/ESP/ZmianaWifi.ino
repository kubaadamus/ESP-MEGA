void wifi_setup(){
    Print("Zmieniamy parametry wifi. Wpisz nowe SSID:");
    String ssid = ReadAsync();
    Print("Nowe SSID to: " + ssid);
    Print("Wpisz hasło sieci");
    String password = ReadAsync();
    Print("Nowe hasło to:" + password);
    Print("Zmiana parametrów wifi przebiegła pomyślnie");
}

