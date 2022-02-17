using System;

namespace Passion_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyStarting = Decimal.Parse(Console.ReadLine());
            while (true)
            {
                string start = Console.ReadLine();
                if (start == "mall.Enter")
                {
                    break;
                }
                else
                    continue;
            }
            var boughtCount = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "mall.Exit")
                {
                    break;
                }
                else
                {
                    for (int i = 0; i <= input.Length - 1; i++)
                    {
                        char goods = Convert.ToChar(input[i]);
                        var price = (Decimal)goods;
                        if (goods == '%')
                        {
                            if (moneyStarting > 0)
                            {
                                moneyStarting /= 2;
                                boughtCount++;
                            }
                            continue;
                        }
                        else if (goods == '*')
                        {
                            moneyStarting += 10;
                            continue;
                        }
                        else if (price >= 65 && price <= 90)
                        {
                            if (moneyStarting >= price / 2)
                            {
                                moneyStarting -= price / 2;
                                boughtCount++;
                                continue;
                            }
                        }
                        else if (price >= 97 && price <= 122)
                        {
                            if (moneyStarting >= (price / 100) * 30)
                            {
                                moneyStarting -= (price / 100) * 30;
                                boughtCount++;
                                continue;
                            }
                        }
                        else
                        {
                            if (moneyStarting >= price)
                            {
                                moneyStarting -= price;
                                boughtCount++;
                            }
                        }
                    }
                }
            }
            if (boughtCount == 0)
            {
                Console.WriteLine("No purchases. Money left: {0:f2} lv.", moneyStarting);
            }
            else
            {
                Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", boughtCount, moneyStarting);
            }
        }
    }
}
