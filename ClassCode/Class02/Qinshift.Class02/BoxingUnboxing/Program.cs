int number = 90;
object obj = number; // Boxing. Boxing is the process of converting a value type to a reference type object.
// Type of obj is object, but it holds a value of type int.
Console.WriteLine($"Boxed value: {obj}");


void PrintObject(object obj)
{
    Console.WriteLine($"Object value: {obj}");
}

PrintObject(number);
PrintObject(true);
PrintObject(2.4);


