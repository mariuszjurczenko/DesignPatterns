namespace Facade
{
    /// <summary>
    /// The Subsystem 3
    /// </summary>
    public class LoanService
    {
        public bool HasLoans(Customer customer)
        {
            Console.WriteLine("Sprawdz pożyczki dla " + customer.Name);

            return true;
        }
    }
}
