using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z8.zad1
{
    internal class Osoba
    {
        private string _nazwisko;
        private string _imiePierwsze;
        private string _imieDrugie;
        private DateTime _dataUrodzenia;
        public Osoba(string nazwisko, string imie1, string imie2,
        DateTime dataUrodzenia)
        {
            this._nazwisko = nazwisko.Trim().ToUpper();
            this._imiePierwsze = imie1.Trim().ToUpper();
            this._imieDrugie = imie2.Trim().ToUpper();
            this._dataUrodzenia = dataUrodzenia;
        }
        public string nazwisko
        {
            get { return this._nazwisko; }
            set { this._nazwisko = value.Trim().ToUpper(); }
        }
    }
}
