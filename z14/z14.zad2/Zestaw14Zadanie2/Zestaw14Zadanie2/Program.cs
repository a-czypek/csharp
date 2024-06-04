namespace Zestaw14Zadanie2
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

        //przykład 1
        //
        //Where()
        public static void przyklad1()
        {
            Random r = new Random();

            int[] liczbyCalkowite = new int[20];

            for (int i = 0; i < liczbyCalkowite.Length; i++)
            {
                liczbyCalkowite[i] = r.Next(0, 100);
                Console.Write($"{liczbyCalkowite[i]}, ");
            }

            //używając wyrażeń lambda z tablicy liczbyCalkowite wybierz
            //i zapamiętaj wszystkie wartości należące do przedziału (20, 50).
            //Wyświetl uzyskane wyniki.

            var wynik1 = liczbyCalkowite.Where(x => x > 20 && x < 50);

            Console.WriteLine();
            Console.WriteLine();

            foreach(var x in wynik1)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();
            Console.WriteLine();

            //Miejsce na twój kod
        }

        //przykład 2
        //
        //Where()
        public static void przyklad2()
        {
            List<Osoba> listaUczestnikow = zaladujDane();

            //używając wyrażeń lambda z listy listaUczestnikow wybierz i
            //zapamiętaj wszystkie osoby pełnoletnie. Wyświetl uzyskane wyniki.

            var wynik2 = listaUczestnikow.Where(x => x.dataUrodzenia <= DateTime.Now.AddYears(-18));   

            Console.WriteLine();
            Console.WriteLine();

            foreach(var x in wynik2)
            {
                Console.WriteLine($"{x.nazwisko} {x.imie} {x.dataUrodzenia}");
            }

            Console.WriteLine();
            Console.WriteLine();


        }

        //przykład 3
        //
        //Where()
        public static void przyklad3()
        {
            List<Osoba> listaUczestnikow = zaladujDane();

            //używając wyrażeń lambda z listy listaUczestnikow wybierz i
            //zapamiętaj wszystkie osoby o nazwisku „Abacki” lub imieniu
            //„Karol”. Wyświetl uzyskane wyniki.

            var wynik3 = listaUczestnikow.Where(x => x.nazwisko == "Abacki" || x.imie == "Karol");

            Console.WriteLine();
            Console.WriteLine();
            foreach(var x in wynik3)
            {
                Console.WriteLine($"{x.nazwisko} {x.imie}");
            }
            Console.WriteLine();
            Console.WriteLine();


            //Miejsce na twój kod

        }

        public static void przyklad4()
        {
            string[] liczby = { "zero", "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć" };

            //używając wyrażeń lambda z tablicy liczby wybierz i zapamiętaj
            //te nazwy liczb których długość jest mniejsza od ich indeksu w
            //tablicy. Wyświetl uzyskane wyniki.

            var wynik4 = liczby.Select((nazwa, indeks) => new { nazwa, indeks }).Where(x => x.nazwa.Length > x.indeks).Select(x => x.nazwa);

            Console.WriteLine();
            Console.WriteLine();

            foreach(var x in wynik4)
            {
                Console.WriteLine($"{x}");
            }


            //Miejsce na twój kod


        }

        public static List<Osoba> zaladujDane()
        {
            List<Osoba> lista = new List<Osoba>();

            lista.Add(new Osoba("Abacki", "Jan", new DateTime(1990, 1, 1)));
            lista.Add(new Osoba("Bbacki", "Adam", new DateTime(1992, 11, 1)));
            lista.Add(new Osoba("Cbacka", "Anna", new DateTime(1999, 1, 11)));
            lista.Add(new Osoba("Dbacka", "Janina", new DateTime(2010, 12, 1)));
            lista.Add(new Osoba("Ebacki", "Karol", new DateTime(2011, 3, 13)));
            lista.Add(new Osoba("Fbacki", "Leon", new DateTime(1990, 10, 14)));
            lista.Add(new Osoba("Gbacki", "Konrad", new DateTime(1988, 1, 1)));
            lista.Add(new Osoba("Hbacki", "Jan", new DateTime(2012, 6, 16)));
            lista.Add(new Osoba("Ibacki", "Iwan", new DateTime(2013, 11, 1)));
            lista.Add(new Osoba("Jbacki", "Grzegorz", new DateTime(2001, 1, 1)));
            lista.Add(new Osoba("Kbacki", "Filip", new DateTime(2002, 11, 1)));
            lista.Add(new Osoba("Lbacki", "Edward", new DateTime(1990, 1, 21)));
            lista.Add(new Osoba("Mbacki", "Cezary", new DateTime(1996, 11, 11)));
            lista.Add(new Osoba("Nbacki", "Czarek", new DateTime(1999, 8, 17)));
            lista.Add(new Osoba("Obacki", "Bartek", new DateTime(1999, 1, 1)));
            lista.Add(new Osoba("Pbacki", "Adrian", new DateTime(2008, 11, 11)));
            lista.Add(new Osoba("Rbacki", "Marcin", new DateTime(2008, 6, 13)));
            lista.Add(new Osoba("Sbacki", "Patryk", new DateTime(1994, 1, 1)));
            lista.Add(new Osoba("Tbacki", "Adrian", new DateTime(1996, 11, 21)));
            lista.Add(new Osoba("Ubacki", "Jan", new DateTime(1999, 12, 21)));
            lista.Add(new Osoba("Wbacki", "Karol", new DateTime(2014, 1, 1)));
            lista.Add(new Osoba("Abacki", "Witold", new DateTime(2020, 1, 1)));
            lista.Add(new Osoba("Bbacki", "Robert", new DateTime(1994, 11, 11)));
            lista.Add(new Osoba("Cbacki", "Adam", new DateTime(1991, 12, 11)));


            return lista;
        }
    }
}
