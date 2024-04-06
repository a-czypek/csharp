using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2.zad2
{
    internal class Punkt
    {
        public int x;
        public int y;

        public Punkt()
        {
            x = 1;
            y = 1;
        }
        public Punkt(int x, int y)
        {
            if (x > 0 || x < 1024 && y > 0 || y < 768)
            {
                this.x = x;
                this.y = y;
            }
            else
                throw new ArgumentException("Punkt nie mieści się w zakresie");
        }

        //public int X
        //{
        //    get { return  x; }
        //    set { x = value; }
        //}

    }
}
