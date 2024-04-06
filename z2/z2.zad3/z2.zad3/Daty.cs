using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace z2.zad3
{
    internal class Daty
    {
        private int _rok;
        private int _miesiac;
        private int _dzien;
        private int _numerDniaWTygodniu;
        private string _nazwaDniaTygodnia;
        private string _nazwaMiesiaca;

        public Daty(int rok, int miesiac, int dzien)
        {
            SprawdzPoprawnoscDanych(rok, miesiac, dzien);
            _rok = rok;
            _miesiac = miesiac;
            _dzien = dzien;
            UstawNazwyDniMiesiecy();
            UstawDzienTygodnia();
        }

        public Daty(Daty data)
        {
            _rok = data._rok;
            _miesiac = data._miesiac;
            _dzien = data._dzien;
            _numerDniaWTygodniu = data._numerDniaWTygodniu;
            _nazwaDniaTygodnia = data._nazwaDniaTygodnia;
            _nazwaMiesiaca = data._nazwaMiesiaca;
        }

        public Daty(int rok, string nazwaMiesiaca, int dzien)
        {
            SprawdzPoprawnoscDanych(rok, KonwertujMiesiac(nazwaMiesiaca), dzien);
            _rok = rok;
            _miesiac = KonwertujMiesiac(nazwaMiesiaca);
            _dzien = dzien;
            UstawNazwyDniMiesiecy();
            UstawDzienTygodnia();
        }

        public int Rok
        {
            get { return _rok; }
            set
            {
                if (value >= 1600 && value <= 9999)
                    _rok = value;
                else
                    throw new ArgumentOutOfRangeException("Rok musi być z zakresu od 1600 do 9999.");
            }
        }

        public int Miesiac
        {
            get { return _miesiac; }
            set
            {
                if (value >= 1 && value <= 12)
                    _miesiac = value;
                else
                    throw new ArgumentOutOfRangeException("Miesiąc musi być z zakresu od 1 do 12.");
            }
        }

        public int Dzien
        {
            get { return _dzien; }
            set
            {
                if (value >= 1 && value <= 31)
                    _dzien = value;
                else
                    throw new ArgumentOutOfRangeException("Dzień musi być z zakresu od 1 do 31.");
            }
        }

        public string NazwaMiesiaca
        {
            get { return _nazwaMiesiaca; }
            set
            {
                SprawdzPoprawnoscDanych(_rok, KonwertujMiesiac(value), _dzien);
                _miesiac = KonwertujMiesiac(value);
                _nazwaMiesiaca = value;
            }
        }

        public int NumerDniaWTygodniu
        {
            get { return _numerDniaWTygodniu; }
        }

        public string NazwaDniaTygodnia
        {
            get { return _nazwaDniaTygodnia; }
        }

        public string KrótkaData()
        {
            return $"{_rok}-{_miesiac:D2}-{_dzien:D2}";
        }

        public string DługaData()
        {
            return $"{_dzien} {_nazwaMiesiaca} {_rok}";
        }

        public string SzczegółowaData()
        {
            return $"{_dzien} {_nazwaMiesiaca} {_rok}, {_nazwaDniaTygodnia}";
        }

        private void UstawNazwyDniMiesiecy()
        {
            string[] nazwyMiesiecy = { "styczeń", "luty", "marzec", "kwiecień", "maj", "czerwiec", "lipiec", "sierpień", "wrzesień", "październik", "listopad", "grudzień" };
            _nazwaMiesiaca = nazwyMiesiecy[_miesiac - 1];
        }

        private void UstawDzienTygodnia()
        {
            int m = _miesiac <= 2 ? _miesiac + 12 : _miesiac;
            int y = _miesiac <= 2 ? _rok - 1 : _rok;
            int q = _dzien;
            int K = y % 100;
            int J = y / 100;

            _numerDniaWTygodniu = (q + ((13 * (m + 1)) / 5) + K + (K / 4) + (J / 4) - (2 * J)) % 7;

            string[] dniTygodnia = { "niedziela", "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota" };
            _nazwaDniaTygodnia = dniTygodnia[_numerDniaWTygodniu];
        }

        private void SprawdzPoprawnoscDanych(int rok, int miesiac, int dzien)
        {
            if (rok < 1600 || rok > 9999)
                throw new ArgumentOutOfRangeException("Rok musi być z zakresu od 1600 do 9999.");
            if (miesiac < 1 || miesiac > 12)
                throw new ArgumentOutOfRangeException("Miesiąc musi być z zakresu od 1 do 12.");
            if (dzien < 1 || dzien > DateTime.DaysInMonth(rok, miesiac))
                throw new ArgumentOutOfRangeException("Dzień musi być zgodny z wybranym miesiącem.");
        }

        private int KonwertujMiesiac(string nazwaMiesiaca)
        {
            string[] nazwyMiesiecy = { "styczeń", "luty", "marzec", "kwiecień", "maj", "czerwiec", "lipiec", "sierpień", "wrzesień", "październik", "listopad", "grudzień" };
            for (int i = 0; i < nazwyMiesiecy.Length; i++)
            {
                if (nazwyMiesiecy[i] == nazwaMiesiaca)
                    return i + 1;
            }
            throw new ArgumentException("Nieprawidłowa nazwa miesiąca.");
        }
    }
}
