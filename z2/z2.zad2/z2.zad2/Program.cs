namespace z2.zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt(3,6);
            Punkt p2 = new Punkt(3,16);
            Punkt p3 = new Punkt(9,16);
            Punkt p4 = new Punkt(9,3);

            Czworokat c1 = new Czworokat(p1,p2,p3,p4);
            double o = c1.Obwod();
            Console.WriteLine($"Czworokąt ma długość {o}");

        }
    }
}
