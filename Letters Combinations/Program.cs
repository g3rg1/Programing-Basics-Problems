using System;

namespace Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] charArr = { "0","a", "b", "c", "d", "e", "f", "g","h","i","j",
            "k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z" };

            var n = Console.ReadLine().ToLower();
            var m = Console.ReadLine().ToLower();
            var x = Console.ReadLine().ToLower();
            var skip = Array.IndexOf(charArr, x);
            var start = Array.IndexOf(charArr, n);
            var stop = Array.IndexOf(charArr, m);
            var count = 0;
            for (int i = start; i <= stop; i++)
            {
                for (int j = start; j <= stop; j++)
                {
                    for (int h = start; h <= stop; h++)
                    {
                        if (h != skip && j != skip && i != skip)
                        {
                            count++;
                            Console.Write("{0}{1}{2} ", charArr[i], charArr[j], charArr[h]);
                        }
                    }
                }
            }
            Console.Write(count);
        }
    }
}
