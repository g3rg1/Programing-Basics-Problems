using System;

namespace Number_To_Words
{
    class Program
    {
        static string SpellDecimalDigit(string value)
        {
            string decimalDigit = "";
            if (value == "10")
            {
                return "ten";
            }
            if (value == "11")
            {
                return "eleven";
            }
            if (value == "12")
            {
                return "twelve";
            }
            if (value == "13")
            {
                return "thirteen";
            }
            if (value == "14")
            {
                return "fourteen";
            }
            if (value == "15")
            {
                return "fifteen";
            }
            if (value == "16")
            {
                return "sixteen";
            }
            if (value == "17")
            {
                return "seventeen";
            }
            if (value == "18")
            {
                return "eighteen";
            }
            if (value == "19")
            {
                return "nineteen";
            }

            if (value[0] == '2')
            {
                decimalDigit = "twenty";
            }
            else if (value[0] == '3')
            {
                decimalDigit = "thirty";
            }
            else if (value[0] == '4')
            {
                decimalDigit = "forty";
            }
            else if (value[0] == '5')
            {
                decimalDigit = "fifty";
            }
            else if (value[0] == '6')
            {
                decimalDigit = "sixty";
            }
            else if (value[0] == '7')
            {
                decimalDigit = "seventy";
            }
            else if (value[0] == '8')
            {
                decimalDigit = "eighty";
            }
            else if (value[0] == '9')
            {
                decimalDigit = "ninety";
            }
            else
            {
                return decimalDigit;
            }

            if (value[1] != '0')
            {
                value = value.Remove(0, 1);
                return decimalDigit += " " + SpellSingleDigit(value);
            }
            return decimalDigit;
        }
        static string SpellSingleDigit(string value)
        {
            string singleDigit = "";
            if (value == "1")
            {
                singleDigit = "one";
            }
            else if (value == "2")
            {
                singleDigit = "two";
            }
            else if (value == "3")
            {
                singleDigit = "three";
            }
            else if (value == "4")
            {
                singleDigit = "four";
            }
            else if (value == "5")
            {
                singleDigit = "five";
            }
            else if (value == "6")
            {
                singleDigit = "six";
            }
            else if (value == "7")
            {
                singleDigit = "seven";
            }
            else if (value == "8")
            {
                singleDigit = "eight";
            }
            else if (value == "9")
            {
                singleDigit = "nine";
            }
            else if (value == "0")
            {
                singleDigit = "zero";
            }

            return singleDigit;
        }
        static string SpellWholeNumber(string currentNumberString)
        {

            int numToCheckInt = Convert.ToInt32(currentNumberString);
            string spelledNumber = "";



            if (numToCheckInt > 999)
            {
                return spelledNumber = "too large";
            }
            else if (numToCheckInt < -999)
            {
                return spelledNumber = "too small";
            }
            else if ((currentNumberString[0] == '0' || currentNumberString[0] == '-') && currentNumberString.Length > 4)
            {
                return spelledNumber;
            }
            else if (currentNumberString == "-0" || currentNumberString == "-00" || currentNumberString == "-000")
            {
                return spelledNumber = "zero";
            }


            if (currentNumberString[0] == '-')
            {
                spelledNumber += "minus ";
                currentNumberString = currentNumberString.Remove(0, 1);

            }
            else if (currentNumberString.Length < 3)
            {
                return spelledNumber = "";
            }

            for (int i = 0; i < currentNumberString.Length; i++)
            {
                if (currentNumberString[0] == '0')
                    currentNumberString = currentNumberString.Remove(0, 1);
            }

            if (currentNumberString.Length == 1)
            {
                return spelledNumber += SpellSingleDigit(currentNumberString);
            }
            else if (currentNumberString.Length == 2)
            {
                return spelledNumber += SpellDecimalDigit(currentNumberString);
            }
            else
            {
                spelledNumber += SpellSingleDigit(currentNumberString.Remove(1, 2)) + "-" + "hundred";
                if (currentNumberString[1] == '0' && currentNumberString[2] == '0')
                {
                    return spelledNumber;
                }
                else if (currentNumberString[1] != '0')
                {
                    return spelledNumber += " and " + SpellDecimalDigit(currentNumberString.Remove(0, 1));
                }
                else
                {
                    return spelledNumber += " and " + SpellSingleDigit(currentNumberString.Remove(0, 2));
                }
            }
        }

        static void Main(string[] args)
        {
            var numberCount = int.Parse(Console.ReadLine());
            string[] numbersArray = new string[numberCount];

            for (int i = 0; i < numberCount; i++)
            {
                numbersArray[i] = Console.ReadLine();
            }

            for (int i = 0; i < numberCount; i++)
            {
                Console.WriteLine(SpellWholeNumber(numbersArray[i]));
            }
        }
    }
}
