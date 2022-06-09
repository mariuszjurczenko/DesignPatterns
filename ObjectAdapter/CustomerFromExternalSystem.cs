namespace ObjectAdapter
{
    public class CustomerFromExternalSystem
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public CustomerFromExternalSystem(string name, string surname, string city, string street, string number, string email, string phone)
        {
            Name = name;
            Surname = surname;
            City = city;
            Street = street;
            Number = number;
            Email = email;
            Phone = phone;
        }
    }
}
