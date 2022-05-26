namespace Facade
{
    /// <summary>
    /// The Subsystem 1
    /// </summary>
    public class BankService
    {
        // Czy ma wystarczające oszczędności
        public bool HasSufficientSavings(Customer customer)
        {
            Console.WriteLine("Sprawdz bank dla " + customer.Name);

            var savings = 50000;

            if (savings > customer.Amount / 3)
                return true;
            else
                return false;
        }
    }
}
