using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4.zad1
{
    internal struct Punkt2DS
    {
        int x;
        int y;

        public Punkt2DS()
        {
            x = 0;
            y = 0;
        }

        public Punkt2DS(int x, int y)
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

        public void PrzesunS(int a, int b)
        {
            x += a;
            y += b;
        }

        public static Punkt2DS ScalarS(Punkt2DS p, int scalar)
        {
            return new Punkt2DS(p.x * scalar, p.y * scalar);
        }
    }
}
