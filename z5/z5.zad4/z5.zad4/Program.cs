namespace z5.zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatyzKalendarza uno = new DatyzKalendarza(2012,12,23);
            Console.WriteLine(uno.ToString());

            DatyzKalendarza dos = uno - 54;
            Console.WriteLine(dos.ToString());

            DatyzKalendarza tres = uno + 24;
            Console.WriteLine(tres.ToString());
        }
    }
}
