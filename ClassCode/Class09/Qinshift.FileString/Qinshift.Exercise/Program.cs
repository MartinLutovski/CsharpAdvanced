// create folder and file
string appPath = @"..\..\..\";
string exerciseFolderPath = appPath + @"Exercise\";
string calculationsPath = exerciseFolderPath + "calculations.txt";

if (!Directory.Exists(exerciseFolderPath))
{
    Directory.CreateDirectory(exerciseFolderPath);
    Console.WriteLine($"Directory created: {exerciseFolderPath}");
}

// calculate
static int CalculateNumbers(int num1, int num2)
{
    return num1 + num2;
}

// formating
static string ResultFormat(int num1, int num2, int result)
{
    string calculation = $"{num1} + {num2} = {result}";
    return $"{calculation} - {DateTime.Now:dd-MM-yyyy HH:mm:ss}";
}

// input - output
Console.Write("Enter first number: ");
if (int.TryParse(Console.ReadLine(), out int num1))
{
    Console.Write("Enter second number: ");
    if (int.TryParse(Console.ReadLine(), out int num2))
    {
        
        int result = CalculateNumbers(num1, num2);
        
        
        string timeStampedCalculation = ResultFormat(num1, num2, result);
        
        
        Console.WriteLine($"Result: {timeStampedCalculation}");

        
        using (StreamWriter sw = new StreamWriter(calculationsPath, true))
        {
            sw.WriteLine(timeStampedCalculation);
        }

        
        using (StreamReader sr = new StreamReader(calculationsPath))
        {
            string fileContent = sr.ReadToEnd();
            Console.WriteLine($"File content:{fileContent}");
        }
    }
    else
    {
        Console.WriteLine("Invalid second number!");
    }
}
else
{
    Console.WriteLine("Invalid first number!");
}