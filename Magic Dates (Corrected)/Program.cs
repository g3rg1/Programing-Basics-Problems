using System;

namespace Magic_Dates__Corrected_
{
    class Program
    {
        static void Main(string[] args)
        {
            var startYear = int.Parse(Console.ReadLine());
            var stopYear = int.Parse(Console.ReadLine());
            var weight = int.Parse(Console.ReadLine());
            DateTime current = new DateTime(startYear, 1, 1);
            bool result = false;
            while (current.Year <= stopYear)
            {
                int d1 = current.Day / 10;
                int d2 = current.Day % 10;
                int d3 = current.Month / 10;
                int d4 = current.Month % 10;
                int d5 = current.Year / 1000;
                int d6 = (current.Year / 100) % 10;
                int d7 = (current.Year / 10) % 10;
                int d8 = current.Year % 10;
                var currentWeight = d1 * (d2 + d3 + d4 + d5 + d6 + d7 + d8) +
                                    d2 * (d3 + d4 + d5 + d6 + d7 + d8) +
                                    d3 * (d4 + d5 + d6 + d7 + d8) +
                                    d4 * (d5 + d6 + d7 + d8) +
                                    d5 * (d6 + d7 + d8) +
                                    d6 * (d7 + d8) +
                                    d7 * d8;
                if (weight == currentWeight)
                {
                    Console.WriteLine("{0:D2}-{1:D2}-{2:D2}", current.Day, current.Month, current.Year);
                    result = true;
                }
                current = current.AddDays(1);
            }
            if (result == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
