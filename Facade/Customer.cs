namespace Facade
{
    /// <summary>
    /// Customer class
    /// </summary>
    public class Customer
    {
        private string name;
        private decimal amount;

        public Customer(string name, decimal amount)
        {
            this.name = name;
            this.amount = amount;
        }

        public string Name
        {
            get { return name; }
        }

        public decimal Amount
        {
            get { return amount; }
        }
    }
}
