namespace Qinshift.ExtensionMethods.Helpers
{
    public static class PiggyBackingProductsHelper
    {
        public static void PrintProductId(this Entities.Product product)
        {
            Console.WriteLine($"Product ID: {product.Id}");
        }
    }
}
