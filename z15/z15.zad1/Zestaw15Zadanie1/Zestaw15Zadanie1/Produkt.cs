using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw15Zadanie1
{
    internal class Produkt
    {
        public int ID { get; set; }
        public string nazwa { get; set; }
        public string jm { get; set; }
        public decimal waroscNetto { get; set; }
        public decimal stawkaVAT { get; set; }

        public Produkt(int id, string n, string jm, decimal wn, decimal vat)
        {
            ID = id;
            nazwa = n;
            this.jm = jm;
            waroscNetto = wn;
            stawkaVAT = vat;
        }
    }
}
