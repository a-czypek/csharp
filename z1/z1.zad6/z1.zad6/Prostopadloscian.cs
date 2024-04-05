using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1.zad6
{
    internal class Prostopadloscian
    {
        double dlugosc { get; set; }
        double szerokosc { get; set; }
        double wysokosc { get; set; }
        
        public Prostopadloscian()
        {
            dlugosc = 1;
            szerokosc = 1;
            wysokosc = 1;
        }

        public Prostopadloscian(double dlugosc, double szerokosc, double wysokosc)
        {
            if(dlugosc > 0 && szerokosc > 0 && wysokosc > 0)
            {
                this.dlugosc = dlugosc;
                this.szerokosc = szerokosc;
                this.wysokosc = wysokosc;
            }
        }

        public double Objetosc()
        {
            return dlugosc * szerokosc * wysokosc;
        }
        
        public bool Porownanie(Prostopadloscian p1, Prostopadloscian p2)
        {
            return p1.Objetosc() == p2.Objetosc();
        }

        public override string ToString()
        {
            double ob = Objetosc();
            return $"W: {wysokosc,-5} S: {szerokosc,-5} D: {dlugosc,-5}, Objętość wynosi: {ob,-8}";
        }
    }
}

