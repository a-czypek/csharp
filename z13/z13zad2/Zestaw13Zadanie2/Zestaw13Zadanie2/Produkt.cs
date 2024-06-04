using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z13.zad2
{
    internal class Produkt
    {
        public int ProduktID { get; private set; }
        public string ProduktNazwa { get; private set; }
        public decimal ProduktCenaNetto { get; private set; }
        public decimal ProduktVAT {  get; private set; }
            

        public Produkt(int productId, string productName, decimal productPrice, decimal vat)
        {
            ProduktID = productId;
            ProduktNazwa = productName;
            ProduktCenaNetto = productPrice;
            ProduktVAT = vat;
        }

            
    }

}