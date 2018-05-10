void wifi_request(){
  Print("wifi_request"); // poproś megę o dane
  String wifi_coordinates = read_async();
  Print("Otrzymalem koordynaty wifi");
  wifi_connect(wifi_coordinates);
}

