using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2.zad1
{
    internal class Kolo
    {
        double promien;

        public Kolo()
        {
            promien = 1;
        }
        public Kolo(double promien)
        {
            if(promien > 0)
            {
                this.promien = promien;
            }
            else
            {
                throw new ArgumentException("Wartość promienia jest niezgodna - mniejsza od 0");
            }
        }
        public double PROMIEN
        { get { return promien; }
            set 
            {
                if(value > 0)
                {
                    this.promien = value;
                }
                else
                {
                    throw new ArgumentException("Argument jest błędny");
                }
            }
        }
        public double Pole
        { get { return Math.PI * promien * promien; } }

        public double Obwod
        { get { return 2 * Math.PI * promien;} }

        public double Srednica
        {
            get { return 2 * promien; }
            set 
            {
                if(value > 0)
                {
                    promien = value / 2;
                }
                else
                {
                    throw new Exception("Liczba jest 0");
                }
            }
        }
        public bool TakieSame(Kolo k1, Kolo k2)
        {
            return k1.promien == k2.promien;
        }
        public override string ToString()
        {
            return $"Promień: {promien,-5}, średnica {Srednica,-5}. Obwód wynosi: {Obwod,-7}, a pole: {Pole,-7}";
        }
    }
}
