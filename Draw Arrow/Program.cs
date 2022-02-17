using System;

namespace Draw_Arrow
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}",
                new string('.', (n - 1) / 2),
                new string('#', n));
            for (int row = 0; row < n - 2; row++)
            {
                Console.WriteLine("{0}#{1}#{0}",
                    new string('.', (n - 1) / 2),
                    new string('.', n - 2));
            }
            Console.WriteLine("{0}#{1}#{0}",
                    new string('#', (n - 1) / 2),
                    new string('.', n - 2));
            for (int botRows = 1; botRows <= n - 2; botRows++)
            {
                Console.WriteLine("{0}#{1}#{0}",
                    new string('.', botRows),
                    new string('.', 2 * n - (3 + 2 * botRows)));
            }
            Console.WriteLine("{0}#{0}", new string('.', n - 1));
        }
    }
}
