using System.Xml.Serialization;

namespace Zestaw12Zadanie1
{
    internal class Program
    {
        private static List<Punkt3d> listaPunktow=new List<Punkt3d>();

        static void Main(string[] args)
        {
            //Console.WriteLine("The current buffer height is {0} rows.",
            //                  Console.BufferHeight);
            //Console.WriteLine("The current buffer width is {0} columns.",
            //                  Console.BufferWidth);

            do
            {
                Console.Clear();

                Console.SetCursorPosition(Console.BufferWidth/2-2, 5);
                Console.WriteLine("Menu");
                Console.SetCursorPosition(Console.BufferWidth / 2 - 5, 6);
                Console.WriteLine("==========");
                
                Console.SetCursorPosition(Console.BufferWidth / 2 - 16, 9);
                Console.WriteLine("1 - Dodaj obiekt do list;");
                Console.SetCursorPosition(Console.BufferWidth / 2 - 16, 10);
                Console.WriteLine("2 - Wyświetl listę obiektów;");
                Console.SetCursorPosition(Console.BufferWidth / 2 - 16, 11);
                Console.WriteLine("3 - Zapamietaj zawartość listy;");
                Console.SetCursorPosition(Console.BufferWidth / 2 - 16, 12);
                Console.WriteLine("4 - Załaduj zawartość listy z pliku;");
                Console.SetCursorPosition(Console.BufferWidth / 2 - 16, 13);
                Console.WriteLine("5 - Zakończ program;");

                Console.SetCursorPosition(Console.BufferWidth / 2 - 16, 18);
                Console.Write("Wybierz [1 - 5]: ");
                ConsoleKeyInfo wybor =  Console.ReadKey();

                switch (wybor.KeyChar)
                {
                    case '1':
                        dodajDoListy();
                        break;
                    case '2':
                        wyswietlListe();
                        break;
                    case '3':
                        SerializacjaXML(listaPunktow, "punkty.xml");
                        Console.Clear();
                        Console.WriteLine("Lista została zapisana do pliku punkty.xml");
                        Console.WriteLine("Naciśnij dowolny klawisz.");
                        Console.ReadKey();
                        break;
                    case '4':
                        listaPunktow = DeserializacjaXML("punkty.xml");
                        Console.Clear();
                        Console.WriteLine("Lista została załadowana z pliku punkty.xml");
                        Console.WriteLine("Naciśnij dowolny klawisz.");
                        Console.ReadKey();
                        break;
                    case '5':
                        Console.Clear();
                        Environment.Exit(0);
                    break;
                }
            }
            while (true);
        }

        // Metoda obsługujaca generowanie wspólrzędnych punktu
        // i dodanie punktów do listy
        public static void dodajDoListy()
        { 
            Random random = new Random();

            Punkt3d punkt3D = new Punkt3d(random.NextSingle() * random.Next(1, 10000),
                                          random.NextSingle() * random.Next(1, 10000),
                                          random.NextSingle() * random.Next(1, 10000));

            listaPunktow.Add(punkt3D);

            Console.Clear();

            Console.WriteLine($"Punkt {punkt3D.ToString()} dodano do listy.");
            Console.WriteLine();

            Console.WriteLine("Nacisnik dowolny klawisz.");
            Console.ReadKey();
        }

        public static void wyswietlListe() 
        {
            Console.Clear();

            if (listaPunktow.Count == 0) 
            {
                Console.WriteLine("Lista jest pusta!!");
            }
            else 
            {
                foreach (var item in listaPunktow)
                { 
                    Console.WriteLine(item.ToString()); 
                }
            }

            Console.WriteLine("Nacisnik dowolny klawisz.");
            Console.ReadKey();
        }

        public static void SerializacjaXML(List<Punkt3d> listaPunktow, string droga)
        {
            XmlSerializer serializacja = new XmlSerializer(typeof(List<Punkt3d>));
            using (StreamWriter sw = new StreamWriter(droga))
            {
                serializacja.Serialize(sw, listaPunktow);
            }
        }

        public static List<Punkt3d> DeserializacjaXML (string droga)
        {
            XmlSerializer serializacja = new XmlSerializer(typeof(List<Punkt3d>));
            using (StreamReader sr = new StreamReader(droga))
            {
                return (List<Punkt3d>)serializacja.Deserialize(sr);
            }
        }
    }
}
