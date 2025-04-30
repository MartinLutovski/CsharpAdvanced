
namespace Qinshift.ExtensionMethods.PiggyBackingHelpers;

public static class PiggyBackingNumbersHelper
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
