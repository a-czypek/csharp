using z10.zad1;

public class Program
{
    public static void Main()
    {
        List<Towar> towary = new List<Towar>
        {
            new Towar("Chleb", 3.50, 20, "1A"),
            new Towar("Masło", 7.00, 15, "2B"),
            new Towar("Mleko", 2.50, 50, "3C"),
            new Towar("Ser", 12.00, 10, "4D"),
            new Towar("Jajka", 5.00, 30, "5E")
        };

        Console.WriteLine("Nieposortowane towary:");
        Towar.WyswietlTowary(towary);

        towary.Sort(new Comparer());
        Console.WriteLine("\nPosortowane według nazwy:");
        Towar.WyswietlTowary(towary);

        towary.Sort(new ComprarerByPrice());
        Console.WriteLine("\nPosortowane według ceny:");
        Towar.WyswietlTowary(towary);

        towary.Sort(new ComprarerByNamePrice());
        Console.WriteLine("\nPosortowane według nazwy i ceny:");
        Towar.WyswietlTowary(towary);
    }

    
}