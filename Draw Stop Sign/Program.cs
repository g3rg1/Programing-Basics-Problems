using System;

namespace Draw_Stop_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}",
                new string('.', n + 1),
                new string('_', 2 * n + 1),
                new string('.', n + 1));

            for (int row = n; row > 0; row--)
            {
                Console.WriteLine("{0}//{1}\\\\{0}",
                    new string('.', row),
                    new string('_', 4 * n - (2 * row + 1)),
                    new string('.', row));
            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (4 * n - 6) / 2));
            for (int botRow = 0; botRow <= n - 1; botRow++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}",
                    new string('.', botRow),
                    new string('_', 4 * n - (2 * botRow + 1)),
                    new string('.', botRow));
            }
        }
    }
}
