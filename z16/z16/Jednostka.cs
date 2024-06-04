using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z16
{
    public abstract class Jednostka
    {
        public int stan;
        public abstract string Symbol { get; set; }
        public abstract string Nazwa { get; set; }
        public abstract string JednostkaMiary { get; set; }
        public Jednostka(int stanPoczatkowy)
        {
            if (stanPoczatkowy < 0)
                throw new ArgumentOutOfRangeException("Stan poczatkowy mniejszy od zera");
                stan = stanPoczatkowy;
        }
        public abstract void zmniejszenieStanu(int wartsc);
        public abstract void zwiekszenieStanu(int wartsc);
    }
}
