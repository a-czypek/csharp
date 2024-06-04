using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z13.zad1
{
    internal class Smartphone
    {
        public string Producent { get; set; }
        public float Ekran { get; set; }
        public int PamiecRAM { get; set; }
        public int PamiecWbudowana { get; set; }
        public string Procesor { get; set; }

        public Smartphone(string producent,
                          float ekran,
                          int pamiecRAM,
                          int pamiecWbudowana,
                          string procesor)
        {
            Producent = producent;
            Ekran = ekran;
            PamiecRAM = pamiecRAM;
            PamiecWbudowana = pamiecWbudowana;
            Procesor = procesor;
        }

        public override string ToString()
        {
            return $"{Producent} {Ekran}";
        }
    }
}
