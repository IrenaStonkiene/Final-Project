using Final_Project;

Console.WriteLine("Welcome to Optimal Nutrition");
Console.WriteLine("____________________________");
Console.WriteLine("Please, select product from the list by product ID");
Console.WriteLine();

var dataBase = new Database();
var products = dataBase.GetProducts();
var total = new VitaminsCalculator();

var dailyRecommendation = new DailyRecommendation();

PrintProductNames(products);

while (true)
{
    Console.WriteLine("Enter product ID and press enter (or type 'stop' to complete input)");
    var userInput = Console.ReadLine();
    if (string.Compare(userInput, "stop", true) == 0)
    {
        break;
    }

    if (!int.TryParse(userInput, out var productID))
    {
        Console.WriteLine("Wrong product id input. Try again.");
        continue;
    };

    var product = GetProductByID(products, productID);
    if (product == null)
    {
        Console.WriteLine("Wrong product id input. Try again.");
        continue;
    }

    bool continueInput = true;
    double productQuantity = 0;
    while (true)
    {
        Console.WriteLine("Enter consumed quantity in grams(or type 'stop' to complete input)");
        userInput = Console.ReadLine();
        if (string.Compare(userInput, "stop", true) == 0)
        {
            continueInput = false;
            break;
        }

        if (!double.TryParse(userInput, out productQuantity) || productQuantity <= 0)
        {
            Console.WriteLine("Invalid quantity entered. try again.");
            continue;
        }

        break;
    }

    if (!continueInput)
    {
        break;
    }
   
    Console.WriteLine();
    total.Add(product, productQuantity);

}
total.Deficite(dailyRecommendation);

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
