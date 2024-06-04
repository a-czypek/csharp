using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z9.zad1
{
    internal class Stozek:FiguryPrzestrzenne
    {
        double stozkowa;
        double promien;
        double wysokosc;

        public override double Objetosc()
        {
            return (Math.PI * Math.Pow(promien, 2) * wysokosc) / 3;
        }

        public override double PolePowierzchniBocznej()
        {
            return Math.PI * promien * stozkowa;
        }
    }
}
