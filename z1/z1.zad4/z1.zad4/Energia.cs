using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1.zad4
{
    internal class Energia
    {
        public int PoczatkowaEnergia;
        public int ObecnaEnergia;

        public Energia(int o, int p)
        {
            this.PoczatkowaEnergia = o;
            this.ObecnaEnergia = p;
        }

        public int poczatkowaEnergia
        {
            get { return PoczatkowaEnergia; }
            set { PoczatkowaEnergia = value; }
        }
        public int obecnaEnergia
        {
            get { return ObecnaEnergia; }
            set
            {
                if (value > PoczatkowaEnergia)
                {
                    ObecnaEnergia = value;
                }
                else
                {
                    throw new ArgumentException("Wartość energi nie jest zgodna (jest mniejsza niż energia początkowa)");
                }
            }
        }

        public int Zuzycie()
        {
            return ObecnaEnergia - PoczatkowaEnergia;
        }

        public override string ToString()
        {
            int zu = Zuzycie();
            return $"Stan początkowy to: {PoczatkowaEnergia}, a stan obecny to: {ObecnaEnergia}. Łączne zużycie wynosi: {zu}";
        }
    }
}
