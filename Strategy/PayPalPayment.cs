namespace Strategy;

// Konkretna strategia dla płatności PayPal
public class PayPalPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Płacenie {amount} zł przez PayPal.");
    }
}
