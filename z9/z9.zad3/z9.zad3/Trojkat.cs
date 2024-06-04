using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z9.zad3
{
    internal class Trojkat :IFigura
    {
        private double podstawa;
        private double wysokosc;
        private double bokA;
        private double bokB;
        private double bokC;

        public Trojkat(double podstawa, double wysokosc, double bokA, double bokB, double bokC)
        {
            this.podstawa = podstawa;
            this.wysokosc = wysokosc;
            this.bokA = bokA;
            this.bokB = bokB;
            this.bokC = bokC;
        }

        public double pole
        {
            get { return (podstawa * wysokosc) / 2; }
        }

        public double obwod
        {
            get { return bokA + bokB + bokC; }
        }

        public double poleFigury()
        {
            return (podstawa * wysokosc) / 2;
        }

        public double obwodFigury()
        {
            return bokA + bokB + bokC;
        }
    }
}
