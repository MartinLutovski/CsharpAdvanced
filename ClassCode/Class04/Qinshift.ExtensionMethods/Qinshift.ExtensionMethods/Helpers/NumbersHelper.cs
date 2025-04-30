
namespace Qinshift.ExtensionMethods.Helpers
{
    public static class NumbersHelper
    {
        public static bool isEven(this int number)
        {   
            return number % 2 == 0;
        }

        public static bool isOdd(this int number)
        {
            return number % 2 != 0;
        }
    }
}
