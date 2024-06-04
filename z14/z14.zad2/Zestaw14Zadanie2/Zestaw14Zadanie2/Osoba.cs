using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw14Zadanie2
{
    internal class Osoba
    {
        public string nazwisko { get; set; }
        public string imie { get; set; }
        public DateTime dataUrodzenia { get; set; }

        public Osoba(string n, string i, DateTime du)
        {
            nazwisko = n;
            imie = i;
            dataUrodzenia = du;
        }
    }
}
