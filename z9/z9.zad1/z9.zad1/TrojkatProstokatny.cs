using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z9.zad1
{
    internal class TrojkatProstokatny:FiguryPlaskie
    {
        double a;
        double b;
        double c;

        public override double Pole()
        {
            return (a * b) / 2;
        }

        public override double Obwod()
        {
            return a + b + c;
        }
    }
}
