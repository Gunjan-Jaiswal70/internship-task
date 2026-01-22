namespace PaymentSystem
{
    public interface IPaymentProcessor
    {
        // Sirf bataya hai ki kya hona chahiye (No body {})
        void ProcessPayment(double amount);
    }
}