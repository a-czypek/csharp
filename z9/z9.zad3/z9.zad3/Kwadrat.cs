using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z9.zad3
{
    internal class Kwadrat : IFigura
    {
        double a;

        public Kwadrat(double a)
        {
            this.a = a;
        }

        public double pole
        {
            get { return Math.Pow(a, 2); }
        }

        public double obwod
        {
            get { return a * 4; }
        }

        public double poleFigury()
        {
            return a*a;
        }

        public double obwodFigury()
        {
            return 4 * a;
        }
    }
}
