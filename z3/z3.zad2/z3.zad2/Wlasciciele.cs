using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3.zad2
{
    internal class Wlasciciele
    {
        public string imie {  get; set; }
        public string nazwisko { get; set; }
        public string kraj {  get; set; }

        public Wlasciciele(string imie, string nazwisko, string kraj) 
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.kraj = kraj;
        }

        public override string ToString()
        {
            return $"Imie i nazwisko: {imie} {nazwisko}. Mieszka w kraju {kraj}";
        }

    }
}
