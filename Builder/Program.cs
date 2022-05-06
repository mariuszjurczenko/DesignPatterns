using Builder;

Console.Title = "Builder";

var pizzaMaker = new PizzaMaker();
var margheritaPizzaBuilder = new MargheritaPizzaBuilder();
var capricciosaPizzaBuilder = new CapricciosaPizzaBuilder();

pizzaMaker.Construct(margheritaPizzaBuilder);
pizzaMaker.Show();

pizzaMaker.Construct(capricciosaPizzaBuilder);
pizzaMaker.Show();

Console.ReadKey();