namespace Builder
{
    /// <summary>
    /// ConcreteBuilder
    /// </summary>
    public class MargheritaPizzaBuilder : PizzaBuilder
    {
        public MargheritaPizzaBuilder() : base("Pizza Margherita")
        {
        }

        public override void PrepareCake()
        {
            Pizza.PrepareCake(CakeType.Grube);
        }

        public override void AddMeatAndCheese()
        {
            Pizza.ApplyCheese(CheeseType.Gouda);
            Pizza.ApplyMeat(MeatType.Szynka);
        }

        public override void AddVegetables()
        {
            Pizza.AddVegetables("Pomidory");
            Pizza.AddVegetables("Oregano");
        }

        public override void AddCondiments()
        {
            Pizza.AddCondiments("Sos pomidorowy");
        }
    }
}
