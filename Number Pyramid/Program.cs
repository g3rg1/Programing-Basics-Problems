using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                var count = 1;

                for (int j = i; ; j++)
                {
                    Console.Write(j - 1);
                    if (i == count)
                    {

                        break;

                    }
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}
