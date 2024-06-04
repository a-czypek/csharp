using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z9.zad3
{
    internal interface IFigura
    {
        double pole
        {
            get;
        }
        double obwod
        {
            get;
        }
        double poleFigury();
        double obwodFigury();
    }
}
