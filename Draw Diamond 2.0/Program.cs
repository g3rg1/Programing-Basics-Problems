using System;

namespace Draw_Diamond_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("*");
            }
            else
            {
                if (n % 2 != 0)
                {
                    Console.Write(new string('-', (n - 1) / 2));
                    Console.Write("*");
                    Console.Write(new string('-', (n - 1) / 2));
                    Console.WriteLine();
                }

                for (int row = ((n * 2) / 4) - 1; row >= 0; row--)
                {
                    var midDash = (n - row * 2) - 2;
                    if (midDash < 0)
                    {
                        midDash = 0;
                    }
                    Console.Write(new string('-', row));
                    Console.Write("*");
                    Console.Write(new string('-', midDash));
                    Console.Write("*");
                    Console.Write(new string('-', row));
                    Console.WriteLine();

                }

                for (int row = 1; row < (n * 2) / 4; row++)
                {
                    var midDash = (n - row * 2) - 2;
                    if (midDash < 0)
                    {
                        midDash = 0;
                    }
                    Console.Write(new string('-', row));
                    Console.Write("*");
                    Console.Write(new string('-', midDash));
                    Console.Write("*");
                    Console.Write(new string('-', row));
                    Console.WriteLine();

                }

                if (n % 2 != 0)
                {
                    Console.Write(new string('-', (n - 1) / 2));
                    Console.Write("*");
                    Console.Write(new string('-', (n - 1) / 2));
                    Console.WriteLine();
                }
            }
        }
    }
}
