using System;

namespace Triangle_Coordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = int.Parse(Console.ReadLine());
            var y1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var y2 = int.Parse(Console.ReadLine());
            var x3 = int.Parse(Console.ReadLine());
            var y3 = int.Parse(Console.ReadLine());

            Double side = x2 - x3;
            Double height = Math.Max(y1, y3) - Math.Min(y1, y3);
            Console.WriteLine(Math.Abs(side * height / 2));
        }
    }
}
