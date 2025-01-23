namespace Strategy;

// Konkretna strategia dla płatności kartą kredytową
public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Płacenie {amount} zł kartą kredytową.");
    }
}
