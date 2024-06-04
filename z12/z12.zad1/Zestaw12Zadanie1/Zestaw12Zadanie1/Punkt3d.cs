using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw12Zadanie1
{
    public class Punkt3d
    {
        public float X {  get; set; }
        public float Y { get; set; }    
        public float Z { get; set; }

        public Punkt3d()
        {
            X = 0.0f;
            Y = 0.0f;
            Z = 0.0f;
        }

        public Punkt3d(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"({X:f4}; {Y:f4}; {Z:f4})";
        }
    }
}
