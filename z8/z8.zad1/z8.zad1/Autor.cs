using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z8.zad1
{
    internal class Autor : Osoba
    {
        string pseudonim;
        string jezyk;

        public Autor(string pseudonim, string jezyk, string nazwisko, string imie1, string imie2,
        DateTime dataUrodzenia):base(nazwisko, imie2, imie1, dataUrodzenia)
        {
            this.pseudonim = pseudonim;
            this.jezyk = jezyk;
        }

        public string Pseudonim
        {
            get { return pseudonim; }
            set { pseudonim = value;}
        }

        public string Jezyk
        {
            get { return jezyk; }
            set { jezyk = value; }
        }
    }
}
