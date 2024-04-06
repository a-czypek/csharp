using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3.zad2
{
    internal class Badania
    {
        public string DataRoz {  get; set; }
        public string DataZak { get; set; }
        public string Status { get; set; }

        public Badania(string DataRoz, string DataZak, string Status) 
        {
            this.DataRoz = DataRoz;
            this.DataZak = DataZak;
            this.Status = Status;
        }

        public override string ToString()
        {
            return $"Badanie rozpoczęło się: {DataRoz}, a zakończyło się {DataZak}. Status badania: {Status}";
        }
    }
}
