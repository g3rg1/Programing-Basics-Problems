using System;

namespace Increasing_4_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var nFrst = 0;
            var nScnd = a + 1;
            var nThrd = a + 2;
            var nFrth = a + 3;

            if (b - a <= 2)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int n1 = a; n1 < nScnd; n1++)
                {
                    nFrst = n1;
                    for (int n2 = nFrst + 1; n2 < nThrd; n2++)
                    {
                        nScnd = n2;
                        for (int n3 = nScnd + 1; n3 < nFrth; n3++)
                        {
                            nThrd = n3;
                            for (int n4 = nThrd + 1; n4 <= b; n4++)
                            {
                                nFrth = n4;
                                Console.WriteLine("{0} {1} {2} {3}", nFrst, nScnd, nThrd, nFrth);
                            }
                        }
                    }
                }
            }
        }
    }
}
