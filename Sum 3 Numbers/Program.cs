using System;

namespace Sum_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var largest = Math.Max(Math.Max(a, b), Math.Max(b, c));
            var smallest = Math.Min(Math.Min(a, b), Math.Min(b, c));
            var result = largest - smallest;
            if (result == a)
            {
                Console.WriteLine("{0}+{1}={2}", smallest, a, largest);
            }
            else if (result == b)
            {
                Console.WriteLine("{0}+{1}={2}", smallest, b, largest);
            }
            else if (result == c)
            {
                Console.WriteLine("{0}+{1}={2}", smallest, c, largest);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
