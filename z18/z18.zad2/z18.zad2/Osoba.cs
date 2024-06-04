using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace z18.zad2
{
    internal class Osoba
    {
        string idosoby;
        protected string imie;
        protected string nazwisko;
        protected DateTime dataurodzenia;

        public string IDosoby
        {
            get { return idosoby; }
            set
            {
                if(IsValidId(value))
                {
                    idosoby = value;
                }
                else
                {
                    throw new ArgumentException("Niepoprawny identyfikator osoby");
                }
            }
        }

        public string Imie
        {
            get { return imie; }
            set
            {
                if(IsValidId(value))
                {
                    imie = value;
                }
                else
                {
                    throw new ArgumentException("Niepoprawne imię");
                }
            }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set
            {
                if (IsValidId(value))
                {
                    nazwisko = value;
                }
                else
                {
                    throw new ArgumentException("Niepoprawne nazwisko");
                }
            }
        }



        public bool IsValidId(string id)
        {
            string pattern = @"^\d{3}-[A-Z0-9]{2,3}-\d{3}/[a-z]{2}/$";
            return Regex.IsMatch(id, pattern);
        }

        public bool IsValidImie(string imie)
        {
            string pattern = @"^[A-Z][a-zA-Z]*$";
            return Regex.IsMatch (imie, pattern);
        }

        public bool IsValidNazwisko(string nazwisko)
        {
            string pattern = @"^[A-Z][a-zA-Z]*([- ][A-Z][a-zA-Z]*)*$";
            return Regex.IsMatch(nazwisko,pattern);
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Id osoby: {idosoby}");
            Console.WriteLine($"Imię: {imie}");
            Console.WriteLine($"Nazwisko: {nazwisko}");
            Console.WriteLine($"Data urodzenia: {dataurodzenia.ToShortDateString()}");
        }
    }
}
