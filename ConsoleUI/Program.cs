using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

internal class Program
{
    private static void Main(string[] args)
    {
        ProductTest();

        // CategoryTest();
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        foreach (var category in categoryManager.GetAll().Data)
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

        var result = productManager.GetAll();

        if (result.Success)
        {
            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName + " // Price: " + product.UnitPrice);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
        
        Console.WriteLine(" ------------------------------ ");

        var result2 = productManager.GetProductDetails();

        if (result2.Success)
        {
            foreach (var product in result2.Data)
            {
                Console.WriteLine(product.ProductName + " // " + product.CategoryName);
            }
        }
        else
        {
            Console.WriteLine(result2.Message);
        }

    }
}