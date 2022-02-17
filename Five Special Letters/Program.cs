using System;
using System.Collections.Generic;

namespace Five_Special_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var from = int.Parse(Console.ReadLine());
            var to = int.Parse(Console.ReadLine());
            var valueForChars = new Dictionary<char, int>() {
                {'a', 5},
                {'b', -12},
                {'c', 47},
                {'d', 7},
                {'e', -32},
                {'x', 0}
            };
            bool result = false;

            for (var frst = 'a'; frst <= 'e'; frst++)
            {
                for (var scnd = 'a'; scnd <= 'e'; scnd++)
                {
                    for (var thrd = 'a'; thrd <= 'e'; thrd++)
                    {
                        for (var frth = 'a'; frth <= 'e'; frth++)
                        {
                            for (var ffth = 'a'; ffth <= 'e'; ffth++)
                            {
                                var two = scnd;
                                var thr = thrd;
                                var fou = frth;
                                var fiv = ffth;
                                if (ffth == frth || ffth == thrd || ffth == scnd || ffth == frst)
                                {
                                    fiv = 'x';
                                }
                                if (frth == thrd || frth == scnd || frth == frst)
                                {
                                    fou = 'x';
                                }
                                if (thrd == scnd || thrd == frst)
                                {
                                    thr = 'x';
                                }
                                if (scnd == frst)
                                {
                                    two = 'x';
                                }

                                int counter = 1;
                                var numWeight = 0;
                                numWeight += valueForChars[frst] * counter;
                                if (two != 'x')
                                {
                                    counter++;
                                    numWeight += valueForChars[two] * counter;
                                }
                                if (thr != 'x')
                                {
                                    counter++;
                                    numWeight += valueForChars[thr] * counter;
                                }
                                if (fou != 'x')
                                {
                                    counter++;
                                    numWeight += valueForChars[fou] * counter;
                                }
                                if (fiv != 'x')
                                {
                                    counter++;
                                    numWeight += valueForChars[fiv] * counter;
                                }
                                if (numWeight >= from && numWeight <= to)
                                {
                                    Console.Write(" {0}{1}{2}{3}{4}", frst, scnd, thrd, frth, ffth);
                                    result = true;
                                }
                            }
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
