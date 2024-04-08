using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace z5.zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie wektora z wykorzystaniem tablicy liczb rzeczywistych
            double[] initialVectorValues = { 1.0, 2.0, 3.0 };
            Wektor vector1 = new Wektor(initialVectorValues);
            Console.WriteLine("Wektor 1: " + vector1);

            // Tworzenie wektora o długości n (gdzie n > 0) losowo wybranymi liczbami rzeczywistymi
            Wektor vector2 = new Wektor(3);
            Console.WriteLine("Wektor 2: " + vector2);

            // Mnożenie wektora przez liczbę rzeczywistą
            Console.WriteLine("Wektor 1:");
            double scalar = 2.0;
            for (int i = 0; i < vector1.Length; i++)
            {
                Console.WriteLine(vector1[i] * scalar);
            }

            // Mnożenie dwóch wektorów (jeśli mają taką samą długość)
            if (vector1.Length == vector2.Length)
            {
                Wektor multipliedVector = vector1 * vector2;
                Console.WriteLine("Wynik mnożenia wektorów 1 i 2: " + multipliedVector);
            }
            else
            {
                Console.WriteLine("Nie można pomnożyć wektorów, ponieważ mają różne długości.");
            }

            // Porównanie dwóch wektorów (jeśli mają taką samą długość)
            if (vector1.Length == vector2.Length)
            {
                Console.WriteLine($"Czy wektory 1 i 2 są równe?: {vector1 == vector2}");
            }
            else
            {
                Console.WriteLine("Nie można porównać wektorów, ponieważ mają różne długości.");
            }
            Console.ReadKey();
        }
    }
    
}
