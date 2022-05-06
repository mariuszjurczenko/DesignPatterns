using System.Text;

namespace Builder
{
    /// <summary>
    /// Product
    /// </summary>
    public class Pizza
    {
        private readonly string _name;
        private CakeType _cakeType;
        private CheeseType _cheeseType;
        private MeatType _meatType;
        private List<string> _vegetables = new();
        private List<string> _condiments = new();

        public Pizza(string name)
        {
            _name = name;
        }

        public void PrepareCake(CakeType cakeType) => _cakeType = cakeType;
        public void ApplyCheese(CheeseType cheeseType) => _cheeseType = cheeseType;
        public void ApplyMeat(MeatType meatType) => _meatType = meatType;
        public void AddVegetables(string vegetable) => _vegetables.Add(vegetable);
        public void AddCondiments(string condiment) => _condiments.Add(condiment);

        public override string ToString()
        {
            var stringbuilder = new StringBuilder();
            stringbuilder.Append($"Pizza którą zamówiłeś to {_name}\n");
            stringbuilder.Append($"Ma następujące składniki: \n");
            stringbuilder.Append($"Ciasto: {_cakeType}\n");
            stringbuilder.Append($"Ser: {_cheeseType}\n");
            stringbuilder.Append($"Mieso: {_meatType}\n");

            if (_condiments.Count > 0)
                stringbuilder.Append("Przyprawy:\n");

            foreach (string condiment in _condiments)
                stringbuilder.Append($"\t{condiment}\n");

            stringbuilder.Append($"Warzywa:\n");

            foreach (string vegetable in _vegetables)
                stringbuilder.Append($"\t{vegetable}\n");

            return stringbuilder.ToString();
        }
    }
}
