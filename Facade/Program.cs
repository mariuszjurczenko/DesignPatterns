using Facade;
Console.Title = "Facade ";

MortgageFacade mortgage = new MortgageFacade();
Customer customer = new Customer("Adam Nowak", 100000);

bool eligible = mortgage.IsEligible(customer);

Console.WriteLine("\nKredyt dla " + customer.Name + " został " + (eligible ? "Zatwierdzony" : "Odrzucony"));
Console.ReadKey();