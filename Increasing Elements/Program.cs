using System;

namespace Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            var savedElement = int.MinValue;
            var savedCount = 0;
            for (int i = 0; i < n; i++)
            {
                var element = int.Parse(Console.ReadLine());
                if (element > savedElement)
                {
                    savedElement = element;
                    count++;
                    if (savedCount < count)
                    {
                        savedCount = count;
                    }
                }
                else
                {
                    savedElement = element;
                    count = 1;
                }
            }
            Console.WriteLine(savedCount);
        }
    }
}
