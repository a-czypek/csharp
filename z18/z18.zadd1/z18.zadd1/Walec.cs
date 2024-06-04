using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z18.zadd1
{
    internal class Walec : BrylyObrotowe
    {
        double promien;
        double wysokosc;

        public Walec(double promien, double wysokosc)
        {
            if (wysokosc > 0 && promien > 0)
            {
                this.promien = promien;
                this.wysokosc = wysokosc;
            }
            else
                throw new Exception("Promień lub wysokość mają nie odpowiedni wymiar");
            
        }

        public override double Objetosc => Math.Pow(promien, 2) * Math.PI * wysokosc; 

        public override double PolePowierzchniBocznych => 2 * Math.PI * promien * (promien + wysokosc);

        public override string ToString()
        {
            return $"To jest walec o powierzchni bocznej {PolePowierzchniBocznych} i objętości {Objetosc}.";
        }

        public static bool operator ==(Walec w1, Walec w2)
        {
            return w1.Objetosc == w2.Objetosc ;
        }

        public static bool operator !=(Walec w1, Walec w2)
        {
            return !(w1.Objetosc == w2.Objetosc);
        }
    }
}
