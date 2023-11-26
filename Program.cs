using System;
namespace PierwiastkiRownaniaKwadratowego
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź liczbę a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wprowadź liczbę b");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wprowadź liczbę c");
            double c = Convert.ToDouble(Console.ReadLine());

            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta > 0)
            {
                double x1b = -b - Math.Sqrt(delta) / 2 * a;
                double x1a = Math.Round(x1b);
                double x2b = -b + Math.Sqrt(delta) / 2 * a;
                double x2a = Math.Round(x2b);
                Console.WriteLine($"Rozwiązaniami równania kwadratowego są {x1a} i {x2a}.");
            }

            if (delta == 0)
            {
                double x0b = -b / 2 * a;
                double x0a = Math.Round(x0b);
                Console.WriteLine($"Rozwiązaniem równania kwadratowego jest {x0a}.");
            }

            if (delta < 0)
            {
                Console.WriteLine("Równanie kwadratowe nie ma rozwiązań.");
            }
        }
    }
}
