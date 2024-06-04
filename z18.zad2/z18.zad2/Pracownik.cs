using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z18.zad2
{
    internal class Pracownik : Osoba
    {
        string stanowisko;
        string formaZatrudnienia;
        DateTime datazatrudnienia;

        public string Stanowisko
        {
            get { return stanowisko; }
            set { stanowisko = value; }
        }

        public string FormaZatrudnienia
        {
            get { return formaZatrudnienia; }
            set { formaZatrudnienia = value; }
        }

        public DateTime Datazatrudnienia
        {
            get { return datazatrudnienia; }
            set { datazatrudnienia = value; }
        }

        public void WyswietlInformacje()
        {
            base.WyswietlInformacje(); 
            Console.WriteLine($"Stanowisko: {stanowisko}");
            Console.WriteLine($"Forma zatrudnienia: {formaZatrudnienia}");
            Console.WriteLine($"Data zatrudnienia: {datazatrudnienia.ToShortDateString()}");
        }

    }
}
