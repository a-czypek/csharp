
using serializacja;
using System.Text.Json;
using System;

Auto[] samochod = 
{
    new Auto("Toyota", "Yaris", 2016, "Red", 37000.50 ),
    new Auto("Peukot", "200", 2012, "Blue", 12345.67),
    new Auto("Tesla", "Model X", 2023, "Pink", 238920.58)
};


// Serializacja danych do JSON z ładnym formatowaniem
string jsonString = JsonSerializer.Serialize(samochod, new JsonSerializerOptions { WriteIndented = true });

// Zapis danych do pliku JSON
File.WriteAllText("samochod.json", jsonString);
Console.WriteLine("Dane zapisane do pliku samochod.json");

// Odczyt danych z pliku JSON
string jsonStringFromFile = File.ReadAllText("samochod.json");

Auto[] deserializedSamochod = JsonSerializer.Deserialize<Auto[]>(jsonStringFromFile);

// Wyświetlanie zdeserializowanych danych
Console.WriteLine("\nDeserializowane dane:");
foreach (var auto in deserializedSamochod)
{
    Console.WriteLine(auto.ToString());
}


