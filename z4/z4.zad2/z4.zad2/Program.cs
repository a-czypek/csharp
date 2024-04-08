namespace z4.zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dzien dzien1 = new Dzien(8, Miesiace.Kwiecien, PoryRoku.Wiosna);
            Dzien dzien2 = new Dzien(20, Miesiace.Lipiec, PoryRoku.Lato);

            // Wyświetlanie informacji o dniach
            Console.WriteLine("Informacje o dniu 1:");
            dzien1.Wyswietl();
            Console.WriteLine();

            Console.WriteLine("Informacje o dniu 2:");
            dzien2.Wyswietl();

            Console.ReadKey();
        }
    }
}
