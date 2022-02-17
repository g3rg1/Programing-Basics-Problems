using System;

namespace Bulls_And_Cows
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNum = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());

            int secretNum1 = secretNum / 1000;
            int secretNum2 = (secretNum / 100) % 10;
            int secretNum3 = (secretNum / 10) % 10;
            int secretNum4 = secretNum % 10;
            bool result = false;
            bool twoByTwo = false;
            bool threeByOne = false;
            bool oneByOne = false;

            if ((secretNum1 == secretNum2 && secretNum2 == secretNum3) ||
                    (secretNum2 == secretNum3 && secretNum3 == secretNum4) ||
                    (secretNum1 == secretNum3 && secretNum3 == secretNum4) ||
                    (secretNum1 == secretNum2 && secretNum2 == secretNum4))
            {
                threeByOne = true;
            }
            else if ((secretNum1 == secretNum4 && secretNum2 == secretNum3) ||
                 (secretNum1 == secretNum2 && secretNum3 == secretNum4) ||
                 (secretNum1 == secretNum3 && secretNum2 == secretNum4))
            {
                twoByTwo = true;
            }
            else if (secretNum1 == secretNum2 || secretNum1 == secretNum3 || secretNum1 == secretNum4 ||
                     secretNum2 == secretNum3 || secretNum3 == secretNum4)
            {
                oneByOne = true;
            }

            for (int guessNum1 = 1; guessNum1 <= 9; guessNum1++)
            {
                for (int guessNum2 = 1; guessNum2 <= 9; guessNum2++)
                {
                    for (int guessNum3 = 1; guessNum3 <= 9; guessNum3++)
                    {
                        for (int guessNum4 = 1; guessNum4 <= 9; guessNum4++)
                        {
                            int bullGuess1 = 0;
                            int bullGuess2 = 0;
                            int bullGuess3 = 0;
                            int bullGuess4 = 0;

                            int cowGuess1 = 0;
                            int secretNum1Cowd = 0;
                            int cowGuess2 = 0;
                            int secretNum2Cowd = 0;
                            int cowGuess3 = 0;
                            int secretNum3Cowd = 0;
                            int cowGuess4 = 0;
                            int secretNum4Cowd = 0;

                            if (guessNum1 == secretNum1)
                            {
                                bullGuess1++;
                            }

                            if (guessNum1 != secretNum1 && ((guessNum1 == secretNum2 && secretNum2 != guessNum2) ||
                                (guessNum1 == secretNum3 && secretNum3 != guessNum3) || (guessNum1 == secretNum4 && secretNum4 != guessNum4)))
                            {
                                cowGuess1++;
                                if (guessNum1 == secretNum2)
                                {
                                    secretNum1Cowd = secretNum2;
                                }
                                else if (guessNum1 == secretNum3)
                                {
                                    secretNum1Cowd = secretNum3;
                                }
                                else
                                {
                                    secretNum1Cowd = secretNum4;
                                }
                            }

                            if (guessNum2 == secretNum2)
                            {
                                bullGuess2++;
                            }

                            if (guessNum2 != secretNum2 &&
                                ((guessNum2 == secretNum1 && secretNum1 != guessNum1) ||
                                (guessNum2 == secretNum3 && secretNum3 != guessNum3) ||
                                (guessNum2 == secretNum4 && secretNum4 != guessNum4)))
                            {

                                if (guessNum2 == secretNum3)
                                {
                                    secretNum2Cowd = secretNum3;
                                }
                                else if (guessNum2 == secretNum4)
                                {
                                    secretNum2Cowd = secretNum4;
                                }
                                else
                                {
                                    secretNum2Cowd = secretNum1;
                                }

                                cowGuess1++;

                                if ((threeByOne != true || twoByTwo != true || oneByOne != true) && secretNum1Cowd == secretNum2Cowd)
                                {
                                    cowGuess1--;
                                }

                            }

                            if (guessNum3 == secretNum3)
                            {
                                bullGuess3++;
                            }

                            if (guessNum3 != secretNum3 &&
                              ((guessNum3 == secretNum1 && secretNum1 != guessNum1) ||
                                (guessNum3 == secretNum2 && secretNum2 != guessNum2) ||
                                (guessNum3 == secretNum4 && secretNum4 != guessNum4)))
                            {
                                cowGuess3++;

                                if (guessNum3 == secretNum4)
                                {
                                    secretNum3Cowd = secretNum4;
                                }
                                else if (guessNum3 == secretNum1)
                                {
                                    secretNum3Cowd = secretNum1;
                                }
                                else
                                {
                                    secretNum3Cowd = secretNum2;
                                }

                                if ((threeByOne != true || twoByTwo != true || oneByOne != true) && (secretNum1Cowd == secretNum3Cowd || secretNum2Cowd == secretNum3Cowd))
                                {
                                    cowGuess1--;
                                }
                            }

                            if (guessNum4 == secretNum4)
                            {
                                bullGuess4++;
                            }

                            if (guessNum4 != secretNum4 &&
                                ((guessNum4 == secretNum1 && secretNum1 != guessNum1) ||
                                (guessNum4 == secretNum2 && secretNum2 != guessNum2) ||
                                (guessNum4 == secretNum3 && secretNum3 != guessNum3)))
                            {
                                cowGuess4++;

                                if (guessNum4 == secretNum1)
                                {
                                    secretNum4Cowd = secretNum1;
                                }
                                else if (guessNum4 == secretNum2)
                                {
                                    secretNum4Cowd = secretNum2;
                                }
                                else
                                {
                                    secretNum4Cowd = secretNum3;
                                }

                                if ((threeByOne != true || twoByTwo != true || oneByOne != true) &&
                                    (secretNum1Cowd == secretNum4Cowd || secretNum2Cowd == secretNum4Cowd || secretNum3Cowd == secretNum4Cowd))
                                {
                                    cowGuess1--;
                                }
                            }

                            int bullGuessSum = bullGuess1 + bullGuess2 + bullGuess3 + bullGuess4;
                            int cowGuessSum = cowGuess1 + cowGuess2 + cowGuess3 + cowGuess4;

                            if (cowGuessSum == cows && bullGuessSum == bulls)
                            {
                                Console.Write(" {0}{1}{2}{3}", guessNum1, guessNum2, guessNum3, guessNum4);
                                result = true;
                            }
                        }
                    }
                }
            }

            if (result != true)
            {
                Console.WriteLine("No");
            }
        }
    }
}
