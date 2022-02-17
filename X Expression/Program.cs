using System;

namespace X_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            decimal resultValue = 0M;
            decimal currentValue = 0M;
            if (expression[0] == '(')
            {
                expression = expression.Remove(0, 1);
            }
            resultValue = (decimal)char.GetNumericValue(expression[0]);
            expression = expression.Remove(0, 1);

            while (true)
            {
                if (expression[0] == ')')
                {
                    expression = expression.Remove(0, 1);
                }
                char currentOperator = expression[0];
                expression = expression.Remove(0, 1);

                if (currentOperator == '=')
                {
                    break;
                }
                if (expression[0] == '(')
                {
                    expression = expression.Remove(0, 1);

                    decimal resultValueBracket = 0M;
                    decimal currentValueBracket = 0M;
                    resultValueBracket = (decimal)char.GetNumericValue(expression[0]);
                    expression = expression.Remove(0, 1);

                    while (true)
                    {
                        if (expression[0] == ')')
                        {
                            currentValue = resultValueBracket;
                            expression = expression.Remove(0, 1);
                            break;
                        }

                        char currentOperatorBracket = expression[0];
                        expression = expression.Remove(0, 1);

                        currentValueBracket = (decimal)char.GetNumericValue(expression[0]);
                        expression = expression.Remove(0, 1);

                        if (currentOperatorBracket == '-')
                        {
                            resultValueBracket -= currentValueBracket;
                        }
                        else if (currentOperatorBracket == '+')
                        {
                            resultValueBracket += currentValueBracket;
                        }
                        else if (currentOperatorBracket == '*')
                        {
                            resultValueBracket *= currentValueBracket;
                        }
                        else
                        {
                            resultValueBracket /= currentValueBracket;
                        }
                        if (expression[0] == ')')
                        {
                            currentValue = resultValueBracket;
                            expression = expression.Remove(0, 1);
                            break;
                        }
                    }

                }
                else
                {
                    currentValue = (decimal)char.GetNumericValue(expression[0]);
                    expression = expression.Remove(0, 1);
                }

                if (currentOperator == '-')
                {
                    resultValue -= currentValue;
                }
                else if (currentOperator == '+')
                {
                    resultValue += currentValue;
                }
                else if (currentOperator == '*')
                {
                    resultValue *= currentValue;
                }
                else
                {
                    resultValue /= currentValue;
                }
            }
            Console.WriteLine("{0:f2}", resultValue);
        }
    }
}
