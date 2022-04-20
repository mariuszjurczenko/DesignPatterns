namespace FactoryMethod
{
    internal class TVCreator : Creator
    {
        public override IProduct CreateProduct()
        {
            return new TV();
        }
    }
}
