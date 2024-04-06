using static System.Runtime.InteropServices.JavaScript.JSType;

namespace z2.zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Daty data1 = new Daty(2024, 2, 29);
                Console.WriteLine($"Krótka data: {data1.KrótkaData()}");
                Console.WriteLine($"Długa data: {data1.DługaData()}");
                Console.WriteLine($"Szczegółowa data: {data1.SzczegółowaData()}");

                data1.NazwaMiesiaca = "maj";
                Console.WriteLine($"Po zmianie miesiąca: {data1.SzczegółowaData()}");

                Daty data2 = new Daty(data1);
                Console.WriteLine($"Kopia daty: {data2.SzczegółowaData()}");

                Daty data3 = new Daty(2024, "czerwiec", 15);
                Console.WriteLine($"Data z podanym miesiącem jako string: {data3.SzczegółowaData()}");

                // Próba utworzenia daty z nieprawidłowymi danymi
                // DATY data4 = new DATY(2000, 13, 32); // wywoła wyjątek ArgumentOutOfRangeException
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił wyjątek: {ex.Message}");
            }
        }
    }
}
