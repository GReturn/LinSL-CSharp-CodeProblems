using System;

namespace MultiplesOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if(i % 3 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(i);
                }
            }
        }
    }
}
