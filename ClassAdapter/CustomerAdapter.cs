namespace ClassAdapter
{
    /// <summary>
    /// Adapter
    /// </summary>
    public class CustomerAdapter : ExternalSystem, ICustomerAdapter
    {
        public Customer GetCustomer()
        {
            // wywołaniemetody z systemu zewnętrznego
            var customerFromExternalSystem = base.GetCustomer();

            // dostosowanie CustomerFromExternalSystem do Customer
            return new Customer($"{customerFromExternalSystem.Name} - {customerFromExternalSystem.Surname}",
                      $"{customerFromExternalSystem.City}, {customerFromExternalSystem.Street} {customerFromExternalSystem.Number}",
                      $"{customerFromExternalSystem.Email} - {customerFromExternalSystem.Phone}");
        }
    }
}
