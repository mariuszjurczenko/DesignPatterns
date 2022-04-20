namespace AbstractFactory
{
    class SkodaSedan : IAbstractSedan
    {
        public string FunctionWithSedan()
        {
            return "Metoda zwraca SkodaSedan";
        }

        public string AnotherFunctionWithSedan(IAbstractCombi collaborator)
        {
            var result = collaborator.FunctionWithCombi();

            return $"Wynik współpracy SkodaSedan z ({result})";
        }
    }
}
