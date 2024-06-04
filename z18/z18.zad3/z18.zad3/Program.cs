using System.Text.Json;
using System.Xml;
using z18.zad3;

List<Prostopadloscian> pudelka = new List<Prostopadloscian>();

pudelka.Add(new Prostopadloscian(2, 3, 4));
pudelka.Add(new Prostopadloscian(5, 6, 7));

string plikSciezka = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "prostopadlosciany.json");
try
{
    string jsonString = JsonSerializer.Serialize(pudelka, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText(plikSciezka, jsonString);
    Console.WriteLine($"Lista prostopadłościanów została zapisana do pliku {plikSciezka}");
}
catch (Exception e)
{
    Console.WriteLine($"Wystąpił błąd podczas zapisywania pliku: {e.Message}");
}

// Deserializacja danych z pliku JSON
try
{
    string jsonString = File.ReadAllText(plikSciezka);
    List<Prostopadloscian> wczytaneProstopadlosciany = JsonSerializer.Deserialize<List<Prostopadloscian>>(jsonString);
    Console.WriteLine("Pomyślnie wczytano prostopadłościany z pliku:");
    foreach (var p in wczytaneProstopadlosciany)
    {
        Console.WriteLine($"Długość: {p.Dlugosc}, Szerokość: {p.Szerokosc}, Wysokość: {p.Wysokosc}");
    }
}
catch (Exception e)
{
    Console.WriteLine($"Wystąpił błąd podczas wczytywania pliku: {e.Message}");
}


