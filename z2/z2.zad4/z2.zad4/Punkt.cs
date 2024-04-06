using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2.zad4
{
    internal class Punkt
    {
        int x;
        int y;

        public Punkt()
        {
            x = 1;
            y = 1;
        }

        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        { 
            get { return x; } 
            set { x = value; }
        
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public string Przesuniecie(Punkt p1, Punkt p2)
        {
            return $"Wektor: [{p1.x + p2.x}, {p1.y + p2.y}]";
        }

        public double Dlugosc(Punkt p1, Punkt p2)
        {
            double d = Math.Sqrt((p2.x - p1.x) * (p2.x - p1.x) + (p2.y - p1.y) * (p2.y - p1.y));
            return d;
        }

        public bool Porownaj(Punkt p1, Punkt p2)
        {
            return p1.x == p2.x && p1.y == p2.y;
        }
    }
}
