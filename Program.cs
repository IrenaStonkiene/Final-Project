using Final_Project;

Console.WriteLine("Welcome to Optimal Nutrition");
Console.WriteLine("____________________________");
Console.WriteLine("Please, select product from the list by product ID");

var dataBase = new Database();
var products = dataBase.GetProducts();
var total = new VitaminsCalculator();

var dailyRecommendation = new DailyRecommendation();

bool runProgram = true;

while (runProgram)
{
    PrintProductNames(products); 
    Console.WriteLine("Enter product ID and press enter");
    var userInput = Console.ReadLine();
    runProgram = int.TryParse(userInput, out var productID);
    if (runProgram)
    {
        var product = GetProductByID(products, productID);
        if (product == null)
            continue;

        Console.WriteLine("Enter consumed quantity in grams");
        var productQuantity = Console.ReadLine();
        var isProductQuantityNumber = double.TryParse(productQuantity, out double productQuantity1);
        Console.WriteLine();
        total.Add(product, productQuantity1);
    }

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
    Console.WriteLine($"No such product with ID {productID}");
    return null;
}
