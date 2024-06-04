using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z10.zad3
{
    internal class Student : IOsoba
    {
        public string nazwa { get; private set; }

        public Student(string Nazwa)
        {
            this.nazwa = Nazwa;
        }

        public void Opisz()
        {
            Console.WriteLine("Jestem studentem o nazwie: " + nazwa);
        }
    }
}
