using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4.zad2
{
    internal struct Dzien
    {
        int DzienMiesiaca { get; set; }
        Miesiace mies {  get; set; }
        PoryRoku pory {  get; set; }

        public Dzien(int dzienMiesiaca, Miesiace mies, PoryRoku pory)
        {
            this.DzienMiesiaca = dzienMiesiaca;
            this.mies = mies;
            this.pory = pory;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Numer dnia miesiąca: {0}", DzienMiesiaca);
            Console.WriteLine("Miesiąc: {0}", mies);
            Console.WriteLine("Pora roku: {0}", pory);
        }
    }
}
