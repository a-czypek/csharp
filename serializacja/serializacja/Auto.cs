using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace serializacja
{
    internal class Auto
    {
        public string marka {  get; set; }
        public string model { get; set; }
        public int rok { get; set; }
        public string kolor { get; set; }
        public double cena { get; set; }

        public Auto(string marka, string model, int rok, string kolor, double cena)
        {
            this.marka = marka;
            this.model = model;
            this.rok = rok;
            this.kolor = kolor;
            this.cena = cena;
        }

        public string ToString()
        {
            return $"{marka,-15} {model, -15} {rok, -6} {kolor, -10} {cena,-10}";
        }

    }
}
