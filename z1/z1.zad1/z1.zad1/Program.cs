namespace z1.zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kolo[] k = new Kolo[2];
            k[0] = new Kolo(4);
            k[1] = new Kolo(-6);

            foreach(Kolo i in k) 
            {
                Console.WriteLine(i.ToString());
            }

        }
    }
}
