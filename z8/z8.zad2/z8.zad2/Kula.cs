using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z8.zad2
{
    internal class Kula:Okrag
    {
        public Kula(double promien)
        {
            Promien = promien;
        }

        public double Pole => Math.Pow(Promien, 2) * Math.PI * 4;

        public double Objetosc => (4 * Math.PI * Math.Pow(Promien, 3)) / 3;

        public string ToString()
        {
            return $"{typeof(Kula).Name,-8} {Promien, -5} {Pole, -6:F2} {Objetosc,-7:F2}";
        }
       
    }
}
