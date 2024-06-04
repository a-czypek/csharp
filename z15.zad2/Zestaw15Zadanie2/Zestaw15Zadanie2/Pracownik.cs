using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw15Zadanie2
{
    internal class Pracownik
    {
        public int ID { get; set; }
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public int StazPracy { get; set; }
        public decimal Wynagrodzenie { get; set; }

        public Pracownik(int id, string n, string i, int sp, decimal w)
        {
            ID = id;
            Nazwisko = n;
            Imie = i;
            StazPracy = sp;
            Wynagrodzenie = w;
        }
    }
}
