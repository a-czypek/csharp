using System.Security.Cryptography;

namespace z13.zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            przyklad1();
            przyklad2();
            przyklad3();
            przyklad4();
            przyklad5();
        }

        public static void przyklad1()
        {
            int[] tablicaDanych = new int[1000];

            Random random = new Random();

            for (int i = 0; i < tablicaDanych.Length; i++)
            {
                tablicaDanych[i] = random.Next(0, 1000);
            }

            // Zadanie 1
            // Z tablicy tablicaDanych
            // wybierz wszystkie wartości mniejsze od 10

            var wynik = from x in tablicaDanych
                        where x < 10
                        select x;

            Console.WriteLine("Wypisz liczby mniejsze niż 10");
            foreach (int x in wynik)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
        }

        public static void przyklad2()
        {
            string[] imiona =
            {
                "Jan", "Adam", "Ada", "Adela", "Adelajda", "Adrianna", "Agata", "Agnieszka", "Aldona", 
                "Aleksandra", "Alicja", "Alina", "Amanda", "Amelia", "Anastazja", "Andżelika", "Aneta",
                "Anita", "Anna", "Antonina", "Bartłomiej", "Bartosz", "Benedykt", "Beniamin", "Bernard",
                "Błażej", "Bogdan", "Bogumił", "Bogusław", "Bolesław", "Borys", "Bronisław", "Adam",
                "Adolf", "Adrian", "Albert", "Aleksander", "Aleksy", "Alfred", "Amadeusz", "Andrzej",
                "Antoni", "Arkadiusz", "Arnold", "Artur", "Barbara", "Beata", "Berenika", "Bernadeta",
                "Blanka", "Bogusława", "Bożena", "Cecylia", "Celina", "Czesława", "Cezary", "Cyprian",
                "Cyryl", "Czesław", "Dagmara", "Danuta", "Daria", "Diana", "Dominika", "Dorota", "Damian",
                "Daniel", "Dariusz", "Dawid", "Dionizy", "Dominik", "Donald", "Edyta", "Eliza", "Elwira",
                "Elżbieta", "Emilia", "Eugenia", "Ewa", "Ewelina" 
            };

            // Zadanie 2
            // Z tablicy imiona
            // wybierz wszystkie imiona o długosci 5 znaków

            var wynik = from x in imiona
                        where x.Length == 5
                        select x;

            Console.WriteLine();
            Console.WriteLine("Imiona o długości 5 liter");
            foreach(string x in wynik)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
        }

        public static void przyklad3()
        {
            List<Punkt> listaPunktow = new List<Punkt>();

            Random random = new Random();

            for (int i = 0; i< 1000; i++)
            {
                listaPunktow.Add(new Punkt(random.NextSingle() * 1000, random.NextSingle() * 1000));
            }

            // Zadanie 3
            // Z listy listaPunktow
            // wybierz wszystkie punkty których wzpólrzędne X i Y 
            // znajduja się w przedziale [100, 200]

            var punktyWPrzedziale = listaPunktow.Where(punkt =>
            punkt.X >= 100 && punkt.X <= 200 &&
            punkt.Y >= 100 && punkt.Y <= 200);

            Console.WriteLine();
            foreach (var punkt in punktyWPrzedziale)
            {
                Console.WriteLine($"X: {punkt.X}, Y: {punkt.Y}");
            }
        }

        public static void przyklad4()
        {
            List<Osoba> listaOsob = new List<Osoba>();

            listaOsob.Add(new Osoba("Abacki", "Jan", new DateTime(1996, 02, 02)));
            listaOsob.Add(new Osoba("Cbacki", "Dam", new DateTime(2000, 02, 02)));
            listaOsob.Add(new Osoba("Fbacki", "Piotr", new DateTime(2001, 05, 02)));
            listaOsob.Add(new Osoba("Abacka", "Anna", new DateTime(1995, 04, 04)));
            listaOsob.Add(new Osoba("Gbacki", "Patryk", new DateTime(1991, 12, 12)));
            listaOsob.Add(new Osoba("Hbacki", "Karol", new DateTime(1994, 06, 03)));
            listaOsob.Add(new Osoba("Mbacki", "Szymon", new DateTime(1996, 11, 02)));
            listaOsob.Add(new Osoba("Zbacki", "Szymon", new DateTime(1987, 05, 05)));
            listaOsob.Add(new Osoba("Abacki", "Karol", new DateTime(2003, 10, 02)));
            listaOsob.Add(new Osoba("Gbacki", "Piotr", new DateTime(1994, 03, 02)));
            listaOsob.Add(new Osoba("Cbacki", "Alan", new DateTime(1988, 02, 12)));
            listaOsob.Add(new Osoba("Vbacki", "Grzegorz", new DateTime(1996, 12, 02)));
            listaOsob.Add(new Osoba("Pbacki", "Piotr", new DateTime(1997, 08, 03)));
            listaOsob.Add(new Osoba("Rbacki", "Karol", new DateTime(1994, 12, 02)));
            listaOsob.Add(new Osoba("Ibacki", "Szymon", new DateTime(1997, 03, 04)));
            listaOsob.Add(new Osoba("Abacki", "Piotr", new DateTime(1987, 04, 02)));
            listaOsob.Add(new Osoba("Jbacki", "Jan", new DateTime(1973, 11, 03)));
            listaOsob.Add(new Osoba("Mbacki", "Adam", new DateTime(1996, 10, 01)));
            listaOsob.Add(new Osoba("Nbacki", "Patryk", new DateTime(1994, 01, 09)));
            listaOsob.Add(new Osoba("Abacki", "Piotr", new DateTime(1992, 02, 07)));
            listaOsob.Add(new Osoba("Gbacki", "Jan", new DateTime(2000, 03, 06)));
            listaOsob.Add(new Osoba("Obacki", "Szymon", new DateTime(2001, 05, 04)));
            listaOsob.Add(new Osoba("Tbacki", "Stanisław", new DateTime(2002, 02, 11)));
            listaOsob.Add(new Osoba("Pbacki", "Leon", new DateTime(1996, 11, 12)));
            listaOsob.Add(new Osoba("Xbacki", "Oskar", new DateTime(1993, 06, 28)));
            listaOsob.Add(new Osoba("Lbacki", "Tomasz", new DateTime(1999, 09, 16)));
            listaOsob.Add(new Osoba("Qbacki", "Cezary", new DateTime(1991, 06, 25)));
            listaOsob.Add(new Osoba("Jbacki", "Leon", new DateTime(1996, 03, 29)));
            listaOsob.Add(new Osoba("Sbacki", "Piotr", new DateTime(1988, 06, 02)));
            listaOsob.Add(new Osoba("Bbacki", "Jan", new DateTime(1989, 07, 12)));
            listaOsob.Add(new Osoba("Ubacki", "Adam", new DateTime(1997, 02, 22)));

            // Zadanie 4
            // Z listy listaOsob
            // wybierz wszystkie osoby które na imię mają Piotr lub Szymon

            var wynik = from x in listaOsob
                        where x.Imie == "Piotr" || x.Imie == "Szymon"
                        select x;

            Console.WriteLine();
            Console.WriteLine("Osoby z imionami 'Piotr' lub 'Szymon'");
            Console.WriteLine();
            foreach(var x in wynik)
            {
                Console.WriteLine(x);
            }
            

            // Zadanie 5
            // Z listy listaOsob
            // wybierz wszystkie urodzone w 1996 roku

            var urodizny = from x in listaOsob
                        where x.DataUrodzenia.Year == 1996
                        select x;

            Console.WriteLine();
            Console.WriteLine("Wszystkie osoby urodzone w 1996");
            Console.WriteLine();
            foreach(var x in urodizny)
            {
                Console.WriteLine(x);
            }
            
        }

        public static void przyklad5()
        {
            List<Smartphone> smartphones = new List<Smartphone>();

            smartphones.Add(new Smartphone("Apple", 6.1f, 4, 64, "Apple A13 Bionic"));
            smartphones.Add(new Smartphone("Xiaomi", 6.43f, 8, 256, "MediaTek Helio G96"));
            smartphones.Add(new Smartphone("Samsung", 6.5f, 6, 128, "Samsung Exynos 1280"));
            smartphones.Add(new Smartphone("Motorola", 6.67f, 12, 512, "Qualcomm Snapdragon 7 gen 3"));
            smartphones.Add(new Smartphone("HTC", 6.7f, 12, 256, "Qualcomm Snapdragon 7 gen 1"));
            smartphones.Add(new Smartphone("Nothing", 6.7f, 12, 256, "MediaTek Dimensity 7200 Pro"));
            smartphones.Add(new Smartphone("Google Pixel", 6.1f, 8, 128, "Google Tensor G2"));
            smartphones.Add(new Smartphone("OnePlus", 6.82f, 12, 256, "Qualcomm Snapdragon 8 gen 3"));
            smartphones.Add(new Smartphone("ASUS ROG", 6.78f, 16, 512, "Qualcomm Snapdragon 8+ gen 1"));
            smartphones.Add(new Smartphone("OUKITEL", 5.93f, 4, 32, "MediaTek Helio A22"));

            // Zadanie 6
            // Z listy smartphones
            // wybierz wszystkie telefony posiadające ekran o przekątnej większej niż 6.65"
            // wynik uporządkuj alfabetyczne według nazwy producenta

        }
    }
}
