using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var former = 1;
            var latter = 1;
            for (int i = 0; i < n - 1; i++)
            {
                var fibNum = latter + former;

                former = latter;
                latter = fibNum;
            }
            Console.WriteLine(latter);
        }
    }
}
