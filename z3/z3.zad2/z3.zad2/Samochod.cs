using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace z3.zad2
{
    internal class Samochod
    {
        public string marka { get; set; }
        public string rok { get; set; }
        public string model { get; set; }
        public string kolor { get; set; }
        public List<Wlasciciele> wlasci { get; set; }
        public List<Badania> bada { get; set; }

        public Samochod(string marka, string rok, string model, string kolor, List<Wlasciciele> wlasciciele, List<Badania> badania)
        {
            this.marka = marka;
            this.rok = rok;
            this.model = model;
            this.kolor = kolor;
            this.wlasci = wlasciciele;
            this.bada = badania;
        }

        public void DodajWlasciciela(Wlasciciele wlasciciel)
        {
            wlasci.Add(wlasciciel);
        }
        public void DodajBadanie(Badania badania)
        {
            bada.Add(badania);
        }

        public override string ToString()
        {
            string info = $"Marka: {marka}\nModel: {model}\nRok produkcji: {rok}\nKolor: {kolor}\n";
            info += "\nWłaściciele:";
            foreach (var wlasciciel in wlasci)
            {
                info += $"\n{wlasciciel}";
            }
            info += "\n\nBadania kontrolne:";
            foreach (var badanie in bada)
            {
                info += $"\n{badanie}";
            }
            return info;
        }
    }
}
