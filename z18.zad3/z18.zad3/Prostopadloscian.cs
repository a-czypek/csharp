using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z18.zad3
{
    public class Prostopadloscian
    {
        public double dlugosc;
        public double szerokosc {  get; set; }
        public double wysokosc {  get; set; }

        public Prostopadloscian()
        {
            dlugosc = 1;
            szerokosc = 1;
            wysokosc = 1;
        }

        public Prostopadloscian(double dlugosc, double szerokosc, double wysokosc)
        {
            if(dlugosc > 0 && wysokosc > 0 && szerokosc > 0)
            {
                this.dlugosc = dlugosc;
                this.szerokosc = szerokosc;
                this.wysokosc = wysokosc;
            }
            else
            {
                throw new Exception("Wymiary są nieodpowiednie");
            }
        }

        public double Dlugosc
        {
            get { return dlugosc; }
            set
            {
                if (dlugosc < 0)
                    throw new Exception("Długość jest mniejsza od 0");
                dlugosc = value;
            }
        }

        public double Wysokosc
        {
            get { return wysokosc; }
            set
            {
                if(wysokosc < 0)
                    throw new Exception("Wysokość jest mniejsza od 0");
                wysokosc = value;
            }
        }

        public double Szerokosc
        {
            get { return szerokosc; }
            set
            {
                if (szerokosc < 0)
                    throw new Exception("Szerokość jest mniejsza od 0");
                szerokosc = value;
            }
        }

        public double Objetosc()
        {
            return dlugosc * szerokosc * wysokosc;
        }

        public double PolePowierzchniBocznej()
        {
            return 2 * dlugosc * szerokosc + 2 * szerokosc * wysokosc + 2 * wysokosc * dlugosc;
        }
    }
}
