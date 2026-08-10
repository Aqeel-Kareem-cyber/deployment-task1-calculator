using System;

namespace CalculatorLibrary
{
    public class CalculatorEngine
    {
        public double Calculate(double num1, double num2, string op)
        {
            switch (op)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    if (num2 == 0)
                        throw new DivideByZeroException("Cannot divide by zero.");
                    return num1 / num2;
                default:
                    throw new InvalidOperationException("Invalid operator.");
            }
        }
    }
}