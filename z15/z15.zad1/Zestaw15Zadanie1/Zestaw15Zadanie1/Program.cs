namespace Zestaw15Zadanie1
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

        //Przykład 1
        //
        //Select()
        public static void przyklad1()
        {
            string[] listaImion = { "ADam", "JaN", "kARol", "AnnA", "JaNINa", "Olaf" };

            //używając wyrażeń lambda z tablicy listaImin wybierz i zapamiętaj
            //wszystkie imiona zapisane dużymi i małymi literami.
            //Wyświetl uzyskane wyniki.

            var wynik1 = listaImion.Select(x => new { duze = x.ToUpper(), male = x.ToLower() });

            foreach(var x in wynik1 )
            {
                Console.WriteLine($"{x.duze} {x.male}");
            }
            Console.WriteLine();
            Console.WriteLine();

            // Tutaj jest miejsce na twój kod

        }

        //Przykład 2
        //
        //Select()
        public static void przyklad2()
        {
            List<Produkt> listaProduktow = zaladujDane();

            //używając wyrażeń lambda z listy listaProduktow wybierz i
            //zapamiętaj dane zawierające nazwę produktu oraz wartość
            //brutto produktu. Wyświetl uzyskane wyniki.

            var wynik2 = listaProduktow.Select(x => new { nazwa = x.nazwa, brutto = x.waroscNetto + x.waroscNetto * x.stawkaVAT });

            Console.WriteLine();
            Console.WriteLine();
            foreach( var x in wynik2 )
            {
                Console.WriteLine($"{x.nazwa} {x.brutto}");
            }
            Console.WriteLine();
            Console.WriteLine();

            // Tutaj jest miejsce na twój kod

        }

        //Przykład 3
        //
        //Select()
        public static void przyklad3()
        {
            Random r = new Random();

            int[] tab = new int[20];

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = r.Next(0, 21);
                Console.Write($"{tab[i]}, ");
            }

            //używając wyrażeń lambda ustal czy w tablicy tab przechowywana
            //wartość jest równa indeksowi w tablicy. Wyświetl wybrane
            //i zapamiętane dane.

            var wynik3 = tab.Select((value, index) => new { Value = value, Index = index })
            .Where(item => item.Value == item.Index);

            Console.WriteLine();
            Console.WriteLine();
            foreach(var x in wynik3)
            {

                Console.WriteLine(x);
            }
            Console.WriteLine();
            Console.WriteLine();

            // Tutaj jest miejsce na twój kod

        }

        //Przykład 4
        //
        //Select()
        public static void przyklad4()
        {
            List<Produkt> listaProduktow = zaladujDane();

            //używając wyrażeń lambda z listy listaProduktów wybierz
            //nazwę produktu, stawkę podatku Vat, wartość netto oraz
            //wartość brutto produktów ze stawką Vat 0.22. Wyświetl
            //uzyskane wyniki.

            var wynik4 = listaProduktow.Where(x => x.stawkaVAT == 0.22m).Select( x=> new 
            {
                naz = x.nazwa,
                wartnet = x.waroscNetto,
                warbrut = x.waroscNetto * x.stawkaVAT + x.waroscNetto         
            });

            Console.WriteLine();
            foreach(var x in wynik4)
            {
                Console.WriteLine($"{x.naz} {x.wartnet} {x.warbrut}");
            }
            Console.WriteLine();
            // Tutaj jest miejsce na twój kod


        }

        //Przykład 5
        //
        //Select()
        public static void przyklad5()
        {
            Random r = new Random();
            string[] nazwy = { "zero", "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć" };

            int[] tabLiczb = new int[20];

            for (int i = 0; i < tabLiczb.Length; i++)
            {
                tabLiczb[i] = r.Next(0, 10);
                Console.Write($"{tabLiczb[i]}, ");
            }

            //używając wyrażeń lambda przekonwertuj wartości liczbowe
            //przechowywane w tablicy tabLiczb na odpowiadające im nazwy
            //(patrz tablica nazwy). Wyświetl wybrane i zapamiętane dane.

            var wynik5 = tabLiczb.Select((wartosc) => new {wartosc, nazwa = nazwy[wartosc] });

            foreach(var x in wynik5)
            {
                Console.WriteLine(x.wartosc + " " + x.nazwa);
            }

            // Tutaj jest miejsce na twój kod

        }
        public static List<Produkt> zaladujDane()
        {
            List<Produkt> lista = new List<Produkt>();

            lista.Add(new Produkt(1, "Monitor LCD", "szt", 200.0m, 0.22m));
            lista.Add(new Produkt(1, "Dysk HDD", "szt", 20.0m, 0.22m));
            lista.Add(new Produkt(1, "Dysk SSD", "szt", 300.0m, 0.22m));
            lista.Add(new Produkt(1, "Zasilacz", "szt", 100.0m, 0.22m));
            lista.Add(new Produkt(1, "Marchewka", "kg", 5.0m, 0.0m));
            lista.Add(new Produkt(1, "Pietruszka", "kg", 7.0m, 0.00m));
            lista.Add(new Produkt(1, "Banany", "kg", 10.0m, 0.07m));
            lista.Add(new Produkt(1, "Woda gazowana", "szt", 0.50m, 0.07m));
            lista.Add(new Produkt(1, "Szampon", "szt", 22.0m, 0.22m));
            lista.Add(new Produkt(1, "Telefon", "szt", 250.0m, 0.22m));
            lista.Add(new Produkt(1, "Szczypiorek", "pęczek", 1.0m, 0.22m));
            lista.Add(new Produkt(1, "Cebula", "Pęczek", 2.0m, 0.22m));
            lista.Add(new Produkt(1, "Procesor I", "szt", 200.0m, 0.22m));
            lista.Add(new Produkt(1, "Procesor II", "szt", 250.0m, 0.22m));
            lista.Add(new Produkt(1, "Pamięć DDR5", "szt", 10.0m, 0.22m));
            lista.Add(new Produkt(1, "Pamięć DDR4", "szt", 20.0m, 0.22m));
            lista.Add(new Produkt(1, "Pamięć DDR3", "szt", 30.0m, 0.22m));
            lista.Add(new Produkt(1, "TV", "szt", 201.0m, 0.22m));
            lista.Add(new Produkt(1, "Monitor LCD II", "szt", 201.0m, 0.22m));
            lista.Add(new Produkt(1, "Monitor LCD III", "szt", 220.0m, 0.22m));

            return lista;
        }
    }
}
