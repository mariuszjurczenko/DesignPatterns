 namespace FactoryMethod
{
    internal class WatchCreator : Creator
    {
        public override IProduct CreateProduct()
        {
            return new Watch();
        }
    }
}
