using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z6.zad1
{
    internal class Macierz
    {

        private double?[,] _macierz;
        public Macierz(int i, int j)
        {
            if (i <= 0 || j <= 0)
                throw new FormatException("wartość nieprawidłowa");
            else
            {
                Random r = new Random();
                this._macierz = new double?[i, j];

                for (int l = 0; l < _macierz.GetLength(0); l++)
                {
                    for (int k = 0; k < _macierz.GetLength(1); k++)
                        _macierz[l, k] = r.NextDouble();
                }
            }
        }

        public Macierz(double?[,] macierzKwadratowa)
        {
            int n = macierzKwadratowa.GetLength(0);
            int m = macierzKwadratowa.GetLength(1);

            if (n != m)
            {
                throw new FormatException("macierz nie jest kwadratowa");
            }
            this._macierz = macierzKwadratowa;
        }

        public double?[,] macierz
        {
            get { return _macierz; }
            set { _macierz = value; }
        }

        public void WyswietlMacierz()
        {
            for (int i = 0; i < _macierz.GetLength(0); i++)
            {
                for (int j = 0; j < _macierz.GetLength(1); j++)
                {
                    Console.Write(_macierz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public Macierz Transpozycja()
        {
            int n = _macierz.GetLength(0);
            int m = _macierz.GetLength(1);

            Macierz Transponowana = new Macierz(m, n);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Transponowana.macierz[i, j] = _macierz[j, i];
                }
            }
            return Transponowana;
        }

        public static Macierz operator +(Macierz m1, Macierz m2)
        {
            if (m1.macierz.GetLength(0) != m2.macierz.GetLength(0) ||
                m1.macierz.GetLength(1) != m2.macierz.GetLength(1))
            {
                throw new Exception("macierze nie są równe");
            }

            int n = m1.macierz.GetLength(0);
            int m = m1.macierz.GetLength(1);
            Macierz suma = new Macierz(n, m);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    suma.macierz[i, j] = m1.macierz[i, j] + m2.macierz[i, j];
                }
            }

            return suma;
        }

        public static Macierz operator *(double a, Macierz m1)
        {
            int n = m1.macierz.GetLength(0);
            int m = m1.macierz.GetLength(1);

            Macierz iloczyn = new Macierz(n, m);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    iloczyn.macierz[i, j] = a * m1.macierz[i, j];
                }
            }

            return iloczyn;
        }
    }
}
