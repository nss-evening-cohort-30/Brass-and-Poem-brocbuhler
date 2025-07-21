
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
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
        Console.WriteLine("Please Choose one of the following");
    }
    catch (Exception ex)
    {
        Console.Clear();
        Console.WriteLine(ex);
        Console.WriteLine("Error occured");
        ReturnToMenu();
    }
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void ReturnToMenu()
{
    try
    {
        Console.WriteLine("Would you like to return to the menu? \n ( 'Y' or 'N' )");
        char Response = char.ToUpper(char.Parse(Console.ReadLine()));
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

// don't move or change this!
public partial class Program { }
