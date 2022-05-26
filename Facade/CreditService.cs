namespace Facade
{
    /// <summary>
    /// The Subsystem 2
    /// </summary>
    public class CreditService
    {
        public bool HasCredit(Customer customer)
        {
            Console.WriteLine("Sprawdz kredyt dla " + customer.Name);

            return true;
        }
    }
}
