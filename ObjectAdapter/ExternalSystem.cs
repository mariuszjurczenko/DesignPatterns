namespace ObjectAdapter
{
    /// <summary>
    /// Adaptee (adaptowany)
    /// </summary>
    public class ExternalSystem
    {
        public CustomerFromExternalSystem GetCustomer()
        {
            return new CustomerFromExternalSystem("Marcin", "Nowak", "Katowice", "Warszawska", "45/24", "marcin@dev-hobby.pl", "345657233");
        }
    }
}
