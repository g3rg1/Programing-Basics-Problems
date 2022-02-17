using System;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var n = int.Parse(Console.ReadLine());
                    var num = n;

                    if (num % 2 == 0)
                    {
                        Console.WriteLine("Even {0}", num);
                        break;
                    }
                    Console.WriteLine("uneven number");

                }
                catch
                {
                    Console.WriteLine("Invalid number");
                }
            }
        }
    }
}
