using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z5.zad2
{
    internal class Punkt
    {
        public float x {  get; set; }
        public float y { get; set; }

        public Punkt(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public static Punkt operator *(int x, Punkt p)
        {
            return new Punkt(x * p.x, x * p.y);
        }
        public static Punkt operator *(Punkt p, int x)
        {
            return new Punkt(p.x * x, p.y * x);
        }
        public static bool operator ==(Punkt p, Punkt a)
        {
            if (p.x == a.x && p.y == a.y)
                return true;
            else
                return false;
        }
        public static bool operator !=(Punkt p, Punkt a)
        {
            return !(p == a);
        }
    }
}
