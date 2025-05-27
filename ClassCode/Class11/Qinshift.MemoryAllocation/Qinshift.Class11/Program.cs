

using Qinshift.Class11;

int num1 = 10;
int num2 = num1;

num2 = 50; // This does not change num1

Console.WriteLine($"num1: {num1}, num2: {num2}"); // Output: num1: 10, num2: 50


List<int> ints1 = new List<int> { 1, 2, 3 };
List<int> ints2 = ints1; // ints2 references the same list as ints1
ints1[1] = 1000;

ints1.ForEach(n => Console.WriteLine(n)); // Output: 1, 1000, 3
ints2.ForEach(n => Console.WriteLine(n)); // Output: 1, 1000, 3

User john = new User
{
    FirstName = "John",
    LastName = "Doe",
    Age = 30
};

User john2 = john;
john2.Age = 71;

john.PrintInfo(); // Output: Name: John Doe, Age: 71
john2.PrintInfo(); // Output: Name: John Doe, Age: 71



Console.WriteLine("\n ========= STRINGS ========== \n");

string stringOne = "String One";
string stringTwo = stringOne; // stringTwo references the same string as stringOne
stringTwo = "String Two"; // This creates a new string and does not change stringOne

Console.WriteLine(stringOne); // Output: String One
Console.WriteLine(stringTwo); // Output: String Two - stringTwo now references a new string object


Console.WriteLine("\n ========= OBJECTS LIFECYCLE  ========== \n");

void testObject()
{
    User bob = new User("Bob", "Bobsky", 23);
    User John = new User("John", "Johnsky", 34);
    Console.WriteLine("Logic with bob object");
    bob.PrintInfo(); // Output: Name: Bob Bobsky, Age: 23
    Console.WriteLine("More logic...");
    john.PrintInfo(); // Output: Name: John Johnsky, Age: 34
    Console.WriteLine("Okay, we dont need this memory anymore.");
}

testObject();
GC.Collect(); // Force garbage collection to clean up unused objects 
// Generally not needed, but useful for demonstration, will almost always be done automatically by the runtime

Console.ReadLine();