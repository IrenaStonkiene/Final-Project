using Final_Project;

Console.WriteLine("_______________________________________________________________");
Console.WriteLine();
Console.WriteLine("Welcome to Optimal Nutrition");
Console.WriteLine("_______________________________________________________________");
Console.WriteLine();
Console.WriteLine("Please, select a product from the following list by product ID:");
Console.WriteLine();

var dataBase = new Database();
var products = dataBase.GetProducts();
var vitaminsCalculator = new VitaminsCalculator();

var dailyRecommendation = new DailyRecommendation();

PrintProductNames(products);

while (true)
{
    Console.WriteLine("Enter product ID and press enter (or type 'stop' to complete the input):");
    var userInput = Console.ReadLine();
    if (string.Compare(userInput, "stop", true) == 0)
    {
        break;
    }

    if (!int.TryParse(userInput, out var productID))
    {
        Console.WriteLine("Wrong product ID input. Please, try again.");
        continue;
    };

    var product = GetProductByID(products, productID);
    if (product == null)
    {
        Console.WriteLine("Wrong product ID input. Please, try again.");
        continue;
    }

    double productQuantity = 0;
    while (true)
    {
        Console.WriteLine("Please, enter consumed quantity in grams:");
        userInput = Console.ReadLine();
       
        if (double.TryParse(userInput, out productQuantity) && productQuantity >= 0)
        {
            break;
        }
        
        Console.WriteLine("Invalid quantity entered. Please, try again.");
    }
   
    Console.WriteLine();
    vitaminsCalculator.Add(product, productQuantity);

}
vitaminsCalculator.Deficit(dailyRecommendation);

void PrintProductNames(List<Product> products)
{
    foreach (var product in products)
    {
        Console.WriteLine($"{product.ID} {product.Name}");
    }
    Console.WriteLine();
}

Product GetProductByID (List<Product> products, int productID)
{
    for (int i = 0; i < products.Count; i++)
    {
        if (products[i].ID == productID)
            return products[i];
    }
    return null;
}
