namespace Strategy;

// Klasa kontekstowa, która używa strategii
public class PaymentContext
{
    private IPaymentStrategy _paymentStrategy;

    // Możliwość ustawienia strategii w dowolnym momencie
    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    // Metoda do realizacji płatności
    public void MakePayment(decimal amount)
    {
        if (_paymentStrategy == null)
        {
            Console.WriteLine("Nie ustawiono strategii płatności.");
            return;
        }
        _paymentStrategy.Pay(amount);
    }
}
