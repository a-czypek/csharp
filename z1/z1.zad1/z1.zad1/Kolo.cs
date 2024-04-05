using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1.zad1
{
    internal class Kolo
    {
        int promien;

        public Kolo(int pro) 
        {
            this.promien = pro;
        }

        public double Obwod ()
        {
            return 2 * Math.PI * promien;
        }

        public override string ToString()
        {
            double obw = Obwod();
            return $"Obwód wynosi: {obw}";
        }
    }
}
