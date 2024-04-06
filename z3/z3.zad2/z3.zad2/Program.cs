namespace z3.zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod("Toyota", "2018", "Corolla", "Srebrny", new List<Wlasciciele>(), new List<Badania>());

            samochod.DodajWlasciciela(new Wlasciciele("Jan Kowalski", "ul. Wojska Polskiego 1, 00-001 Warszawa", "123456789"));
            samochod.DodajWlasciciela(new Wlasciciele("Anna Nowak", "ul. Jagiellońska 20, 30-001 Kraków", "987654321"));

            // Dodajemy badania kontrolne
            samochod.DodajBadanie(new Badania("2022-01-15", "2023-01-15", "Zatwierdzono"));
            samochod.DodajBadanie(new Badania("2023-02-20", "2024-02-20", "Zatwierdzono"));

            // Wyświetlamy dane samochodu
            Console.WriteLine("Dane samochodu:");
            Console.WriteLine(samochod);

            Console.ReadLine();
        }
    }
}
