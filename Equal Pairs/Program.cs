using System;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var PairSum = 0;
            var MaxPairDiff = int.MinValue;
            var PairSum1 = 0;

            for (int i = 1; i <= n; i++)
            {
                var Num1 = int.Parse(Console.ReadLine());
                var Num2 = int.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    PairSum = Num1 + Num2;
                }
                else
                {
                    PairSum1 = Num1 + Num2;
                }

                if (i != 1)
                {
                    MaxPairDiff = Math.Max(PairSum, PairSum1) - Math.Min(PairSum, PairSum1);
                }

            }

            if (MaxPairDiff != 0 && n != 1)
            {
                Console.WriteLine("No, maxdiff = " + MaxPairDiff);
            }
            else
            {
                Console.WriteLine("Yes, value = " + PairSum);
            }
        }
    }
}
