using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1.zad3
{
    internal class Student
    {
        string imie;
        string nazwisko;
        string nrAlbumu;
        float srednia;

        public Student(string im, string naz, string nr, float sr)
        {
            this.imie = im;
            this.nazwisko = naz;
            this.nrAlbumu = nr;
            if (sr >= 2 && srednia <= 5)
            {
                this.srednia = sr;
            }
            else
            {
                throw new Exception("Nieprawidłowa średnia");
            }
        }

        public float stypendium()
        {
            if(srednia >= 2 && srednia <= 4)
            {
                return 0f;
            }
            else if (srednia > 4 && srednia < 4.81)
            {
                return 300f;
            }
            else
            {
                return 600f;
            }
        }

        public override string ToString()
        {
            float sty = stypendium();
            return $"Imię: {imie,-8} Nazwisko: {nazwisko,-8} Numer Albumu: {nrAlbumu,-7} średnia: {srednia,-6} więc stypendium wynosi: {sty,-5} zł";
        }




        //metody, ktore modyfikuja

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        public string NrAlbumu
        {
            get { return nrAlbumu; }
            set { nrAlbumu = value; }
        }
        public float SredniaOcen
        {
            get { return srednia; }
            set
            {
                if (value >= 2 && value <= 5)
                {
                    srednia = value;
                }
                else
                    throw new FormatException("Nieprawidlowa wartosc sredniej ocen");
            }
        }
    }
}
