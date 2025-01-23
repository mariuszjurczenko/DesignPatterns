namespace Strategy;

// Konkretna strategia dla płatności gotówką
public class CashPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Płacenie {amount} zł gotówką.");
    }
}
