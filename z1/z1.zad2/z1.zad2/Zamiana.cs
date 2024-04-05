using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1.zad2
{
    internal class Zamiana
    {
        string tekst;

        public Zamiana(string t)
        {
            this.tekst = t;
            tekst.ToLower().Trim();
        }

        public string Change()
        {
            string samogloski = "aeyouAEYOU";

            foreach (char  c in samogloski)
            {
                tekst = tekst.Replace(c, '*');
            }
            return tekst;
        }

        public override string ToString()
        {
            string ch = Change();
            return $"Zamiana tekstu: {tekst}, wygląda następująco {ch}";
        }
    }
}
