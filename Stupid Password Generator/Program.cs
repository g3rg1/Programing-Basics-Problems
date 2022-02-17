using System;

namespace Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            char[] chrArr = { '0', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' };
            var firstNum = 1;
            int frstChr;
            int scndChrs;
            int space = 1;

            for (int scndNum = 1; ; scndNum++)
            {
                frstChr = 1;

                if (scndNum > n)
                {
                    firstNum++;
                    scndNum = 1;
                    frstChr = 1;
                }
                for (scndChrs = 1; ; scndChrs++)
                {
                    if (scndChrs > l)
                    {
                        frstChr++;
                        scndChrs = 1;
                    }
                    for (int last = Math.Max(scndNum, firstNum) + 1; last <= n; last++)
                    {
                        if (firstNum == 1 && scndNum == 1 && frstChr == 1 && scndChrs == 1 && last == 2)
                        {
                            space = 0;
                        }
                        Console.Write("{0}{1}{2}{3}{4}{5}", new string(' ', space),
                        firstNum, scndNum, chrArr[frstChr], chrArr[scndChrs], last);
                        space = 1;
                    }
                    if (frstChr == l && scndChrs == l)
                        break;
                }
                if (firstNum == n - 1 && scndNum == n - 1)
                    break;
            }
        }
    }
}
