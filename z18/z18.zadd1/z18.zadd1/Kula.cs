using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z18.zadd1
{
    internal class Kula : BrylyObrotowe
    {
        private double promien;

        public Kula(double promien)
        {
            if (promien > 0)
                this.promien = promien;
            else
                throw new ArgumentException("Promień ma nieodpowiednią wartość");
        }

        public override double Objetosc => 4 * (Math.PI * Math.Pow(promien, 3)) / 3;

        public override double PolePowierzchniBocznych => 4 * Math.PI * Math.Pow(promien, 2);

        public override string ToString()
        {
            return $"To jest kula o powierzchni bocznej {PolePowierzchniBocznych} i objętości {Objetosc}.";
        }

        public static bool operator ==(Kula k1, Kula k2)
        {
            return k1.Objetosc == k2.Objetosc;
        }

        public static bool operator !=(Kula k1, Kula k2)
        {
            return !(k1.Objetosc == k2.Objetosc);
        }
    }
}
