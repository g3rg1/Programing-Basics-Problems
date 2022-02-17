using System;

namespace Magic_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int n1 = 1;
            int n2 = 1;
            int n3 = 1;
            int n4 = 1;
            int n5 = 1;
            int n6 = 1;
            var product = n1 * n2 * n3 * n4 * n5 * n6;
            void Result()
            {
                if (product == n)
                {
                    Console.Write("{0}{1}{2}{3}{4}{5} ", n1, n2, n3, n4, n5, n6);

                }

            }
            for (n1 = 1; n1 <= 9; n1++)
            {
                Result();
                for (n2 = 1; n2 <= 9; n2++)
                {
                    Result();
                    for (n3 = 1; n3 <= 9; n3++)
                    {
                        Result();
                        for (n4 = 1; n4 <= 9; n4++)
                        {
                            Result();
                            for (n5 = 1; n5 <= 9; n5++)
                            {
                                Result();
                                for (n6 = 1; n6 <= 9; n6++)
                                {
                                    Result();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
