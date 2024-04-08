using z4.zad1;

namespace z4.zad1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt2DS punkt1 = new Punkt2DS(2, 3);
            Console.WriteLine("Punkt 1 - X: {0}, Y: {1}", punkt1.X, punkt1.Y);

            Punkt2DC punkt2 = new Punkt2DC(4, 5);
            Console.WriteLine("Punkt 2 - X: {0}, Y: {1}", punkt2.X, punkt2.Y);

            // Przesunięcie punktów o wektor [1, 1]
            punkt1.PrzesunS(1, 1);
            punkt2.PrzesunC(1, 1);

            Console.WriteLine("Po przesunięciu:");
            Console.WriteLine("Punkt 1 - X: {0}, Y: {1}", punkt1.X, punkt1.Y);
            Console.WriteLine("Punkt 2 - X: {0}, Y: {1}", punkt2.X, punkt2.Y);

            // Pomnożenie punktów przez liczbę
            int scalar = 2;
            Punkt2DS pomnozonyPunkt1 = Punkt2DS.ScalarS(punkt1, scalar);
            Punkt2DC pomnozonyPunkt2 = Punkt2DC.ScalarC(punkt2, scalar);

            Console.WriteLine("Po pomnożeniu przez {0}:", scalar);
            Console.WriteLine("Punkt 1 - X: {0}, Y: {1}", pomnozonyPunkt1.X, pomnozonyPunkt1.Y);
            Console.WriteLine("Punkt 2 - X: {0}, Y: {1}", pomnozonyPunkt2.X, pomnozonyPunkt2.Y);

            Console.ReadKey();
        }
    }
}
