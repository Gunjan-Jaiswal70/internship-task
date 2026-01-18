using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ye loop calculator ko tab tak chalayega jab tak aap band na karein
            while (true) 
            {
                try 
                {
                    Console.WriteLine("\n--- My Final Advanced Calculator ---");
                    
                    Console.Write("Pehla number likhein: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Operator chunein (+, -, *, /, pow, sqrt): ");
                    string op = Console.ReadLine().ToLower();

                    if (op == "sqrt")
                    {
                        // Error handling for negative square root
                        if (num1 < 0) throw new Exception("Negative number ka square root nahi nikala ja sakta.");
                        Console.WriteLine($"Result: {Math.Sqrt(num1)}");
                    }
                    else
                    {
                        Console.Write("Dusra number likhein: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        switch (op)
                        {
                            case "+": Console.WriteLine($"Result: {num1 + num2}"); break;
                            case "-": Console.WriteLine($"Result: {num1 - num2}"); break;
                            case "*": Console.WriteLine($"Result: {num1 * num2}"); break;
                            case "/": 
                                // Error handling for division by zero
                                if (num2 == 0) throw new DivideByZeroException("Zero se divide nahi kar sakte!");
                                Console.WriteLine($"Result: {num1 / num2}"); 
                                break;
                            case "pow": 
                                Console.WriteLine($"Result: {Math.Pow(num1, num2)}"); 
                                break;
                            default: 
                                Console.WriteLine("Galat Operator! Sirf +, -, *, /, pow, ya sqrt likhein."); 
                                break;
                        }
                    }
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Error: Sirf numbers (0-9) likhein!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                // Loop control: Program ko chalu rakhne ya band karne ke liye
                Console.WriteLine("\nKya aap aur calculation karna chahte hain? (y/n): ");
                string choice = Console.ReadLine().ToLower();
                if (choice != "y") 
                {
                    break; 
                }
            }
            
            Console.WriteLine("Calculator band ho raha hai. Goodbye!");
        }
    }
}