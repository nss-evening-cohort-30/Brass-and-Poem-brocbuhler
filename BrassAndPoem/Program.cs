
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;

List<Product> products = new List<Product>
 {
    new Product
    {
        DiceName = "Lightning 20",
        Price = 5.5,
        ProductTypeId = 3,
        DR = 20
    },
    new Product
    {
        DiceName = "Hammer",
        Price = 1,
        ProductTypeId = 1,
        DR = 12
    },
    new Product
    {
        DiceName = "Lucky Swing",
        Price = 23,
        ProductTypeId = 2,
        DR = 20
    },
    new Product
    {
        DiceName = "Fates Finder",
        Price = 2.3,
        ProductTypeId = 2,
        DR = 10
    },
    new Product
    {
        DiceName = "Toothpick",
        Price = 7,
        ProductTypeId = 3,
        DR = 4
    }
 };

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>
{
    new ProductType
    {
        Id = 1,
        Design = "Brass",
    },
    new ProductType
    {
        Id = 2,
        Design = "Poem",
    },
    new ProductType
    {
        Id = 3,
        Design = "Sparky",
    }
};

//put your greeting here

//implement your loop here

void DisplayMenu()
{
    try
    {
        Console.WriteLine("Please Choose one of the following: \n A. View all Dice \n B. Put a new Die up for sale \n C. Remove a Die \n D. Update a Die's information \n Or enter 'E' to exit");
        char Response = char.ToUpper(char.Parse(Console.ReadLine().Trim()));
        switch (Response)
        {
            case 'A':
                Console.Clear();
                DisplayAllProducts();
                break;
            case 'B':
                Console.Clear();
                AddProduct();
                break;
            case 'C':
                Console.Clear();
                DeleteProduct();
                break;
            case 'D':
                Console.Clear();
                UpdateProduct();
                break;
            case 'E':
                Console.Clear();
                Console.WriteLine("Sorry to see you go!");
                break;
            default:
                Console.Clear();
                Console.WriteLine("Please Enter vaild menu options only");
                DisplayMenu();
                break;
        }
    }
    catch (Exception ex)
    {
        Console.Clear();
        Console.WriteLine(ex);
        Console.WriteLine("Response must be a character of the associated menu options. \n Ex: A, B, C, D, or E");
        ReturnToMenu();
    }
}

void DisplayAllProducts()
{
    Console.WriteLine($"{products}{productTypes}");
    Console.WriteLine("WIP");
}

void DeleteProduct()
{
    Console.WriteLine($"{products}{productTypes}");
    Console.WriteLine("WIP");
}

void AddProduct()
{
    Console.WriteLine($"{products}{productTypes}");
    Console.WriteLine("WIP");
}

void UpdateProduct()
{
    Console.WriteLine($"{products}{productTypes}");
    Console.WriteLine("WIP");
}

void ReturnToMenu()
{
    try
    {
        Console.WriteLine("Would you like to return to the menu? \n ( 'Y' or 'N' )");
        char Response = char.ToUpper(char.Parse(Console.ReadLine().Trim()));
        switch (Response)
        {
            case 'Y':
                Console.Clear();
                DisplayMenu();
                break;
            case 'N':
                Console.Clear();
                Console.WriteLine("Sorry to see you go!");
                break;
            default:
                Console.Clear();
                Console.WriteLine("Response must be a character of either: \n ( 'Y' or 'N' )");
                ReturnToMenu();
                break;
        }
    }
    catch (Exception ex)
    {
        Console.Clear();
        Console.WriteLine(ex);
        Console.WriteLine("Response must be a character of either: \n ( 'Y' or 'N' )");
        ReturnToMenu();
    }
}

DisplayMenu();

// don't move or change this!
public partial class Program { }
