using System;

namespace Dance
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());

            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
        }
    }

    class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        //overload the + operator
        public static DancerPoints operator+ (DancerPoints dancerObject1, DancerPoints dancerObject2)
        {
            string names = $"{dancerObject1.name} & {dancerObject2.name}";
            int sumOfPoints = dancerObject1.points + dancerObject2.points;

            DancerPoints total = new DancerPoints(names, sumOfPoints);
            return total;
        }
    }
}
