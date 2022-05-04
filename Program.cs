// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to Optimal Nutrition");
Console.WriteLine("____________________________");
Console.WriteLine("Please, select product from the list by product ID");

bool runProgram = true;

while (runProgram)
{
    Console.WriteLine("{Productlist}");//Product list will be printed
    Console.WriteLine("Enter product ID or press enter");
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
   
