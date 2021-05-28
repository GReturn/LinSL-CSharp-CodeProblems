using System;

namespace LevelPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Result: {AddPoints(levels)}");
        }

        static int AddPoints(int _levels)
        {
            if(_levels == 1 || _levels == 0)
            {
                return 1;
            }
            return _levels + AddPoints(_levels - 1);
        }
    }
}
