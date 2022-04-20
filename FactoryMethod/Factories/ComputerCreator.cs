namespace FactoryMethod
{
    internal class ComputerCreator : Creator
    {
        public override IProduct CreateProduct()
        {
            return new Computer();
        }
    }
}
