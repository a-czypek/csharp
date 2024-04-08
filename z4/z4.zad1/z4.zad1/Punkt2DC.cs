using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4.zad1
{
    internal class Punkt2DC
    {
        int x;
        int y;

        public Punkt2DC()
        {
            x = 0;
            y = 0;
        }

        public Punkt2DC(int x, int y)
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

        public void PrzesunC(int a, int b)
        {
            a += x;
            b += y;
        }

        public static Punkt2DC ScalarC(Punkt2DC pc, int scalar)
        {
            return new Punkt2DC(pc.x * scalar, pc.y * scalar);
        }
    }
}
