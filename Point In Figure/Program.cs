using System;

namespace Point_In_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            if ((x >= 2 && x <= 12) && (y >= -5 && y <= 3))
            {
                if (((x >= 4 && x <= 10) && (y >= -5 && y <= 3)) ||
                    (x >= 2 && x <= 12) && (y >= -3 && y <= 1))
                {
                    Console.Write("in");
                }
                else
                {
                    Console.Write("Out");
                }
            }
            else
                Console.Write("Out");
        }
    }
}
