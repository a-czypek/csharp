using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z13.zad1
{
    internal class Punkt
    {
        public float X {  get; set; }
        public float Y { get; set; }

        public Punkt (float x, float y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
