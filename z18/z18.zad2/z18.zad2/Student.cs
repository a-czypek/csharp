using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z18.zad2
{
    internal class Student:Osoba
    {
        private DateTime _dataPrzyjeciaNaStudia;
        private int _rokStudiow;
        private string _kierunekStudiow;

        public DateTime DataPrzyjeciaNaStudia
        {
            get { return _dataPrzyjeciaNaStudia; }
            set { _dataPrzyjeciaNaStudia = value; }
        }

        public int RokStudiow
        {
            get { return _rokStudiow; }
            set { _rokStudiow = value; }
        }

        public string KierunekStudiow
        {
            get { return _kierunekStudiow; }
            set { _kierunekStudiow = value; }
        }

        public void WyswietlInformacje()
        {
            base.WyswietlInformacje();
            Console.WriteLine($"Data przyjęcia na studia: {_dataPrzyjeciaNaStudia.ToShortDateString()}");
            Console.WriteLine($"Rok studiów: {_rokStudiow}");
            Console.WriteLine($"Kierunek studiów: {_kierunekStudiow}");
        }
    }
}
