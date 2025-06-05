
namespace Qinshift.Practices.Practices
{
    internal class IfElse
    {
        public void IfElseExample(int num1, int num2)
        {
        // Bad example bellow
            if (num1 <= 100 && num2 <= 100)
            {
                if (num1 % 2 == 0 && num2 % 2 == 0)
                {
                    if (num1 == num2)
                    {
                        Console.WriteLine("They are equal.");
                    }
                }
            }
            // Good example bellow
            if (num1 > 100 && num2 > 100) return;
            if (num1 % 2 != 0 && num2 % 2 != 0) return;
            if (num1 == num2) return;
            Console.WriteLine("They are equal.");
        }

    }
}
