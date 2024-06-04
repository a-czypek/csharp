using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z8.zad4
{
    internal class RachunekOszczędnosciowy:Konto
    {
        double minimalnyStan;
        double oprocentowanie;

        public RachunekOszczędnosciowy(double minimalnyStan, double oprocentowanie, 
            string nazwa, double stanPoczatkowy):base(nazwa, stanPoczatkowy)
        {
            this.minimalnyStan = minimalnyStan;
            this.oprocentowanie = oprocentowanie;
        }

        public override double oplatyBankowe()
        {
            if (_stan < minimalnyStan)
                return 10;
            else
                return 0;
        }

        public override double odsetk()
        {
            if ((_stan > minimalnyStan))
                return (_stan - minimalnyStan) * oprocentowanie / 100;
            else
                return 0;
        }

        public string ToString()
        {
            return $"{_stan, -7} {minimalnyStan,-8} {oprocentowanie} {odsetk(),-7} {oplatyBankowe(),-8}";
        }
    }
}
