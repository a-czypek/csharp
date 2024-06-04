namespace Zestaw15Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             przyklad1();
            przyklad2();
            przyklad3();
            przyklad4();
        }

        //Przykład 1
        //
        //GroupBy()
        public static void przyklad1()
        {
            List<Pracownik> listaPracownikow = zaladujDane();

            //używając wyrażeń lambda dla listy listaPracownikow ustal,
            //ile na liście jest pracowników, których nazwiska rozpoczynają
            //się na taką samą literę. Wyświetl wybrane i zapamiętane dane.

            var wynik1 = listaPracownikow.GroupBy(x => x.Nazwisko[0]).Select(g => new { liczba = g.Count(), inicjal = g.Key});

            foreach(var x in  wynik1)
            {
                Console.WriteLine($"{x.inicjal,-9} {x.liczba, - 8}");
            }

            //Tutaj wpisz swój kod


        }

        //Przykład 2
        //
        //GroupBy()
        public static void przyklad2()
        {
            List<Pracownik> listaPracownikow = zaladujDane();

            //używając wyrażeń lambda dla listy listaPracownikow ustal,
            //ile na liście jest pracowników ze danym stażem pracy.
            //Wyświetl wybrane i zapamiętane dane.

            var wynik2 = listaPracownikow.GroupBy(x => x.StazPracy).Select(d => new {count = d.Count(), staz = d.Key});

            Console.WriteLine();
            foreach(var x in wynik2)
            {
                Console.WriteLine($"{x.staz,-8} {x.count,-9}");
            }
            Console.WriteLine();

            //Tutaj wpisz swój kod
        }

        //Przykład 
        //
        //Any()
        public static void przyklad3()
        {
            List<Pracownik> listaPracownikow = zaladujDane();

            // używając wyrażeń lambda dla listy listaPracownikow ustal czy
            // na liście znajduje się jakieś nazwisko kończące się na „ski”.
            // Wyświetl uzyskane dane.

            var wynik3 = listaPracownikow.Any(x => x.Nazwisko.EndsWith("ski"));

            Console.WriteLine();
            Console.WriteLine(wynik3);
            Console.WriteLine();
            //Tutaj wpisz swój kod


        }

        //Przykład 4
        //
        //All()
        public static void przyklad4()
        {
            Random r = new Random();
            int[] liczby = new int[10];

            for (int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = r.Next(0, 10);
                Console.Write($"{liczby[i]}, ");
            }

            //używając wyrażeń lambda dla tablicy liczby ustal czy wszystkie
            //liczby w tablicy są parzyste. Wyświetl uzyskane dane.

            var wynik4 = liczby.All(x => x % 2 == 0);

            Console.WriteLine();
            Console.WriteLine(wynik4);
            Console.WriteLine();

            //Tutaj wpisz swój kod


        }

        public static List<Pracownik> zaladujDane()
        {
            List<Pracownik> lista = new List<Pracownik>();

            lista.Add(new Pracownik(1, "Kowalski", "Jan", 10, 3600.00m));
            lista.Add(new Pracownik(2, "Nowak", "Adam", 12, 3600.00m));
            lista.Add(new Pracownik(3, "Kowal", "Piotr", 11, 3600.00m));
            lista.Add(new Pracownik(4, "Jankowski", "Szymon", 9, 3600.00m));
            lista.Add(new Pracownik(5, "Janikowaki", "Natan", 8, 3600.00m));
            lista.Add(new Pracownik(6, "Adamczewski", "Władysław", 10, 3600.00m));
            lista.Add(new Pracownik(7, "Walczak", "Wiesław", 13, 3600.00m));
            lista.Add(new Pracownik(8, "Kisiel", "Anna", 14, 3600.00m));
            lista.Add(new Pracownik(9, "Krakowaki", "Jan", 11, 3600.00m));
            lista.Add(new Pracownik(10, "Adamek", "Aleksandra", 10, 3600.00m));
            lista.Add(new Pracownik(11, "Maj", "Szymon", 2, 3600.00m));
            lista.Add(new Pracownik(12, "Sierpień", "Adam", 1, 3600.00m));
            lista.Add(new Pracownik(13, "Nowak", "Piotr", 1, 3600.00m));
            lista.Add(new Pracownik(14, "Nosal", "Paweł", 18, 3600.00m));
            lista.Add(new Pracownik(15, "Kawik", "Łukasz", 12, 3600.00m));
            lista.Add(new Pracownik(16, "Atlas", "Wiesława", 11, 3600.00m));
            lista.Add(new Pracownik(17, "Kruk", "Malwina", 18, 3600.00m));
            lista.Add(new Pracownik(18, "Janas", "Joanna", 13, 3600.00m));
            lista.Add(new Pracownik(19, "Misiak", "Szymon", 14, 3600.00m));
            lista.Add(new Pracownik(20, "Misiek", "Jan", 1, 3600.00m));
            return lista;
        }
    }
}
