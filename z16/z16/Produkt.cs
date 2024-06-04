using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace z16
{
    public class Produkt : Jednostka
    {

        public override string Symbol { get; set; }
        public override string Nazwa { get; set; }
        public override string JednostkaMiary { get; set; }

        public Produkt(string symbol, int stanPoczatkowy, string nazwa, string JednostkaMiary):base(stanPoczatkowy)
        {
            if(IsValidSymbol(symbol))
                this.Symbol = symbol;

            this.JednostkaMiary = JednostkaMiary;
            this.Nazwa = nazwa;
        }

        public override void zmniejszenieStanu(int wartsc)
        {
            stan = stan - wartsc;
        }
        public override void zwiekszenieStanu(int wartsc)
        {
            stan = stan + wartsc;
        }


        public bool IsValidSymbol(string symbol)
        {
            string pattern = @"^\d{4}-[A-Za-z]{3}\\\d{4}\\\d{2}\\\d{2}$";
            if (Regex.IsMatch(symbol, pattern))
                return true;
            else
                throw new Exception("Zły symbol produktu");
        }

        public string Serializuj()
        {
            string json = JsonSerializer.Serialize(this);
            return json;
        }
    }
}
