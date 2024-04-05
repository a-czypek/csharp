using System.Security.Cryptography;

namespace z2.zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj promień pierwszego koła");
                double p1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj promień drugiego koła");
                double p2 = Convert.ToDouble(Console.ReadLine());

                Kolo[] k = new Kolo[2];
                k[0] = new Kolo(p1);
                k[1] = new Kolo(p2);

                bool same = k[0].TakieSame(k[0], k[1]);

                foreach(Kolo j in k)
                {
                    Console.WriteLine(j.ToString());
                }
                Console.WriteLine("Czy koła są takie same? {0}", same);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
