using System;

namespace Magic_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            string equation = Console.ReadLine();
            var firstValue = 0M;
            var secondValue = 0M;
            var finalValue = 0M;
            bool checkFrstIteration = false;
            bool exitFromBracket = false;
            char currentNumber;
            char currentOperator;
            if (equation[0] == '(')
            {
                equation.Remove(0, 1);
            }
            while (true)
            {
                if (equation[0] == ')')
                {
                    equation.Remove(0, 1);
                }
                if (equation[0] == '=')
                {
                    break;
                }

                if (finalValue != 0)
                {
                    firstValue = finalValue;
                    checkFrstIteration = true;
                }

                if (checkFrstIteration == false)
                {
                    currentNumber = equation[0];
                    currentOperator = equation[1];
                }
                else
                {
                    currentNumber = equation[1];
                    currentOperator = equation[0];
                }

                if (checkFrstIteration == false)
                {
                    firstValue = (decimal)char.GetNumericValue(currentNumber);
                    currentNumber = equation[2];
                }

                if (currentNumber == '(')
                {
                    if (checkFrstIteration == false)
                    {
                        equation = equation.Remove(0, 1);
                    }

                    var bracketFirstValue = 0M;
                    var bracketSecondValue = 0M;
                    var bracketFinalValue = 0M;
                    bool checkFrstBracketIteration = false;
                    char currentNumberForBracket;
                    char currentOperatorForBracket;
                    while (true)
                    {
                        if (equation[2] == ')')
                        {
                            exitFromBracket = true;
                            checkFrstIteration = true;
                            break;
                        }

                        if (bracketFinalValue != 0)
                        {
                            bracketFirstValue = bracketFinalValue;
                            checkFrstBracketIteration = true;
                        }

                        if (checkFrstBracketIteration == false)
                        {
                            currentNumberForBracket = equation[2];
                            currentOperatorForBracket = equation[3];
                        }
                        else
                        {
                            currentNumberForBracket = equation[3];
                            currentOperatorForBracket = equation[2];
                        }

                        if (checkFrstBracketIteration == false)
                        {
                            bracketFirstValue = (decimal)char.GetNumericValue(currentNumberForBracket);
                            currentNumberForBracket = equation[4];
                        }

                        bracketSecondValue = (decimal)char.GetNumericValue(currentNumberForBracket);

                        if (currentOperatorForBracket == '-')
                        {
                            bracketFinalValue = bracketFirstValue - bracketSecondValue;
                        }
                        else if (currentOperatorForBracket == '+')
                        {
                            bracketFinalValue = bracketFirstValue + bracketSecondValue;
                        }
                        else if (currentOperatorForBracket == '*')
                        {
                            bracketFinalValue = bracketFirstValue * bracketSecondValue;
                        }
                        else
                        {
                            bracketFinalValue = bracketFirstValue / bracketSecondValue;
                        }
                        if (checkFrstBracketIteration == false)
                        {
                            equation = equation.Remove(2, 3);
                        }
                        else
                        {
                            equation = equation.Remove(2, 2);
                        }

                    }
                    secondValue = bracketFinalValue;
                    equation = equation.Remove(0, 3);
                }
                else
                {
                    secondValue = (decimal)char.GetNumericValue(currentNumber);
                }

                if (currentOperator == '-')
                {
                    finalValue = firstValue - secondValue;
                }
                else if (currentOperator == '+')
                {
                    finalValue = firstValue + secondValue;
                }
                else if (currentOperator == '*')
                {
                    finalValue = firstValue * secondValue;
                }
                else
                {
                    finalValue = firstValue / secondValue;
                }

                if (checkFrstIteration == false)
                {
                    equation = equation.Remove(0, 3);
                }
                else if (exitFromBracket == true)
                {
                    exitFromBracket = false;
                    continue;
                }
                else
                {
                    equation = equation.Remove(0, 2);
                }
            }
            Console.WriteLine("{0:f2}", finalValue);
        }
    }
}
