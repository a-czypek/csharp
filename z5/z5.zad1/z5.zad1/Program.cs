namespace z5.zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ulamek u1 = new Ulamek(2,3);
            Ulamek u2 = new Ulamek(1,4);

            Console.WriteLine($"Ułamek u1: {u1.licznik}/{u1.mianownik}");
            Console.WriteLine($"Ułamek u2: {u2.licznik}/{u2.mianownik}");

            Ulamek u3 = +u1;
            Console.WriteLine($"Ułamek u3: {u3.licznik}/{u3.mianownik}");
            Ulamek u4 = -u1;
            Console.WriteLine($"Ułamek u4: {u4.licznik}/{u4.mianownik}");

            Ulamek u5 = u1 + u2;
            Ulamek u6 = u1 - u2;
            Ulamek u7 = u1 * u2;
            Ulamek u8 = u1 / u2;

            Console.WriteLine($"Dodawanie ułamków daje rezultat: {u5.licznik}/{u5.mianownik}");
            Console.WriteLine($"Odejmowanie ułamków daje rezultat: {u6.licznik}/{u6.mianownik}");
            Console.WriteLine($"Mnożenie ułamka u1 przez ułamek u2: {u7.licznik}/{u7.mianownik}");
            Console.WriteLine($"Dzielenie ułamków u1 i u2: {u8.licznik}/{u8.mianownik}");
        }
    }
}
