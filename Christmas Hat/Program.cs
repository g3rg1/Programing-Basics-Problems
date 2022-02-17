using System;

namespace Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string dots = new string('.', n * 2 - 1);
            Console.WriteLine("{0}/|\\{0}", dots);
            Console.WriteLine("{0}\\|/{0}", dots);
            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",
                    new string('.', n * 2 - (i + 1)),
                    new string('-', i));
            }

            Console.WriteLine(new string('*', n * 4 + 1));

            Console.Write("*");
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(".*");
            }
            Console.WriteLine();
            Console.Write(new string('*', n * 4 + 1));
        }
    }
}
