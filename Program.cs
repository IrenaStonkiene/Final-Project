using Final_Project;

Console.WriteLine("Welcome to Optimal Nutrition");
Console.WriteLine("____________________________");
Console.WriteLine("Please, select product from the list by product ID");

var dataBase = new Database();
var products = dataBase.GetProducts();

foreach (var product in products)
{
    Console.WriteLine($"{product.ID} {product.Name}");
}
Console.WriteLine();

bool runProgram = true;

while (runProgram)
{
    Console.WriteLine("Enter product ID and press enter");
    var userInput = Console.ReadLine();
    runProgram = int.TryParse(userInput, out var productID);
    if (runProgram)
    {
        Console.WriteLine("Enter consumed quantity in grams");
        var productQuantity = Console.ReadLine();
        var isProductQuantityNumber = double.TryParse(productQuantity, out double productQuantity1);
        Console.WriteLine();
    }

}
   
