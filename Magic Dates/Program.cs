using System;

namespace Magic_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var startYear = int.Parse(Console.ReadLine());
            var stopYear = int.Parse(Console.ReadLine());
            var weight = int.Parse(Console.ReadLine());
            bool result = false;

            if (weight == 1)
            {
                Console.WriteLine("No");

            }
            else
            {
                if (startYear < 1900)
                {
                    startYear = 1900;
                }
                if (stopYear > 2100)
                {
                    stopYear = 2100;
                }
                for (int year = startYear; year <= stopYear; year++)
                {
                    var leapDay = 0;

                    if (year % 4 == 0)
                    {
                        leapDay++;

                        if (year % 100 == 0)
                        {
                            leapDay--;

                            if (year % 400 == 0)
                            {
                                leapDay++;
                            }
                        }

                    }

                    for (int month = 1; month <= 12; month++)
                    {
                        var daysInMonth = 31;
                        if (month == 4 || month == 6 || month == 9 || month == 11)
                        {
                            daysInMonth = 30;
                        }
                        else if (month == 2)
                        {
                            daysInMonth = 28 + leapDay;
                        }
                        for (int day = 1; day <= daysInMonth; day++)
                        {
                            var numToBeCalc = Convert.ToInt32(string.Format("{0}{1:D2}{2}", day, month, year));
                            var numLength = (int)Math.Floor(Math.Log10(numToBeCalc)) + 1;
                            int[] numElements = new int[8];
                            for (int i = numLength; i >= 1; i--)
                            {
                                var num = (numToBeCalc / (int)Math.Pow(10, i - 1)) % 10;
                                numElements[numLength - i] = num;
                            }

                            var calcNumWeight = 0;
                            for (int multiplier = 0; multiplier < numLength; multiplier++)
                            {
                                if (numElements[multiplier] == 0)
                                {
                                    continue;
                                }
                                for (int otherNums = multiplier + 1; otherNums < numLength; otherNums++)
                                {
                                    if (numElements[otherNums] == 0)
                                    {
                                        continue;
                                    }
                                    calcNumWeight += numElements[multiplier] * numElements[otherNums];
                                }
                            }

                            if (calcNumWeight == weight)
                            {
                                Console.WriteLine("{0:D2}-{1:D2}-{2}", day, month, year);
                                result = true;
                            }
                        }
                    }
                }
                if (result == false)
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
