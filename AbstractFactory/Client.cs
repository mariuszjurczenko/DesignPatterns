namespace AbstractFactory
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Klient: Testowanie kodu klienta z pierwszym typem fabryki:");
            ClientMethod(new AudiFactory());
            Console.WriteLine();

            Console.WriteLine("Klient: Testowanie tego samego kodu klienta z drugim typem fabryki:");
            ClientMethod(new SkodaFactory());
            Console.WriteLine();
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            IAbstractCabriolet cabriolet = factory.CreateCabriolet();
            IAbstractCombi combi = factory.CreateCombi();
            IAbstractHatchback hatchback = factory.CreateHatchback();
            IAbstractSedan sedan = factory.CreateSedan();

            Console.WriteLine(cabriolet.FunctionWithCabriolet());
            Console.WriteLine(combi.FunctionWithCombi());
            Console.WriteLine(hatchback.FunctionWithHatchback());

            Console.WriteLine(sedan.FunctionWithSedan());
            Console.WriteLine(sedan.AnotherFunctionWithSedan(combi));
        }
    }
}
