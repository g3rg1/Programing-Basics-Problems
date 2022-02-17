using System;

namespace Sums_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i == 1 || i % 3 == 1)
                {
                    sum1 += num;
                }
                else if (i == 2 || i % 3 == 2)
                {
                    sum2 += num;
                }
                else
                    sum3 += num;
            }
            Console.WriteLine("sum1 = {0}", sum1);
            Console.WriteLine("sum2 = {0}", sum2);
            Console.WriteLine("sum3 = {0}", sum3);
        }
    }
}
