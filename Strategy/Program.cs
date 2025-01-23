namespace Strategy;

class Program
{
    static void Main(string[] args)
    {
        PaymentContext paymentContext = new PaymentContext();

        // Ustawienie strategii na płatność gotówką
        paymentContext.SetPaymentStrategy(new CashPayment());
        paymentContext.MakePayment(500m);

        // Zmiana strategii na płatność kartą kredytową
        paymentContext.SetPaymentStrategy(new CreditCardPayment());
        paymentContext.MakePayment(600m);

        // Zmiana strategii na płatność PayPal
        paymentContext.SetPaymentStrategy(new PayPalPayment());
        paymentContext.MakePayment(300m);

    }
}
