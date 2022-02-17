using System;

namespace Point_On_Segment
{
    class Program
    {
        static void Main(string[] args)
        {
            var frst = int.Parse(Console.ReadLine());
            var scnd = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());
            var distance = 0;
            string check = "";
            var second = Math.Max(frst, scnd);
            var first = Math.Min(frst, scnd);

            if (point >= first && point <= second)
            {
                check = "In";
                distance = Math.Min(Math.Abs(point - second), Math.Abs(first - point));

            }
            else
            {
                check = "Out";
                if (point < first)
                    distance = Math.Abs(first - point);
                else
                    distance = Math.Abs(point - second);
            }
            Console.WriteLine(check);
            Console.WriteLine(distance);
        }
    }
}
