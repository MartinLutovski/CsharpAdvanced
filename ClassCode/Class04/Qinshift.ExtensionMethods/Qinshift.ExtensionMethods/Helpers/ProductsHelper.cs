namespace Qinshift.ExtensionMethods.Helpers
{
    public static class ProductsHelper
    {
        public static void PrintProductId(this Entities.Product product)
        {
            Console.WriteLine($"Product ID: {product.Id}");
        }
    }
}
