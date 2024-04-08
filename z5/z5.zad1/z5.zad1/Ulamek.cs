using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5.zad1
{
    internal struct Ulamek
    {
        public int licznik { get; set; }
        public int mianownik { get; set; }

        public Ulamek(int licznik, int mianownik)
        {
            if (mianownik == 0)
                throw new ArgumentException("Mianownik jest równy zero");
            this.licznik = licznik;
            this.mianownik = mianownik;
        }

        public static Ulamek operator + (Ulamek liczba)
        {

            return liczba;
        }
        public static Ulamek operator - (Ulamek liczba)
        {
            return new Ulamek(-liczba.licznik, liczba.mianownik);
        }
        public static Ulamek operator + (Ulamek l1, Ulamek l2)
        {
            return new Ulamek(l1.licznik * l2.mianownik + l2.licznik * l1.mianownik, l1.mianownik * l2.mianownik);
        }
        public static Ulamek operator - (Ulamek l1, Ulamek l2)
        {
            return new Ulamek(l1.licznik * l2.mianownik - l2.licznik * l1.mianownik, l1.mianownik * l2.mianownik);
        }
        public static Ulamek operator * (Ulamek l1, Ulamek l2)
        {
            return new Ulamek(l1.licznik * l2.licznik, l1.mianownik * l2.mianownik);
        }
        public static Ulamek operator /(Ulamek l1, Ulamek l2)
        {
            if (l2.licznik == 0)
                throw new ArgumentException("Dzielenie przez 0");
            return new Ulamek(l1.licznik * l2.mianownik, l1.mianownik * l2.licznik);
        }
    }
}
