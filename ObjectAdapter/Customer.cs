namespace ObjectAdapter
{
    public class Customer
    {
        public string FullName { get; private set; }
        public string Address { get; private set; }
        public string Contact { get; set; }

        public Customer(string fullName, string address, string contact)
        {
            FullName = fullName;
            Address = address;
            Contact = contact;
        }
    }
}
