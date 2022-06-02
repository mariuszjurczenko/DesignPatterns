using Bridge;
Console.Title = "Bridge";

var computersPriceList = new ComputersPriceList(new NoDiscount());
Console.WriteLine($"Cena komputera, bez rabatu: {computersPriceList.CalculatePrice()} euro.");

computersPriceList = new ComputersPriceList(new TenEuroDiscount());
Console.WriteLine($"Cena komputera, z rabatem 10 euro: {computersPriceList.CalculatePrice()} euro.");

var tvPriceList = new TVPriceList(new NoDiscount());
Console.WriteLine($"Cena telewizoru, bez rabatu: {tvPriceList.CalculatePrice()} euro.");

tvPriceList = new TVPriceList(new TenEuroDiscount());
Console.WriteLine($"Cena telewizoru, z rabatem 10 euro: {tvPriceList.CalculatePrice()} euro.");

Console.ReadKey();