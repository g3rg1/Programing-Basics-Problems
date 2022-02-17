using System;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = Double.Parse(Console.ReadLine());
            var frstTime = Double.Parse(Console.ReadLine());
            var scndTime = Double.Parse(Console.ReadLine());
            var thrdTime = Double.Parse(Console.ReadLine());
            frstTime /= 60;
            scndTime /= 60;
            thrdTime /= 60;
            var secondSpeed = km + ((km / 100) * 10);
            var firstDis = km * frstTime;
            var secondDis = secondSpeed * scndTime;
            var thirdDis = (secondSpeed - ((secondSpeed / 100) * 5)) * thrdTime;


            var totalDistance = firstDis + secondDis + thirdDis;
            Console.WriteLine("{0:f2}", totalDistance);
        }
    }
}
