using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z10.zad2
{
    internal abstract class Figura
    {
        public abstract double Pole
        {
            get;
        }

        public abstract double Obwod();
    }
}
