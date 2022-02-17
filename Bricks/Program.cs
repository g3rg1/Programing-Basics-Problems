using System;

namespace Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var bricks = Decimal.Parse(Console.ReadLine());
            var workers = Decimal.Parse(Console.ReadLine());
            var load = Decimal.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling(bricks / (workers * load)));
        }
    }
}
