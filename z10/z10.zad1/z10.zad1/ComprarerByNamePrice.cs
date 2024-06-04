using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z10.zad1
{
    internal class ComprarerByNamePrice : IComparer<Towar>
    {
        public int Compare(Towar x, Towar y)
        {
            int result = string.Compare(x.Nazwa, y.Nazwa);
            if (result == 0)
            {
                result = x.Cena.CompareTo(y.Cena);
            }
            return result;
        }
    }
}
