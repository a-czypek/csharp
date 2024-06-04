using System.Security.Cryptography.X509Certificates;

namespace Zestaw14Zadanie1
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
            przyklad6();
            przyklad7();
            przyklad8();
            przyklad9();
        }

        // przykład 1
        // 
        // Distinct()
        public static void przyklad1()
        {
            Random r = new Random();

            int[] liczbyCalkowite = new int[20];

            for (int i = 0; i < liczbyCalkowite.Length; i++)
            {
                liczbyCalkowite[i] = r.Next(0, 10);
                //Console.Write($"{liczbyCalkowite[i]}, ");
            }

            // Z tablicy liczbyCalkowite wybierz wszystkie unikalne wartości
            // następnie wyświetl uzyskane wyniki.

            var wynik1 = liczbyCalkowite.Distinct();

            Console.WriteLine("Unikalne wartości w tablicy liczbyCalkowite");
            foreach(var x in  wynik1)
            {
                Console.WriteLine(x);
            }

            // W tym miejscu wpisz niezbędny kod

        }

        // przykład 2
        // 
        // Distinct()
        public static void przyklad2()
        {
            string[] owoce = {"grusza",
                              "sliwka",
                              "brzoskwinia",
                              "gruszka",
                              "czereśnia",
                              "wiśnia",
                              "jabłko",
                              "Jagoda",
                              "grusza",
                              "sliwka",
                              "brzoskwinia",
                              "gruszka",
                              "czereśnia",
                              "wiśnia",
                              "jabłko",
                              "Jagoda",
                              "grusza",
                              "sliwka",
                              "brzoskwinia",
                              "gruszka",
                              "czereśnia",
                              "wiśnia",
                              "jabłko",
                              "Jagoda"};

            //foreach (string owoc in owoce)
            //    Console.Write(owoc + ", ");

            // z tablicy owoce wybierz wszystkie unikalne nazwy owoców
            // następnie wyświetl uzyskane wyniki.

            var wynik2 = owoce.Distinct();

            Console.WriteLine();
            Console.WriteLine("Unikalne owoce");
            foreach(var x in wynik2)
            {
                Console.WriteLine(x);
            }

            // W tym miejscu wpisz niezbędny kod

        }

        // przykład 3
        // 
        // Distinct()
        public static void przyklad3()
        {
            List<Ksiazka> biblioteczka = new List<Ksiazka>();

            biblioteczka.Add(new Ksiazka("Abacki Jan", "XXX", 2000, 150));
            biblioteczka.Add(new Ksiazka("Bebacki Adam", "AAA", 2001, 150));
            biblioteczka.Add(new Ksiazka("Cebacki Jan", "QQQ", 2002, 150));
            biblioteczka.Add(new Ksiazka("Debacka Ilona", "SSS", 2003, 150));
            biblioteczka.Add(new Ksiazka("Ebacka Ewa", "VVV", 2000, 150));
            biblioteczka.Add(new Ksiazka("Fbacki Karol", "MMM", 2001, 150));
            biblioteczka.Add(new Ksiazka("Gbacki Piotr", "XXX", 2002, 150));
            biblioteczka.Add(new Ksiazka("Hbacki Antoni", "LLL", 2003, 150));
            biblioteczka.Add(new Ksiazka("Ibacki Karol", "KKK", 2000, 150));
            biblioteczka.Add(new Ksiazka("Jbacki Tomasz", "PPP", 2001, 152));
            biblioteczka.Add(new Ksiazka("Kbacka Anna", "BBB", 2002, 152));
            biblioteczka.Add(new Ksiazka("Lbacka Aleksandra", "CCC", 2003, 152));
            biblioteczka.Add(new Ksiazka("Mbacki Szymon", "ZZZ", 2001, 152));
            biblioteczka.Add(new Ksiazka("Nbacka Teresa", "OOO", 2002, 152));
            biblioteczka.Add(new Ksiazka("Obacki Piotr", "UUU", 2003, 152));
            biblioteczka.Add(new Ksiazka("Pbacki Adam", "FFF", 2000, 150));
            biblioteczka.Add(new Ksiazka("Rbacki Szymon", "TTT", 2000, 150));
            biblioteczka.Add(new Ksiazka("Sbacki Jan", "RRR", 2001, 150));
            biblioteczka.Add(new Ksiazka("Tbacka Joanna", "XXX", 2003, 150));
            biblioteczka.Add(new Ksiazka("Ubacki Witold", "AAA", 2000, 152));
            biblioteczka.Add(new Ksiazka("Abacki Jan", "RRE", 2000, 152));

            // z listy biblioteczka wybierz wszystkie unikalne daty wydania książek
            // następnie wyświetl uzyskane wyniki

            var wynik3 = (from x in biblioteczka
                          select x.RokWydania).Distinct();

            Console.WriteLine();
            Console.WriteLine("Unikalne roki wydania książek");

            foreach(var x in wynik3)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            // W tym miejscu wpisz niezbędny kod

        }

        // przykład 4
        // 
        // Union()
        public static void przyklad4()
        {
            Random r = new Random();

            int rozmiar = 20;

            int[] tab1 = new int[rozmiar];
            int[] tab2 = new int[rozmiar];

            for (int i = 0; i < rozmiar; i++)
            {
                tab1[i] = r.Next(0, 10);
                //Console.Write($"tab1[{i}] - {tab1[i]} - ");

                tab2[i] = r.Next(5, 15);
                //Console.Write($"tab2[{i}] - {tab2[i]}");
                //Console.WriteLine();
            }

            // z tablic tab1, tab2 wybierz i zapamiętaj wszystkie unikalne wartości
            // następnie wyświetl uzyskane wyniki.

            var unic = tab1.Union(tab2);

            var wynik4 = unic.Distinct();

            Console.WriteLine();
            Console.WriteLine("Unikalne wartości w tab1 i tab2");
            foreach( var x in wynik4)
            {
                Console.WriteLine(x);
            }

            // W tym miejscu wpisz niezbędny kod


        }

        // przykład 5
        // 
        // Union()
        public static void przyklad5()
        {
            List<Ksiazka> biblioteczka = new List<Ksiazka>();

            biblioteczka.Add(new Ksiazka("Abacki Jan", "XXX", 2000, 150));
            biblioteczka.Add(new Ksiazka("Bebacki Adam", "AAA", 2001, 150));
            biblioteczka.Add(new Ksiazka("Cebacki Jan", "QQQ", 2002, 150));
            biblioteczka.Add(new Ksiazka("Debacka Ilona", "SSS", 2003, 150));
            biblioteczka.Add(new Ksiazka("Ebacka Ewa", "VVV", 2000, 150));
            biblioteczka.Add(new Ksiazka("Fbacki Karol", "MMM", 2001, 150));
            biblioteczka.Add(new Ksiazka("Gbacki Piotr", "XXX", 2002, 150));
            biblioteczka.Add(new Ksiazka("Hbacki Antoni", "LLL", 2003, 150));
            biblioteczka.Add(new Ksiazka("Ibacki Karol", "KKK", 2000, 150));
            biblioteczka.Add(new Ksiazka("Jbacki Tomasz", "PPP", 2001, 152));
            biblioteczka.Add(new Ksiazka("Kbacka Anna", "BBB", 2002, 152));
            biblioteczka.Add(new Ksiazka("Lbacka Aleksandra", "CCC", 2003, 152));
            biblioteczka.Add(new Ksiazka("Mbacki Szymon", "ZZZ", 2001, 152));
            biblioteczka.Add(new Ksiazka("Nbacka Teresa", "OOO", 2002, 152));
            biblioteczka.Add(new Ksiazka("Obacki Piotr", "UUU", 2003, 152));
            biblioteczka.Add(new Ksiazka("Pbacki Adam", "FFF", 2000, 150));
            biblioteczka.Add(new Ksiazka("Rbacki Szymon", "TTT", 2000, 150));
            biblioteczka.Add(new Ksiazka("Sbacki Jan", "RRR", 2001, 150));
            biblioteczka.Add(new Ksiazka("Tbacka Joanna", "XXX", 2003, 150));
            biblioteczka.Add(new Ksiazka("Ubacki Witold", "AAA", 2000, 152));
            biblioteczka.Add(new Ksiazka("Abacki Jan", "RRE", 2000, 152));


            //z listy biblioteczka wybierz i zapamiętaj:
            //    a.Wszystkie książki wydane w 2003 roku

            var wynik5a = from x in biblioteczka
                          where x.RokWydania == 2003
                          select x;
            //    b.Wszystkie książki mające dokładnie 150 stron

            var wynik5b = from x in biblioteczka
                          where x.LiczbaStron == 150
                          select x;

            var wynik5 = wynik5a.Union(wynik5b);

            foreach(var x in wynik5)
            {
                Console.WriteLine($"{x.LiczbaStron} {x.RokWydania}");
            }

            //Następnie z uzyskanych wyników wybierz i zapamiętaj wszystkie
            //unikalne książki występujące na dwóch wcześniej
            //przygotowanych listach.Wyświetl uzyskane wyniki.

            // W tym miejscu wpisz niezbędny kod

        }

        // przykład 6
        // 
        // Intersect()
        public static void przyklad6()
        {
            Random r = new Random();

            int rozmiar = 20;

            int[] tab1 = new int[rozmiar];
            int[] tab2 = new int[rozmiar];

            for (int i = 0; i < rozmiar; i++)
            {
                tab1[i] = r.Next(0, 10);
                //Console.Write($"tab1[{i}] - {tab1[i]} - ");

                tab2[i] = r.Next(5, 15);
                //Console.Write($"tab2[{i}] - {tab2[i]}");
                //Console.WriteLine();
            }

            //z tablic tab1, tab2 wybierz i zapamiętaj wszystkie unikalne
            //wartości występujące zarówno w jednej jak i drugiej tablicy.
            //Następnie wyświetl uzyskane wyniki.

            var wynik6 = tab1.Intersect(tab2);


            Console.WriteLine();
            Console.WriteLine();
            foreach (int i in wynik6)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();    
            Console.WriteLine();

            // W tym miejscu wpisz niezbędny kod


        }

        // przykład 7
        // 
        // Intersect()
        public static void przyklad7()
        {
            List<Ksiazka> biblioteczka = new List<Ksiazka>();

            biblioteczka.Add(new Ksiazka("Abacki Jan", "XXX", 2000, 150));
            biblioteczka.Add(new Ksiazka("Bebacki Adam", "AAA", 2001, 150));
            biblioteczka.Add(new Ksiazka("Cebacki Jan", "QQQ", 2002, 150));
            biblioteczka.Add(new Ksiazka("Debacka Ilona", "SSS", 2003, 150));
            biblioteczka.Add(new Ksiazka("Ebacka Ewa", "VVV", 2000, 150));
            biblioteczka.Add(new Ksiazka("Fbacki Karol", "MMM", 2001, 150));
            biblioteczka.Add(new Ksiazka("Gbacki Piotr", "XXX", 2002, 150));
            biblioteczka.Add(new Ksiazka("Hbacki Antoni", "LLL", 2003, 150));
            biblioteczka.Add(new Ksiazka("Ibacki Karol", "KKK", 2000, 150));
            biblioteczka.Add(new Ksiazka("Jbacki Tomasz", "PPP", 2001, 152));
            biblioteczka.Add(new Ksiazka("Kbacka Anna", "BBB", 2002, 152));
            biblioteczka.Add(new Ksiazka("Lbacka Aleksandra", "CCC", 2003, 152));
            biblioteczka.Add(new Ksiazka("Mbacki Szymon", "ZZZ", 2001, 152));
            biblioteczka.Add(new Ksiazka("Nbacka Teresa", "OOO", 2002, 152));
            biblioteczka.Add(new Ksiazka("Obacki Piotr", "UUU", 2003, 152));
            biblioteczka.Add(new Ksiazka("Pbacki Adam", "FFF", 2000, 150));
            biblioteczka.Add(new Ksiazka("Rbacki Szymon", "TTT", 2000, 150));
            biblioteczka.Add(new Ksiazka("Sbacki Jan", "RRR", 2001, 150));
            biblioteczka.Add(new Ksiazka("Tbacka Joanna", "XXX", 2003, 150));
            biblioteczka.Add(new Ksiazka("Ubacki Witold", "AAA", 2000, 152));
            biblioteczka.Add(new Ksiazka("Abacki Jan", "RRE", 2000, 152));

            // z listy biblioteczka wybierz i zapamiętaj:
            //      a.Wszystkie książki wydane w 2003 roku

            var wynik7a = from x in biblioteczka
                          where x.RokWydania == 2003
                          select x;

            //      b.Wszystkie książki mające dokładnie 150 stron

            var wynik7b = from x in biblioteczka
                          where x.LiczbaStron == 150
                          select x;
            //Następnie z uzyskanych wyników wybierz i zapamiętaj wszystkie
            //unikalne książki występujące zarówno na jednej jak i na drugiej
            //z wcześniej przygotowanych listach. Wyświetl uzyskane wyniki.

            var wynik7 = wynik7a.Intersect(wynik7b);

            Console.WriteLine();
            Console.WriteLine();
            foreach( var x in wynik7)
            {
                Console.WriteLine($"{x.LiczbaStron} {x.RokWydania}");
            }
            Console.WriteLine();
            Console.WriteLine();

            // W tym miejscu wpisz niezbędny kod


        }

        // przykład 8
        // 
        // Except()
        public static void przyklad8()
        {
            Random r = new Random();

            int rozmiar = 20;

            int[] tab1 = new int[rozmiar];
            int[] tab2 = new int[rozmiar];

            for (int i = 0; i < rozmiar; i++)
            {
                tab1[i] = r.Next(0, 10);
                //Console.Write($"tab1[{i}] - {tab1[i]} - ");

                tab2[i] = r.Next(5, 15);
                //Console.Write($"tab2[{i}] - {tab2[i]}");
                //Console.WriteLine();
            }

            //z tablic tab1, tab2 wybierz i zapamiętaj wszystkie unikalne
            //wartości występujące w tablicy tab1 a nie występujące w tablicy
            //tab2. Wyświetl uzyskane wyniki.

            var wynik8 = tab1.Except(tab2);

            Console.WriteLine();
            foreach ( var x in wynik8)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();


            // W tym miejscu wpisz niezbędny kod


        }

        // przykład 9
        // 
        // Except()
        public static void przyklad9()
        {
            List<Ksiazka> biblioteczka = new List<Ksiazka>();

            biblioteczka.Add(new Ksiazka("Abacki Jan", "XXX", 2000, 150));
            biblioteczka.Add(new Ksiazka("Bebacki Adam", "AAA", 2001, 150));
            biblioteczka.Add(new Ksiazka("Cebacki Jan", "QQQ", 2002, 150));
            biblioteczka.Add(new Ksiazka("Debacka Ilona", "SSS", 2003, 150));
            biblioteczka.Add(new Ksiazka("Ebacka Ewa", "VVV", 2000, 150));
            biblioteczka.Add(new Ksiazka("Fbacki Karol", "MMM", 2001, 150));
            biblioteczka.Add(new Ksiazka("Gbacki Piotr", "XXX", 2002, 150));
            biblioteczka.Add(new Ksiazka("Hbacki Antoni", "LLL", 2003, 150));
            biblioteczka.Add(new Ksiazka("Ibacki Karol", "KKK", 2000, 150));
            biblioteczka.Add(new Ksiazka("Jbacki Tomasz", "PPP", 2001, 152));
            biblioteczka.Add(new Ksiazka("Kbacka Anna", "BBB", 2002, 152));
            biblioteczka.Add(new Ksiazka("Lbacka Aleksandra", "CCC", 2003, 152));
            biblioteczka.Add(new Ksiazka("Mbacki Szymon", "ZZZ", 2001, 152));
            biblioteczka.Add(new Ksiazka("Nbacka Teresa", "OOO", 2002, 152));
            biblioteczka.Add(new Ksiazka("Obacki Piotr", "UUU", 2003, 152));
            biblioteczka.Add(new Ksiazka("Pbacki Adam", "FFF", 2000, 150));
            biblioteczka.Add(new Ksiazka("Rbacki Szymon", "TTT", 2000, 150));
            biblioteczka.Add(new Ksiazka("Sbacki Jan", "RRR", 2001, 150));
            biblioteczka.Add(new Ksiazka("Tbacka Joanna", "XXX", 2003, 150));
            biblioteczka.Add(new Ksiazka("Ubacki Witold", "AAA", 2000, 152));
            biblioteczka.Add(new Ksiazka("Abacki Jan", "RRE", 2000, 152));


            //z listy biblioteczka wybierz i zapamiętaj:
            //      a.Wszystkie książki wydane w 2003 roku

            var wynik9a = from x in biblioteczka
                          where x.RokWydania == 2003
                          select x;

            //      b.Wszystkie książki mające dokładnie 150 stron

            var wynik9b = from x in biblioteczka
                          where x.LiczbaStron == 150
                          select x;

            //Następnie z uzyskanych wyników wybierz wszystkie książki
            //występujące na liście książek z 2003 roku a nie występujące
            //na liście książek mających 150 stron.Wyświetl uzyskane wyniki.

            var wynik9 = wynik9a.Except(wynik9b);

            Console.WriteLine();
            Console.WriteLine();
            foreach (var x in wynik9)
            {
                Console.WriteLine($"{x.LiczbaStron} {x.RokWydania}");
            }
            Console.WriteLine();
            Console.WriteLine();

            // W tym miejscu wpisz niezbędny kod

        }
    }
}
