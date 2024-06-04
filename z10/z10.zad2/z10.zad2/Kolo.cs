using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z10.zad2
{
    internal class Kolo:Figura
    {
        double promien;

        public Kolo(double promien)
        {
            this.promien = promien;
        }

        public override double Pole
        {
            get { return Math.Pow(promien, 2) * Math.PI; }
        }

        public override double Obwod()
        {
            return 2 * Math.PI * promien;
        }
    }
}
