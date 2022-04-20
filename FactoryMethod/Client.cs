namespace FactoryMethod
{
    internal class Client
    {
        public void Main()
        {
            Console.WriteLine("Aplikacja: uruchomiona z TVCreator.");
            ClientCode(new TVCreator());
            Console.WriteLine("");

            Console.WriteLine("Aplikacja: uruchomiona z ComputerCreator.");
            ClientCode(new ComputerCreator());
            Console.WriteLine("");

            Console.WriteLine("Aplikacja: uruchomiona z WatchCreator.");
            ClientCode(new WatchCreator());
            Console.WriteLine("");
        }

        private void ClientCode(Creator creator)
        {
            //...
            Console.WriteLine("Kod Klienta: Nie znam klasy twórcy i nadal pracuje.");
            Console.WriteLine(creator.ToString());
            Console.WriteLine(creator.SomeOperation());
        }
    }
}
