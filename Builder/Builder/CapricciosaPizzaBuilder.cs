namespace Builder
{
    /// <summary>
    /// ConcreteBuilder
    /// </summary>
    public class CapricciosaPizzaBuilder : PizzaBuilder
    {
        public CapricciosaPizzaBuilder() : base("Pizza Capricciosa")
        {
        }

        public override void PrepareCake()
        {
            Pizza.PrepareCake(CakeType.Cienkie);
        }

        public override void AddMeatAndCheese()
        {
            Pizza.ApplyCheese(CheeseType.Mozzarella);
            Pizza.ApplyMeat(MeatType.Salami);
        }

        public override void AddVegetables()
        {
            Pizza.AddVegetables("Pieczarki");
            Pizza.AddVegetables("Oregano");
            Pizza.AddVegetables("Papryka");
        }

        public override void AddCondiments()
        {
            Pizza.AddCondiments("Musztarda");
            Pizza.AddCondiments("Majonez");
        }
    }
}
