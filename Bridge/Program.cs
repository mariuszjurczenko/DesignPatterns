using Bridge;
Console.Title = "Bridge";

var tvPriceList = new TVPriceList(new NoDiscount());
Console.WriteLine($"Cena telewizoru, bez rabatu: {tvPriceList.CalculatePrice()} euro.");

tvPriceList = new TVPriceList(new TenEuroDiscount());
Console.WriteLine($"Cena telewizoru, z rabatem 10 euro: {tvPriceList.CalculatePrice()} euro.");

tvPriceList = new TVPriceList(new TwentyEuroDiscount());
Console.WriteLine($"Cena telewizoru, z rabatem 20 euro: {tvPriceList.CalculatePrice()} euro.");

tvPriceList = new TVPriceList(new HundredEuroDiscount());
Console.WriteLine($"Cena telewizoru, z rabatem 100 euro: {tvPriceList.CalculatePrice()} euro.");


var computersPriceList = new ComputersPriceList(new NoDiscount());
Console.WriteLine($"Cena komputera, bez rabatu: {computersPriceList.CalculatePrice()} euro.");

computersPriceList = new ComputersPriceList(new TenEuroDiscount());
Console.WriteLine($"Cena komputera, z rabatem 10 euro: {computersPriceList.CalculatePrice()} euro.");

computersPriceList = new ComputersPriceList(new TwentyEuroDiscount());
Console.WriteLine($"Cena komputera, z rabatem 20 euro: {computersPriceList.CalculatePrice()} euro.");

computersPriceList = new ComputersPriceList(new HundredEuroDiscount());
Console.WriteLine($"Cena komputera, z rabatem 100 euro: {computersPriceList.CalculatePrice()} euro.");


var radioPricelist = new RadioPricelist(new NoDiscount());
Console.WriteLine($"Cena radia, bez rabatu: {radioPricelist.CalculatePrice()} euro.");

radioPricelist = new RadioPricelist(new TenEuroDiscount());
Console.WriteLine($"Cena radia, z rabatem 10 euro: {radioPricelist.CalculatePrice()} euro.");

radioPricelist = new RadioPricelist(new TwentyEuroDiscount());
Console.WriteLine($"Cena radia, z rabatem 20 euro: {radioPricelist.CalculatePrice()} euro.");

radioPricelist = new RadioPricelist(new HundredEuroDiscount());
Console.WriteLine($"Cena radia, z rabatem 100 euro: {radioPricelist.CalculatePrice()} euro.");

Console.ReadKey();