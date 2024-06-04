using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw12Zadanie2
{
    internal class Adres
    {
        public string Ulica {  get; set; }
        public string NumerDomu { get; set; }
        public short NumerMieszkania { get; set; }
        public string KodPocztowy {  get; set; }
        public string Miasto {  get; set; }

        public Adres(string ulica, 
                     string numerDomu, 
                     short numerMieszkania, 
                     string kodPocztowy, 
                     string miasto)
        {
            Ulica = ulica;
            NumerDomu = numerDomu;
            NumerMieszkania = numerMieszkania;
            KodPocztowy = kodPocztowy;
            Miasto = miasto;
        }

        public override string ToString()
        {
            return $"{Ulica} {NumerDomu}/{NumerDomu} {KodPocztowy} {Miasto}";
        }
    }
}
