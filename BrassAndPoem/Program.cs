
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
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
    throw new NotImplementedException();
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

// don't move or change this!
public partial class Program { }
