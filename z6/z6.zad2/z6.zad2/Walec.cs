using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z6.zad2
{
    internal class Walec
    {
        public double promienpodstawy;
        public double wysokosc;

        public Walec(double promienPodstawy, double wysokosc)
        {
            this.promienpodstawy = promienPodstawy;
            this.wysokosc = wysokosc;
        }
        public Walec(Prostokat p1)
        {
            promienpodstawy = p1.szerokosc / 2;
            wysokosc = p1.wysokosc;

        }
        public double objetosc
        {
            get { return Math.PI * (promienpodstawy * promienpodstawy) * wysokosc; }
        }
        public double polePodstaw
        {
            get { return Math.PI * (promienpodstawy * promienpodstawy); }
        }
        public double polePowierzchniBocznej
        {
            get { return 2 * Math.PI * promienpodstawy * wysokosc; }
        }

        public override string ToString()
        {
            return $"Walec ma wymiary {promienpodstawy}x{wysokosc}. " +
                $"Jego objętość wynosi {objetosc}, pole podstawy: {polePodstaw}," +
                $" a pole powierzchni bocznej: {polePowierzchniBocznej} ";
        }
    }
}
