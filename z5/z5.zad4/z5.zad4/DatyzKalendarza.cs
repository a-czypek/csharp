using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5.zad4
{
    internal class DatyzKalendarza
    {
        public int rok;
        public int miesiac;
        public int dzien;

        public DatyzKalendarza()
        {
            rok = 2000;
            miesiac = 1;
            dzien = 1;
        }
        public DatyzKalendarza(int rok, int miesiac, int dzien)
        {
            this.rok = rok;
            this.miesiac = miesiac;
            this.dzien = dzien;
        }
        public int Miesiac
        { 
            get { return miesiac; } 
            set
            {
                if (value > 0 && value < 13)
                {
                    miesiac = value;
                }
                else
                    throw new ArgumentException("Nieprawidłowa liczba miesiąca");
            }
        }
        public int Dzien
        {
            get { return dzien; }
            set
            {
                if (value > 0 && value < 32)
                    dzien = value;
                else
                    throw new ArgumentException("Nieprawidłowa wartość dnia");
            }
        }
        public int Rok
        {
            get { return rok; }
            set
            {
                if (value > 0)
                {
                    rok = value;
                }
                else 
                    throw new ArgumentException("Rok nie może być ujemny");
            }
        }

        public static DatyzKalendarza operator+(DatyzKalendarza d, int m)
        {
            DateTime dt = new DateTime(d.rok, d.miesiac, d.dzien);
            dt = dt.AddDays(m);
            return new DatyzKalendarza(dt.Year, dt.Month, dt.Day);
        }
        public static DatyzKalendarza operator -(DatyzKalendarza dt, int m)
        {
            DateTime sd = new DateTime(dt.rok, dt.miesiac, dt.dzien);
            sd = sd.AddDays(-m);
            return new DatyzKalendarza(sd.Year, sd.Month, sd.Day);
        }
        public override string ToString()
        {
            return $"Data to: {dzien}/{miesiac}/{rok}";

        }
    }
}
