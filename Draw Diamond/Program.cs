using System;

namespace Draw_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                for (int i = n; i > 0; i--)
                {
                    for (int dash = (i / 2); dash < 0; dash--)
                    {
                        Console.Write(new string('-', dash));
                    }
                    Console.Write("*");
                    for (int inDash = n - 2; inDash < 0; inDash--)
                    {
                        Console.Write("-");
                    }
                    Console.Write("*");
                    Console.Write(new string('-', (n / 2) - 1));
                    Console.WriteLine();
                }
            }
        }
    }
}
