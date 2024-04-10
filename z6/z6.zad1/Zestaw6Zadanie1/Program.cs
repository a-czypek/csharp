namespace z6.zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Macierz macierz1 = new Macierz(3, 3);
            Macierz macierz2 = new Macierz(3, 3);

            Console.WriteLine("Macierz 1: ");
            macierz1.WyswietlMacierz();

            Console.WriteLine("Macierz 2: ");
            macierz2.WyswietlMacierz();

            Console.WriteLine("Macierz 1 Transponowana: ");
            Macierz transpozycja = macierz1.Transpozycja();
            transpozycja.WyswietlMacierz();

            Console.WriteLine("suma macierzy: ");
            Macierz suma = macierz1 + macierz2;
            suma.WyswietlMacierz();

            Console.WriteLine("Mnożenie macierzy przez liczbę 2: ");
            Macierz iloczyn = 2 * macierz1;
            iloczyn.WyswietlMacierz();

            Console.ReadKey();
        }
    }
}
