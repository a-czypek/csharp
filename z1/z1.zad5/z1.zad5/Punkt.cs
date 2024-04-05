using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1.zad5
{
    internal class Punkt
    {
        float x;
        float y;

        int color;

        public Punkt(float x, float y, int color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

        public void UstawKolor(int colo)
        {
            if(colo >= 0 && colo <= 255)
            {
                this.color = colo;
            }
            else
            {
                throw new Exception("Nieprawidłowa wartość koloru");
            }
        }
        public override string ToString()
        {
            return $"Punkt o współrzędnych {x} i {y}. Ma kolor {color}";
        }
    }
}
