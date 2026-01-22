using System;

namespace PaymentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Day 12: Advanced Payment System ===");
            Console.WriteLine("Choose Payment Method:");
            Console.WriteLine("1. Credit Card");
            Console.WriteLine("2. PayPal");
            Console.WriteLine("3. Crypto");
            
            Console.Write("\nOption select karein (1-3): ");
            string choice = Console.ReadLine();

            Console.Write("Amount enter karein: ");
            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.WriteLine("Invalid amount! Program band ho raha hai.");
                return;
            }

            IPaymentProcessor processor = null;

            if (choice == "1")
                processor = new CreditCardProcessor();
            else if (choice == "2")
                processor = new PayPalProcessor();
            else if (choice == "3")
                processor = new CryptoProcessor();
            else
            {
                Console.WriteLine("Galat choice select ki hai!");
                return;
            }

            processor.ProcessPayment(amount);
        }
    }
}