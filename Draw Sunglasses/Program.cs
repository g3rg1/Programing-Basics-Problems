using System;

namespace Draw_Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int nosePlace = 0;

            if (n % 2 == 0)
            {
                nosePlace = (n / 2) - 1;
            }
            else
            {
                nosePlace = ((n + 1) / 2) - 1;
            }


            for (int i = 0; i < n; i++)
            {

                Console.Write("*");

                if (i == 0 || i == n - 1)
                {
                    Console.Write(new string('*', 2 * n - 1));
                    Console.Write(new string(' ', n));
                    Console.Write(new string('*', 2 * n - 1));
                }

                else if ((n == 3 || n == 4 && i == 2) || (i == nosePlace))
                {


                    Console.Write(new string('/', 2 * n - 2));
                    Console.Write("*");
                    Console.Write(new string('|', n));
                    Console.Write("*");
                    Console.Write(new string('/', 2 * n - 2));

                }
                else
                {
                    Console.Write(new string('/', 2 * n - 2));
                    Console.Write("*");
                    Console.Write(new string(' ', n));
                    Console.Write("*");
                    Console.Write(new string('/', 2 * n - 2));
                }

                Console.Write("*");
                Console.WriteLine();

            }
        }
    }
}
