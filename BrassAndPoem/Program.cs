
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
using System.Collections;
using System.Diagnostics;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

List<Product> products = new List<Product>
 {
    new Product
    {
        Name = "Lightning 20",
        Price = 51,
        ProductTypeId = 3,
        DR = 20
    },
    new Product
    {
        Name = "Hammer",
        Price = 1,
        ProductTypeId = 1,
        DR = 12
    },
    new Product
    {
        Name = "Lucky Swing",
        Price = 23,
        ProductTypeId = 2,
        DR = 20
    },
    new Product
    {
        Name = "Fates Finder",
        Price = 23,
        ProductTypeId = 2,
        DR = 10
    },
    new Product
    {
        Name = "Toothpick",
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
        Title = "Brass",
    },
    new ProductType
    {
        Id = 2,
        Title = "Poem",
    },
    new ProductType
    {
        Id = 3,
        Title = "Sparky",
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
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name}");
    }
    // Console.WriteLine("Would you like to view a specific product? \n Enter its number \n Or enter '0' to exit");
    // try
    // {
    //     int Response = int.Parse(Console.ReadLine().Trim());
    //     switch (Response)
    //     {
    //         case 0:
    //             break;
    //         case 1:
    //             break;
    //         case 2:
    //     }
    // }
    // catch (Exception ex)
    // {

    // }
    ReturnToMenu();
}

void DeleteProduct()
{
    foreach (Product product in products)
    {
        Console.WriteLine($"{product.Name}");
    }
    Console.WriteLine("Please enter the name of the product you'd like to delete");
    string Response = Console.ReadLine().Trim();
    Product productToRemove = products.FirstOrDefault(p => p.Name.Equals(Response, StringComparison.OrdinalIgnoreCase));
    foreach (Product product in products)
    {
        if (Response == product.Name)
        {
            products.Remove(productToRemove);
            Console.WriteLine("Product deleted");
            ReturnToMenu();
        }
        else
        {
            Console.WriteLine("No product found.");
            ReturnToMenu();
        }
    }
}

void AddProduct()
{
    try
    {
        Console.WriteLine("Please enter a name for the product:");
        string NamePayload = Console.ReadLine().Trim();
        Console.WriteLine("Please enter the Price of the product:");
        decimal PricePayload = decimal.Parse(Console.ReadLine().Trim());
        Console.WriteLine("Pleae enter a Product Type Id:");
        int ProductTypePayload = int.Parse(Console.ReadLine().Trim());
        Console.WriteLine("Please enter what the dice will roll:");
        int DRPayload = int.Parse(Console.ReadLine().Trim());
        Product Payload = new Product
        {
            Name = NamePayload,
            Price = PricePayload,
            ProductTypeId = ProductTypePayload,
            DR = DRPayload
        };
        int TitleFinder = Payload.ProductTypeId - 1;
        Console.WriteLine($"This is a {Payload.Name} it sells for {Payload.Price}. It has {Payload.DR} many sides and it has a fancy {productTypes[TitleFinder].Title} design");
        products.Add(Payload);
        ReturnToMenu();
    }
    catch (Exception ex)
    {
        Console.Clear();
        Console.WriteLine(ex);
        Console.WriteLine("Try again");
        AddProduct();
    }
}

void UpdateProduct()
{
    try
    {
        foreach (Product product in products)
        {
            Console.WriteLine($"{product.Name}");
        }
        Console.WriteLine("Please enter the name of the product you'd like to edit");
        string Response = Console.ReadLine().Trim();
        Product Payload = products.FirstOrDefault(p => p.Name.Equals(Response, StringComparison.OrdinalIgnoreCase));
        if (Payload != null)
        {
            Console.WriteLine("Please enter a name for the product:");
            string NamePayload = Console.ReadLine().Trim();
            Console.WriteLine("Please enter the Price of the product:");
            decimal PricePayload = decimal.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Pleae enter a Product Type Id:");
            int ProductTypePayload = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Please enter what the dice will roll:");
            int DRPayload = int.Parse(Console.ReadLine().Trim());
            Payload = new Product
            {
                Name = NamePayload,
                Price = PricePayload,
                ProductTypeId = ProductTypePayload,
                DR = DRPayload
            };
            int TitleFinder = Payload.ProductTypeId - 1;
            Console.WriteLine($"This is a {Payload.Name} it sells for {Payload.Price}. It has {Payload.DR} many sides and it has a fancy {productTypes[TitleFinder].Title} design");
            ReturnToMenu();
        }
        else
        {
            Console.WriteLine("No product found by that name");
            ReturnToMenu();
        }
    }
    catch (Exception ex)
    {
        Console.Clear();
        Console.WriteLine(ex);
        Console.WriteLine("Try again");
        AddProduct();
    }
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
