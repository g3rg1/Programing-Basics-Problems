using System;

namespace String_Encryption
{
    class Program
    {
        static string Encrypt(char letter)
        {
            string currentEncryption = "";
            int asciiValue = letter;
            string firstElement = "";
            string lastElement = "";
            int divider = 100;
            if (asciiValue < 100)
            {
                divider = 10;
            }

            firstElement = Convert.ToString((char)(asciiValue + (asciiValue % 10)));
            string middleElement = asciiValue / divider % 10 + "" + asciiValue % 10;
            lastElement = Convert.ToString((char)(asciiValue - (asciiValue / divider % 10)));

            return currentEncryption =
                Convert.ToString(firstElement + middleElement + lastElement);
        }
        static void Main(string[] args)
        {
            var charCount = int.Parse(Console.ReadLine());
            char[] charsArray = new char[charCount];
            string result = "";
            for (int i = 0; i < charCount; i++)
            {
                charsArray[i] = Convert.ToChar(Console.ReadLine());
            }

            for (int i = 0; i < charCount; i++)
            {
                result += Encrypt(charsArray[i]);
            }
            Console.WriteLine(result);
        }
    }
}
