using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw14Zadanie1
{
    internal class Ksiazka
    {
        public string Autor { get; set; }
        public string Tytul { get; set; }
        public int RokWydania { get; set; }
        public int LiczbaStron { get; set; }

        public Ksiazka(string a, string t, int rw, int ls)
        {
            Autor = a;
            Tytul = t;
            RokWydania = rw;
            LiczbaStron = ls;
        }
    }
}
