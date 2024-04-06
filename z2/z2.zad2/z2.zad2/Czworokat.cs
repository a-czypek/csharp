using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2.zad2
{
    internal class Czworokat
    {
        private Punkt A;
        private Punkt B;
        private Punkt C;
        private Punkt D;

        public Czworokat(Punkt A,  Punkt B, Punkt C, Punkt D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }

        private double Dlugosc(Punkt p1, Punkt p2)
        {
            double dl = Math.Sqrt((p2.x - p1.x) * (p2.x - p1.x) + (p2.y - p1.y) * (p2.y - p1.y));
            return dl;
        }

        public double Obwod()
        {
            double obw = Dlugosc(A,B) + Dlugosc(B,C) + Dlugosc(C,D) + Dlugosc(D,A);
            return obw;
        }

        

       
    }
}
