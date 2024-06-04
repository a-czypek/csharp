using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z10.zad1
{
    internal class Towar:ITowar
    {
        string nazwa;
        double cena;
        int iloscwmagazynie;
        string identyfikator;

        public Towar(string nazwa, double cena, int iloscwmagazynie, string identyfikator)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.iloscwmagazynie = iloscwmagazynie;
            this.identyfikator = identyfikator;
        }

        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }

        public int IloscWMagazynie
        {
            get { return iloscwmagazynie; }
            set { iloscwmagazynie = value; }
        }

        public override string ToString()
        {
            return $"{nazwa,-8} {cena,-5} {iloscwmagazynie,3}";
        }

        public static void WyswietlTowary(List<Towar> towary)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Nazwa   Cena  Ilość");
            Console.WriteLine("--------------------");
            foreach (var towar in towary)
            {
                Console.WriteLine(towar);
            }
            Console.WriteLine("--------------------");
        }
    }
}
