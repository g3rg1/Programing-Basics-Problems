using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var chris = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var tulip = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string holiday = Console.ReadLine().ToLower();
            var priceChris = 0.0M;
            var priceRoses = 0.0M;
            var priceTulip = 0.0M;
            if (season == "spring" || season == "summer")
            {
                priceChris = 2.00M;
                priceRoses = 4.10M;
                priceTulip = 2.50M;
            }
            else
            {
                priceChris = 3.75M;
                priceRoses = 4.50M;
                priceTulip = 4.15M;
            }
            var flowerPrice = chris * priceChris + roses * priceRoses + tulip * priceTulip;
            var flowerDiscount = 0;
            if (holiday == "y")
            {
                flowerPrice += (flowerPrice / 100) * 15;
            }

            if (season == "spring" && tulip > 7)
            {
                flowerDiscount += 5;
            }
            if (season == "winter" && roses >= 10)
            {
                flowerDiscount += 10;
            }

            flowerPrice = flowerPrice - (flowerPrice / 100) * flowerDiscount;

            if ((chris + roses + tulip) > 20)
            {

                flowerPrice = flowerPrice - (flowerPrice / 100) * 20;
            }
            var final = (flowerPrice) + 2;
            Console.WriteLine("{0:f2}", final);
        }
    }
}
