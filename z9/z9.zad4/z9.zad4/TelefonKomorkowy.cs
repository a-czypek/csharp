using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z9.zad4
{
    internal class TelefonKomorkowy
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string NumerTelefonu { get; set; }

        public TelefonKomorkowy(string marka, string model, string numerTelefonu)
        {
            Marka = marka;
            Model = model;
            NumerTelefonu = numerTelefonu;
        }
        public override string ToString()
        {
            return $"Marka: {Marka}, Model: {Model}, Numer Telefonu: {NumerTelefonu}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            TelefonKomorkowy other = (TelefonKomorkowy)obj;
            return NumerTelefonu == other.NumerTelefonu;
        }

        public override int GetHashCode()
        {
            return NumerTelefonu != null ? NumerTelefonu.GetHashCode() : 0;
        }
    }
}
