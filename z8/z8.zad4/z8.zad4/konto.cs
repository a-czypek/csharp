using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z8.zad4
{
    abstract class Konto
    {
        private string _nazwa;
        protected double _stan;
        public Konto(string nazwa, double stanPoczatkowy)
        {
            this._nazwa = nazwa;
            this._stan = stanPoczatkowy;
        }
        public virtual void Uznanie(double wartosc)
        {
            this._stan += wartosc;
        }
        public virtual void Obciazenie(double wartosc)
        {
            this._stan -= wartosc;
        }
        public virtual void Wyswietl()
        {
            Console.WriteLine("Name={0}, balance={1}", this._nazwa,
            this._stan);
        }
        public void zmianaNazwy(string newName)
        {
            this._nazwa = newName;
        }
        public abstract double oplatyBankowe();
        public abstract double odsetk();
    }
}
