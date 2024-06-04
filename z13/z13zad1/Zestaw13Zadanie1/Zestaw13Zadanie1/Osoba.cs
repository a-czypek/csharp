using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z13.zad1
{
    internal class Osoba
    {
        public string Nazwisko {  get; set; }
        public string Imie {  get; set; }
        public DateTime DataUrodzenia { get; set; }

        public Osoba(string n, string i, DateTime du)
        { 
            Nazwisko = n;
            Imie = i;
            DataUrodzenia = du;
        }

        public override string ToString()
        {
            return $"{Nazwisko} {Imie} {DataUrodzenia.ToShortDateString()}";
        }
    }
}
