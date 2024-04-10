using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z6.zad3
{
    class Punkt3D
    {
        public double x;
        public double y;
        public double z;
        public double[] a;

        // Konstruktor bezargumentowy
        public Punkt3D()
        {
            this.x = 0.0;
            this.y = 0.0;

            this.z = 0.0;
        }
        // Konstruktor z trzema argumentami typu double

        public Punkt3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Konstruktor z trzyelementową tablicą liczb rzeczywistych
        public Punkt3D(double[] koordynacja )
        {
            if (koordynacja.Length != 3)
                throw new ArgumentException("Tablica musi zawierać trzy elementy.");

            this.x = koordynacja[0];
            this.y = koordynacja[1];
            this.z = koordynacja[2];
        }
        // Metoda przesuń wersja 1
        public void przesun(double a, double b, double c)
        {
            x += a;
            y += b;
            z += c;
        }

        // Metoda przesuń wersja 2
        public void przesun(double[] wektor)
        {
            if (wektor.Length != 3)
                throw new Exception("Nieprawidłowy rozmiar wektora");
            wektor[0] += x;
            wektor[1] += y;
            wektor[2] += z;
        }
        public static bool operator ==(Punkt3D w, Punkt3D j)
        {
            if (w.x == j.x && w.y == j.y && w.z == j.z)
                return true;
            else
                return false;
        }
        public static bool operator !=(Punkt3D w, Punkt3D j)
        {
            return !(w.x == j.x && w.y == j.y && w.z == j.z);
        }
    }
}
