using System;

namespace Draw_Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string(' ', n) + " | " + new string(' ', n));

            for (int row = 0; row < n; row++)
            {
                for (int left = 0; left < (n - row) - 1; left++)
                {
                    Console.Write(" ");
                }
                for (int left = 0; left < row + 1; left++)
                {
                    Console.Write("*");
                }

                Console.Write(" | ");

                for (int right = 0; right < row + 1; right++)
                {
                    Console.Write("*");
                }
                for (int right = 0; right < (n - row) - 1; right++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
