namespace z2.zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt s1 = new Punkt(6,9);
            Punkt s2 = new Punkt(5,3);

            string w = s1.Przesuniecie(s1,s2);
            double dl = s1.Dlugosc(s1 ,s2);
            bool s = s1.Porownaj(s1 ,s2);

            Console.WriteLine($"Pierwszy punkt o współrzędnych: [{s1.X}, {s1.Y}].");
            Console.WriteLine($"Drugi punkt o współrzędnych: [{s2.X}, {s2.Y}]");
            Console.WriteLine($"Przesunięcie punktu s1 o wektor [5,3]: {w}");
            Console.WriteLine($"Długość pomiędzy tymi punktami wynosi: {dl}");
            Console.WriteLine($"Czy punkty są równe? {s}");

        }
    }
}
