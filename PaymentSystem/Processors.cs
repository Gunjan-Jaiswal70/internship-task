using System;

namespace PaymentSystem
{
    public abstract class BasePayment
    {
        public void PrintReceipt(double amount, string method)
        {
            Console.WriteLine("\n--- PAYMENT RECEIPT ---");
            Console.WriteLine($"Method: {method}");
            Console.WriteLine($"Amount: ₹{amount}");
            Console.WriteLine($"Status: Successful");
            Console.WriteLine($"Date: {DateTime.Now}");
            Console.WriteLine("-----------------------\n");
        }
    }

    public class CreditCardProcessor : BasePayment, IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Credit Card: Bank gateway se connect ho raha hai...");
            PrintReceipt(amount, "Credit Card");
        }
    }

    public class PayPalProcessor : BasePayment, IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("PayPal: User wallet check ho raha hai...");
            PrintReceipt(amount, "PayPal");
        }
    }

    public class CryptoProcessor : BasePayment, IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Crypto: Blockchain par transaction verify ho rahi hai...");
            PrintReceipt(amount, "Cryptocurrency (BTC)");
        }
    }
}