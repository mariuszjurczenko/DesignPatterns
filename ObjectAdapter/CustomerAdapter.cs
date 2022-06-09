namespace ObjectAdapter
{
    /// <summary>
    /// Adapter
    /// </summary>
    public class CustomerAdapter : ICustomerAdapter
    {
        public ExternalSystem ExternalSystem { get; private set; } = new();

        public Customer GetCustomer()
        {
            // wywołaniemetody z systemu zewnętrznego
            var customerFromExternalSystem = ExternalSystem.GetCustomer();

            // dostosowanie CustomerFromExternalSystem do Customer
            return new Customer($"{customerFromExternalSystem.Name} - {customerFromExternalSystem.Surname}",
                      $"{customerFromExternalSystem.City}, {customerFromExternalSystem.Street} {customerFromExternalSystem.Number}",
                      $"{customerFromExternalSystem.Email} - {customerFromExternalSystem.Phone}");
        }
    }
}
