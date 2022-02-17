using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var average = 0M;
            var grade2 = 0.00M;
            var grade3 = 0.00M;
            var grade4 = 0.00M;
            var grade5 = 0.00M;

            for (int i = 0; i < n; i++)
            {
                var grade = Decimal.Parse(Console.ReadLine());
                average += grade;
                if (grade >= 2.00M && grade <= 2.99M)
                {
                    grade2++;
                }
                if (grade >= 3.00M && grade <= 3.99M)
                {
                    grade3++;
                }
                if (grade >= 4.00M && grade <= 4.99M)
                {
                    grade4++;
                }
                if (grade >= 5.00M && grade <= 6.00M)
                {
                    grade5++;
                }
            }
            var prGrade2 = (grade2 / n) * 100;
            var prGrade3 = (grade3 / n) * 100;
            var prGrade4 = (grade4 / n) * 100;
            var prGrade5 = (grade5 / n) * 100;
            Console.WriteLine("Top students: {0:f2}%", prGrade5);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", prGrade4);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", prGrade3);
            Console.WriteLine("Fail: {0:f2}%", prGrade2);
            Console.WriteLine("Average: {0:f2}", average / n);
        }
    }
}
