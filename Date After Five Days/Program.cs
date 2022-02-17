using System;

namespace Date_After_Five_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var monthDays = 0;
            switch (m)
            {
                case 2:
                    monthDays = 28;
                    break;
                case 4:
                    monthDays = 30;
                    break;
                case 6:
                    monthDays = 30;
                    break;
                case 9:
                    monthDays = 30;
                    break;
                case 11:
                    monthDays = 30;
                    break;
                default:
                    monthDays = 31;
                    break;
            }
            if ((d + 5) > monthDays)
            {
                m++;
                if (m > 12)
                {
                    m = 1;
                }
                d = Math.Abs(monthDays - (d + 5));
            }
            else
            {
                d += 5;
            }
            Console.WriteLine("{0}.{1:D2}", d, m);
        }
    }
}
