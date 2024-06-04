using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw12Zadanie2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public Adres AdresZamieszkana { get; set; }
        public Adres AdresDoKorespondencji { get; set; }

        public Student(int id, 
                       string nazwisko, 
                       string imie, 
                       Adres adresZamieszkana, 
                       Adres adresDoKorespondencji)
        {
            Id = id;
            Nazwisko = nazwisko;
            Imie = imie;
            AdresZamieszkana = adresZamieszkana;
            AdresDoKorespondencji = adresDoKorespondencji;
        }

    }
}
