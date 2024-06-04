namespace z13.zad2
{ 
    internal class Program
    {
        public static List<Produkt> listaProduktu = new List<Produkt>();
        
        static void Main(string[] args)
        {
            ZaladujListe();

            // Zadanie 1
            // Z listy listaProduktu wybierz ProduktNazwa oraz WartoscBrutto

            var wynik = from x in listaProduktu
                        select new {nazwa = x.ProduktNazwa, WartoscBrutto = x.ProduktVAT * x.ProduktCenaNetto + x.ProduktCenaNetto };

            Console.WriteLine("Wybieranie nazwy produktu oraz jego wartości brutto");

            foreach(var x in wynik)
            {
                Console.WriteLine($"Nazwa {x.nazwa,-5}, cena brutto {x.WartoscBrutto}");
            }
            Console.WriteLine();


            // Zadanie 2
            // Z listy listaProduktu wybierz ProduktID, ProduktNazwa
            // produktów których ProduktCenaNetto jest w przedziale [100, 200]
            // wynik uporządkuj malejąco według ProduktCenaNetto

            var wynik2 = from x in listaProduktu
                         where x.ProduktCenaNetto >= 100 || x.ProduktCenaNetto <= 200
                         orderby x.ProduktCenaNetto descending
                         select new { id = x.ProduktID, nazwa = x.ProduktNazwa, cena = x.ProduktCenaNetto};

            Console.WriteLine("Produkt ID oraz nazwa produktu, malejąco według ceny");

            foreach(var x in wynik2)
            {
                Console.WriteLine($"{x.id, -3} {x.nazwa, -20} {x.cena, -6}");
            }


            // Zadanie 3
            // Korzystając z danych zgromadzonych na liście listaProduktu
            // ustal ile produktów liczą grupy utworzone na podstawie wysokości podatku VAT
            // Jako wynik zwróć wysokość VAT oraz liczbę produktów

            var wynik3 = from x in listaProduktu
                         group x by x.ProduktVAT into category
                         select new { ca = category.Key, ki = category.Count() };

            Console.WriteLine();
            Console.WriteLine("Ile produktów ma dany vat");
            foreach(var x in wynik3)
            {
                Console.WriteLine($"Kategoria: {x.ca}    ile: {x.ki}");
            }
            Console.WriteLine();


            // Zadanie 4
            // Z danych zgromadzonych na liście listaProduktu
            // wybierz produkty których ProduktID znajdują się w tablicy tablicaID

            int[] tablicaID = { 7, 11, 23, 33, 88 };

            var wynik4 = from x in listaProduktu
                         where tablicaID.Contains(x.ProduktID)
                         select new { id = x.ProduktID, nazwa = x.ProduktNazwa };

            Console.WriteLine();
            Console.WriteLine("Produkty zgromadzone na liście, ktorych id znajduje sie w tablicyID");
            foreach (var x in wynik4)
            {
                Console.WriteLine($"{x.id,-4} {x.nazwa, -17}");
            }



            // Zadanie 5
            // Z danych zgromadzonych na liście listaProduktu
            // wybierz produkty które w nazwie zawierają tekst "LCD"

            var wynik5 = from x in listaProduktu
                         where x.ProduktNazwa.Contains("LCD")
                         select x.ProduktNazwa;

            Console.WriteLine();
            Console.WriteLine("Produkty, które zawierają 'LCD'");
            foreach(var x in wynik5)
            {
                Console.WriteLine(x);
            }

        }

        public static void ZaladujListe()
        {
            listaProduktu.Add(new Produkt(1, "Monitor LCD 21\"", 500.0m, 0.22m));
            listaProduktu.Add(new Produkt(31, "Monitor LCD 27\"", 1500.0m, 0.22m));
            listaProduktu.Add(new Produkt(32, "Monitor LCD 32\"", 1750.0m, 0.22m));
            listaProduktu.Add(new Produkt(2, "Mysz", 50.0m, 0.22m));
            listaProduktu.Add(new Produkt(3, "Kamera", 100.0m, 0.22m));
            listaProduktu.Add(new Produkt(4, "Klawiatura", 75.0m, 0.22m));
            listaProduktu.Add(new Produkt(5, "Dysk przenośny 128", 300.0m, 0.22m));
            listaProduktu.Add(new Produkt(6, "Dysk przenośny 256", 350.0m, 0.22m));
            listaProduktu.Add(new Produkt(7, "Dysk przenośny 512", 500.0m, 0.22m));
            listaProduktu.Add(new Produkt(8, "Mleko", 4.0m, 0.05m));
            listaProduktu.Add(new Produkt(9, "Ser", 10.0m, 0.05m));
            listaProduktu.Add(new Produkt(10, "Makaron", 12.0m, 0.05m));
            listaProduktu.Add(new Produkt(11, "Kefir", 5.0m, 0.05m));
            listaProduktu.Add(new Produkt(12, "Śpichy", 20.0m, 0.0m));
            listaProduktu.Add(new Produkt(13, "Koszulka", 30.0m, 0.0m));
            listaProduktu.Add(new Produkt(14, "Skarpetki", 15.0m, 0.0m));
            listaProduktu.Add(new Produkt(15, "Czapka", 20.0m, 0.0m));
            listaProduktu.Add(new Produkt(16, "Zegar LCD", 100.0m, 0.22m));
            listaProduktu.Add(new Produkt(17, "Termometr", 150.0m, 0.22m));
            listaProduktu.Add(new Produkt(18, "Radio kuchenne", 350.0m, 0.22m));
            listaProduktu.Add(new Produkt(19, "Radio", 500.0m, 0.22m));
            listaProduktu.Add(new Produkt(20, "Radio budzik", 250.0m, 0.22m));
            listaProduktu.Add(new Produkt(21, "Projektor", 1500.0m, 0.22m));
            listaProduktu.Add(new Produkt(22, "Śmietana", 10.0m, 0.05m));
            listaProduktu.Add(new Produkt(23, "Serek", 12.0m, 0.05m));
            listaProduktu.Add(new Produkt(24, "Pieluchy", 50.0m, 0.0m));
            listaProduktu.Add(new Produkt(25, "Woda gazowana", 2.5m, 0.05m));
            listaProduktu.Add(new Produkt(26, "Piwo", 5.0m, 0.22m));
            listaProduktu.Add(new Produkt(27, "Chleb", 5.5m, 0.05m));
            listaProduktu.Add(new Produkt(28, "Bułka", 1.0m, 0.05m));
            listaProduktu.Add(new Produkt(29, "Pamięć RAM", 100.0m, 0.22m));
            listaProduktu.Add(new Produkt(30, "Pamięć ROM", 50.0m, 0.22m));
        }
    }
}
