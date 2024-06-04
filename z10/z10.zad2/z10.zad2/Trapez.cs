using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z10.zad2
{
    internal class Trapez:Figura
    {
        double podstawa1;
        double podstawa2;
        double wysokosc;
        double boczna;

        public Trapez(double podstawa1, double podstawa2, double wysokosc, double boczna)
        {
            this.podstawa1 = podstawa1;
            this.podstawa2 = podstawa2;
            this.wysokosc = wysokosc;
            this.boczna = boczna;
        }

        public override double Pole
        {
            get { return ((podstawa1 + podstawa2) * wysokosc) / 2; }
        }

        public override double Obwod()
        {
            return boczna * 2 + podstawa1 + podstawa2;
        }
    }
}
