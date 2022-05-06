namespace Builder
{
    /// <summary>
    /// Director
    /// </summary>
    public class PizzaMaker
    {
        private PizzaBuilder? _builder;

        public PizzaMaker()
        {
        }

        public void Construct(PizzaBuilder builder)
        {
            _builder = builder;
            _builder.PrepareCake();
            _builder.AddMeatAndCheese();
            _builder.AddCondiments();
            _builder.AddVegetables();
        }

        public void Show()
        {
            Console.WriteLine(_builder?.Pizza.ToString());
        }
    }
}
