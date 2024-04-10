namespace z6.zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie obiektu punktu 3D za pomocą konstruktora bezargumentowego
            Punkt3D punkt1 = new Punkt3D();
            Console.WriteLine("Punkt 1 (bezargumentowy):");
            Console.WriteLine($"x: {punkt1.x}, y: {punkt1.y}, z: {punkt1.z}");

            // Tworzenie obiektu punktu 3D za pomocą konstruktora z trzema argumentami
            Punkt3D punkt2 = new Punkt3D(1.0, 2.0, 3.0);
            Console.WriteLine("\nPunkt 2 (z trzema argumentami):");
            Console.WriteLine($"x: {punkt2.x}, y: {punkt2.y}, z: {punkt2.z}");

            // Tworzenie obiektu punktu 3D za pomocą konstruktora z tablicą
            double[] wspolrzedne = { 2.5, 3.5, 4.5 };
            Punkt3D punkt3 = new Punkt3D(wspolrzedne);
            Console.WriteLine("\nPunkt 3 (z tablicą współrzędnych):");
            Console.WriteLine($"x: {punkt3.x} , y:  {punkt3.y} , z:  {punkt3.z}");

            // Przesunięcie punktu 3D za pomocą metody przesun wersja 1
            punkt1.przesun(0.5, 1.5, 2.5);
            Console.WriteLine("\nPo przesunięciu punktu 1 (wersja 1):");
            Console.WriteLine($"x: {punkt1.x} , y:  {punkt1.y} , z:  {punkt1.z}");

            // Przesunięcie punktu 3D za pomocą metody przesun wersja 2
            double[] wektorPrzesuniecia = { 1.0, 1.0, 1.0 };
            punkt2.przesun(wektorPrzesuniecia);
            Console.WriteLine("\nPo przesunięciu punktu 2 (wersja 2):");
            Console.WriteLine($"x: {punkt2.x} , y:  {punkt2.y} , z:  {punkt2.z}");

            Console.ReadKey();
        }
    }
}
