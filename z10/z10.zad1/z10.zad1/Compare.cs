using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z10.zad1
{
    internal class Comparer : IComparer<Towar>
    {
        public int Compare(Towar x, Towar y)
        {
            return string.Compare(x.Nazwa, y.Nazwa);
        }
    }
}
