bool continueCalculator = true;

while (continueCalculator)
{
    Console.WriteLine("\nEnter first number:");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter second number:");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter operation (+, -, *, /, %):");
    char operation = Console.ReadLine()![0];

    double result = 0;

    switch (operation)
    {
        case '+':
            result = num1 + num2;
            break;
        case '-':
            result = num1 - num2;
            break;
        case '*':
            result = num1 * num2;
            break;
        case '/':
            if (num2 != 0)
                result = (double)num1 / num2;
            else
            {
                Console.WriteLine("Cannot divide by zero!");
                continue;
            }
            break;
        case '%':
            result = (double)(num1 * num2) / 100;
            break;
        default:
            Console.WriteLine("Invalid operation!");
            continue;
    }

    Console.WriteLine($"Result: {result}");

    Console.WriteLine("\nDo you want to perform another calculation? (y/n):");
    continueCalculator = Console.ReadLine()?.ToLower().StartsWith("y") ?? false;
}

Console.WriteLine("Thank you for using the calculator!");
