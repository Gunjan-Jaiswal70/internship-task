using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("--- Advanced Calculator ---");
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter operator (+, -, *, /, sqrt): ");
                string op = Console.ReadLine();

                if (op == "sqrt")
                {
                    if (num1 < 0) throw new Exception("Cannot square root a negative number.");
                    Console.WriteLine($"Result: {Math.Sqrt(num1)}");
                }
                else
                {
                    Console.Write("Enter second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    switch (op)
                    {
                        case "+": Console.WriteLine($"Result: {num1 + num2}"); break;
                        case "-": Console.WriteLine($"Result: {num1 - num2}"); break;
                        case "*": Console.WriteLine($"Result: {num1 * num2}"); break;
                        case "/": 
                            if (num2 == 0) throw new DivideByZeroException();
                            Console.WriteLine($"Result: {num1 / num2}"); 
                            break;
                        default: Console.WriteLine("Invalid Operator!"); break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}