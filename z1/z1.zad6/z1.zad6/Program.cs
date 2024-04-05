namespace z1.zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostopadloscian [] p = new Prostopadloscian[2];
            p[0] = new Prostopadloscian(12,34,64);
            p[1] = new Prostopadloscian(2, 6, 8);

            foreach(Prostopadloscian s in p)
            {
                Console.WriteLine(s.ToString());
            }
            bool czytakiesame = p[0].Porownanie(p[0], p[1]);
            Console.WriteLine("Czy prostopadłościany mają takie same objętosci: {0}", czytakiesame);
            
        }
    }
}
