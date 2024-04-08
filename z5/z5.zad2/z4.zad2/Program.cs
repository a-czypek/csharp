namespace z5.zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt a = new Punkt(3, 5);
            Punkt b = new Punkt(3, 5);
            Punkt e = new Punkt(3, 7);
            Punkt c = a * 3;
            Punkt d = 4 * a;

            Console.WriteLine($"Punkt a: {a.x},{a.y}");
            Console.WriteLine($"Punkt b: {b.x},{b.y}");

            Console.WriteLine($"Punkt c: {c.x},{c.y}");
            Console.WriteLine($"Punkt d: {d.x},{d.y}");

            Console.WriteLine("Punkt p1 i p2 są równe: {0}", a == b);
            Console.WriteLine("Punkt p1 i p2 są równe: {0}", b == e);
        }
    }
}
