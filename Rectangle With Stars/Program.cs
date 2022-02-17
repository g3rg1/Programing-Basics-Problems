using System;

namespace Rectangle_With_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('%', n * 2));
            for (int row = 0; row < (n - 1) / 2; row++)
            {
                Console.Write("%");
                Console.Write(new string(' ', n * 2 - 2));
                Console.Write("%");
                Console.WriteLine();
            }
            Console.WriteLine("%{0}**{0}%", new string(' ', (n * 2 - 4) / 2));
            for (int row = 0; row < (n - 1) / 2; row++)
            {
                Console.Write("%");
                Console.Write(new string(' ', n * 2 - 2));
                Console.Write("%");
                Console.WriteLine();
            }
            Console.WriteLine(new string('%', n * 2));
        }
    }
}
