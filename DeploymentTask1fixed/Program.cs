using System;
using CalculatorLibrary;

namespace DeploymentTask1fixed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Simple Calculator App ===");
            Console.WriteLine("Deployment Task 1.3 - Custom App with Library Dependency");
            Console.WriteLine();

            CalculatorEngine engine = new CalculatorEngine();
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter an operator (+, -, *, /): ");
                string op = Console.ReadLine();

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                try
                {
                    double result = engine.Calculate(num1, num2, op);
                    Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine();
                Console.Write("Do you want to perform another calculation? (y/n): ");
                string again = Console.ReadLine();
                keepRunning = again.Trim().ToLower() == "y";
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using the calculator!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}