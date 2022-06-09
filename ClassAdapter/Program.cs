using ClassAdapter;

Console.Title = " Class Adapter";

// Przykład Object Adapter 
ICustomerAdapter adapter = new CustomerAdapter();
var customer = adapter.GetCustomer();

Console.WriteLine($"{customer.FullName} | {customer.Address} | {customer.Contact}");
Console.ReadKey();
