namespace Facade
{
    /// <summary>
    /// The Facade class
    /// Kredyt hipoteczny
    /// </summary>
    public class MortgageFacade
    {
        BankService bankService = new BankService();
        LoanService loanService = new LoanService();
        CreditService creditService = new CreditService();

        // Czy kwalifikuje się
        public bool IsEligible(Customer customer)
        {
            Console.WriteLine("{0} ubiega się o {1:C} pożyczki\n", customer.Name, customer.Amount);
            bool eligible = true;

            // Sprawdź zdolność kredytową wnioskodawcy
            if (!bankService.HasSufficientSavings(customer))
            {
                eligible = false;
            }
            else if (!creditService.HasCredit(customer))
            {
                eligible = false;
            }
            else if (!loanService.HasLoans(customer))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
