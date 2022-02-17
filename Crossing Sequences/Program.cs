using System;

namespace Crossing_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var d = int.Parse(Console.ReadLine());
            var e = int.Parse(Console.ReadLine());
            var frst = a;
            var scnd = b;
            var thrd = c;
            var triRslt = 0;
            var progStart = d;
            var progIncr = e;
            bool written = false;

            if (a == d || b == d || c == d)
            {
                Console.WriteLine(d);
            }
            else
            {
                for (int i = 0; ; i++)
                {
                    if (progStart > frst)
                    {
                        triRslt = frst + scnd + thrd;
                        frst = scnd;
                        scnd = thrd;
                        thrd = triRslt;
                    }
                    for (int j = 0; ; j++)
                    {
                        if (progStart == triRslt || progStart == frst || progStart == scnd || progStart == thrd)
                        {
                            Console.WriteLine(triRslt);
                            written = true;
                            break;
                        }
                        if (progStart < frst)
                        {
                            progStart = progStart + progIncr;
                            if (progStart >= triRslt)
                            {
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (progStart == triRslt || progStart == frst || progStart == scnd || progStart == thrd)
                    {
                        if (written == true)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(triRslt);
                            break;
                        }
                    }
                }
            }
        }
    }
}
