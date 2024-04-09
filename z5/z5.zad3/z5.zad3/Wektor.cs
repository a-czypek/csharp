using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace z5.zad3
{
    internal class Wektor
    {
        private double[] valuel;
        private static readonly Random random = new Random();

        public Wektor(double[] elements)
        {
            if (elements == null)
                throw new ArgumentNullException(nameof(elements));

            if (elements.Length == 0)
                throw new ArgumentException("Tablica musi zawierać co najmniej jedną wartość.");

            valuel = new double[elements.Length];
            Array.Copy(elements, valuel, elements.Length);
        }

        public Wektor(int length)
        {
            if (length <= 0)
                throw new ArgumentOutOfRangeException(nameof(length), "Długość wektora musi być dodatnia.");

            valuel = new double[length];
            for (int i = 0; i < length; i++)
            {
                valuel[i] = random.NextDouble();
            }
        }

        public int Length
        {
            get { return valuel.Length; }
        }
        public double this[int index]
        {
            get
            {
                if (index < 0 || index >= valuel.Length)
                    throw new IndexOutOfRangeException("Nieprawidłowy indeks wektora.");
                return valuel[index];
            }
            set
            {
                if (index < 0 || index >= valuel.Length)
                    throw new IndexOutOfRangeException("Nieprawidłowy indeks wektora.");
                valuel[index] = value;
            }
        }
        public Wektor ScalarProduct(double scalar)
        {
            double[] result = new double[valuel.Length];
            for (int i = 0; i < valuel.Length; i++)
            {
                result[i] = valuel[i] * scalar;
            }
            return new Wektor(result);
        }
        public static Wektor operator *(Wektor vector1, Wektor vector2)
        {
            if (vector1.Length != vector2.Length)
                throw new ArgumentException("Wektory muszą być tej samej długości.");

            double[] result = new double[vector1.Length];
            for (int i = 0; i < vector1.Length; i++)
            {
                result[i] = vector1[i] * vector2[i];
            }
            return new Wektor(result);
        }

        // Przeciążone operatory == oraz !=
        public static bool operator ==(Wektor vector1, Wektor vector2)
        {
            if (ReferenceEquals(vector1, vector2))
                return true;

            if (vector1 is null || vector2 is null)
                return false;

            if (vector1.Length != vector2.Length)
                return false;

            for (int i = 0; i < vector1.Length; i++)
            {
                if (vector1[i] != vector2[i])
                    return false;
            }

            return true;
        }

        public static bool operator !=(Wektor vector1, Wektor vector2)
        {
            return !(vector1 == vector2);
        }
        public override string ToString()
        {
            return "[" + string.Join(", ", valuel) + "]";
        }
    }
}

