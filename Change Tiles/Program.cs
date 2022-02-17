using System;

namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var savedMoney = Double.Parse(Console.ReadLine());
            var floorWidth = Double.Parse(Console.ReadLine());
            var floorLenght = Double.Parse(Console.ReadLine());
            var tileSide = Double.Parse(Console.ReadLine());
            var tileHight = Double.Parse(Console.ReadLine());
            var tileCost = Double.Parse(Console.ReadLine());
            var workPrice = Double.Parse(Console.ReadLine());

            var floorTiles = Math.Ceiling(floorWidth * floorLenght / (tileSide * tileHight / 2)) + 5;
            var neededMoney = savedMoney - (floorTiles * tileCost + workPrice);

            if (neededMoney >= 0)
            {
                Console.WriteLine("{0:f2} lv left.", neededMoney);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", Math.Abs(neededMoney));
            }
        }
    }
}
