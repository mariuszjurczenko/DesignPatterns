namespace Strategy;

// Definicja wspólnego interfejsu dla strategii
public interface IPaymentStrategy
{
    void Pay(decimal amount);
}
