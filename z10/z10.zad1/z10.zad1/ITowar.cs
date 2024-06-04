using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z10.zad1
{
    internal interface ITowar
    {
        string Nazwa { get; set; }
        double Cena { get; set; }
        int IloscWMagazynie { get; set; }
    }
}
