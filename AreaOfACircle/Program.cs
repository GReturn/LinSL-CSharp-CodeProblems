using System;

namespace AreaOfACircle
{
    class Program
    {
        static void Main()
        {
            const double pi = 3.14;
            double radius = Double.Parse(Console.ReadLine());

            Console.WriteLine(pi * Math.Pow(radius, 2));
        }
    }
}
