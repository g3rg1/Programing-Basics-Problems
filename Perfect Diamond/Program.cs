using System;

namespace Perfect_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int spaces = n - 1; spaces >= 0; spaces--)
            {
                Console.Write(new string(' ', spaces));
                Console.Write("*");
                for (int stars = 1; stars < n - spaces; stars++)
                {
                    Console.Write("-*");
                }
                Console.Write(new string(' ', spaces));
                Console.WriteLine();
            }
            for (int spaces = 1; spaces < n; spaces++)
            {
                Console.Write(new string(' ', spaces));
                Console.Write("*");
                for (int stars = 1; stars < n - spaces; stars++)
                {
                    Console.Write("-*");
                }
                Console.Write(new string(' ', spaces));
                Console.WriteLine();
            }
        }
    }
}
