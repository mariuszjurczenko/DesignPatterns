using AbstractFactory2;

Console.Title = "Abstract Factory";

var polandShoppingCartFactory = new PolandShoppingCartFactory();
var shoppingCartForPoland = new ShoppingCart(polandShoppingCartFactory);
shoppingCartForPoland.CalculateCosts();

var englandShoppingCartFactory = new EnglandShoppingCartFactory();
var shoppingCartForEngland = new ShoppingCart(englandShoppingCartFactory);
shoppingCartForEngland.CalculateCosts();

var italyShoppingCartFactory = new ItalyShoppingCartFactory();
var shoppingCartForItaly = new ShoppingCart(italyShoppingCartFactory);
shoppingCartForItaly.CalculateCosts();

Console.ReadKey();
