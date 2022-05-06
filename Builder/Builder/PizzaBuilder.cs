namespace Builder
{
    /// <summary>
    /// Builder  
    /// </summary>
    public abstract class PizzaBuilder
    {
        public Pizza Pizza { get; private set; }

        public PizzaBuilder(string name)
        {
            Pizza = new Pizza(name);
        }

        public abstract void PrepareCake();
        public abstract void AddMeatAndCheese();
        public abstract void AddVegetables();
        public abstract void AddCondiments();
    }
}
