using System.Text.Json;

namespace Zestaw12Zadanie2
{
    internal class Program
    {
        private static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            DodajDane();

            
            string json = SerializacjaJSON(students);
            Console.WriteLine("Serializowany JSON:");
            Console.WriteLine(json);

            // Zapisanie JSON do pliku
            File.WriteAllText("students.json", json);

            // Odczytanie JSON z pliku i deserializacja
            string jsonZPliku = File.ReadAllText("students.json");
            List<Student> deserializowaniStudenci = DeserializacjaJSON(jsonZPliku);

            Console.WriteLine("Deserializowani studenci:");
            foreach (var student in deserializowaniStudenci)
            {
                Console.WriteLine(student);
            }

        }

        private static void DodajDane()
        {
            var adres1 = new Adres("Ulica 1", "10", 1, "00-001", "Miasto 1");
            var adres2 = new Adres("Ulica 2", "20", 2, "00-002", "Miasto 2");

            var student1 = new Student(1, "Kowalski", "Jan", adres1, adres2);
            var student2 = new Student(2, "Nowak", "Anna", adres2, adres1);

            students.Add(student1);
            students.Add(student2);
        }

        private static string SerializacjaJSON(List<Student> students)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(students, options);
        }

        private static List<Student> DeserializacjaJSON(string json)
        {
            return JsonSerializer.Deserialize<List<Student>>(json);
        }
    }
}
