using System;

namespace Crossing_Sequences__Corrected_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tribNums = new int[30];
            var frstTrib = int.Parse(Console.ReadLine());
            var scndTrib = int.Parse(Console.ReadLine());
            var thirdTrib = int.Parse(Console.ReadLine());
            var startProg = int.Parse(Console.ReadLine());
            var stepProg = int.Parse(Console.ReadLine());
            var tribRslt = 0;
            var innerIterCount = 0;
            int iter;
            int outerIterCount;
            bool result = false;
            for (int i = 0; ; i++)
            {
                tribRslt = frstTrib + scndTrib + thirdTrib;
                if (i == 0)
                {
                    tribNums[i] = frstTrib;
                    tribNums[i + 1] = scndTrib;
                    tribNums[i + 2] = thirdTrib;
                }
                tribNums[i + 3] = tribRslt;
                frstTrib = scndTrib;
                scndTrib = thirdTrib;
                thirdTrib = tribRslt;
                if (tribRslt >= 1000000)
                    break;
            }
            for (outerIterCount = 0; ; outerIterCount++)
            {
                for (iter = 0; iter < innerIterCount && iter != innerIterCount; iter++)
                {
                    startProg += stepProg;
                }
                if (iter == innerIterCount)
                {
                    iter = 0;
                }
                if (outerIterCount == 2)
                {
                    outerIterCount = 0;
                    innerIterCount++;
                }
                if (startProg > 1000000)
                    break;
                foreach (int i in tribNums)
                {
                    if (i == startProg)
                    {
                        Console.WriteLine(startProg);
                        result = true;
                        break;
                    }
                }
                if (result == true)
                    break;
            }

            if (result == false)
                Console.WriteLine("No");
        }
    }
}
