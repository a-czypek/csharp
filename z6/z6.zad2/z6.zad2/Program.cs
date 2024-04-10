namespace z6.zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Walec w = new Walec(4, 8);
            Prostokat p = new Prostokat(6, 9);
            Walec p1 = new Walec(p);

            Console.WriteLine(w.ToString());
            Console.WriteLine(p1.ToString());
        }
    }
}
