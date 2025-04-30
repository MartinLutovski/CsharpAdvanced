
namespace Qinshift.ExtensionMethods.Helpers
{
    public static class PiggyBackingStringHelper
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords <0)
               throw new ArgumentException("Number of words must be greater than or equal to 0.");
            if (str.Length == 0)
                return "";

            string[] words = str.Split(' ');

            if (words.Length < numberOfWords)
                return str;

            List<string> substring = words.Take(numberOfWords).ToList();

            string result = string.Join(" ", substring);

            return result + "...";
        }


        public static string Quote(this string str)
        {
            return $"\"{str}\"";
        }
    }
}
