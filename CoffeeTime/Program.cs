using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            double discount = Convert.ToDouble(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            //your code goes here

            foreach (var item in coffee.Keys.ToArray())
            {
                int discountedItem = (int)Math.Ceiling((coffee[item] - ((discount / 100) * coffee[item])));
                Console.WriteLine($"{item}: {discountedItem}");
            }
        }
    }
}