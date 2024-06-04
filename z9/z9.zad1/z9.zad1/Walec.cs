using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z9.zad1
{
    internal class Walec:FiguryPrzestrzenne
    {
        double promien;
        double wysokosc;

        public override double Objetosc()
        {
            return Math.Pow(promien,2) * wysokosc * Math.PI;
        }

        public override double PolePowierzchniBocznej()
        {
            return 2 * (Math.PI * promien * wysokosc);
        }
    }
}
