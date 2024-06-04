using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z8.zad2
{
    internal class Okrag
    {
        private double _promien;
        public double Promien
        {
            get { return (_promien < 0) ? 0.00 : _promien; }
            set { _promien = value; }
        }
        public double Srednica
        {
            get { return Promien * 2; }
        }
        public double Obwod
        {
            get { return Srednica * 3.14159; }
        }
        public double Pole
        {
            get { return Promien * Promien * 3.14159; }
        }
    }
}
