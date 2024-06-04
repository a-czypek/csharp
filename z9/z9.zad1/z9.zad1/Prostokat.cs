using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z9.zad1
{
    internal class Prostokat : FiguryPlaskie
    {
        double a;
        double b;

        public override double Pole()
        {
            return a * b;
        }

        public override double Obwod()
        {
            return (2 * a) + (2 * b);
        }

        public static bool operator==(Prostokat p1, Prostokat p2)
        {
            return ((p1.a == p2.a) && (p1.b == p2.b)) || ((p1.a == p2.b) && (p1.b == p2.a));
        }

        public static bool operator !=(Prostokat p1, Prostokat p2)
        {
            return !((p1.a == p2.a) && (p1.b == p2.b)) || ((p1.a == p2.b) && (p1.b == p2.a));
        }
    }
}
