namespace FactoryMethod
{
    abstract class Creator
    {
        public abstract IProduct CreateProduct();

        public string SomeOperation()
        {
            var product = CreateProduct();
            var result = "Kod Kreatora: " + product.Operation();
            return result;
        }
    }
}
