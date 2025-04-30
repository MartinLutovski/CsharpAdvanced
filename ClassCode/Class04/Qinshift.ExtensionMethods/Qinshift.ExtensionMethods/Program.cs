using Qinshift.ExtensionMethods.Entities;
using Qinshift.ExtensionMethods.Helpers;
string veryLongString = "This is a very long string that needs to be split into multiple lines for better readability and maintainability. It contains a lot of information that is important for the program to function correctly, and it is essential to ensure that it is formatted properly.";
string test = "";
string something = "This is another string";


Console.WriteLine(veryLongString.Shorten(3));
Console.WriteLine(veryLongString.Shorten(5));

Console.Write(test.Shorten(2));

Console.WriteLine(something.Shorten(0));



Console.WriteLine("===Exercise===");
Console.WriteLine(veryLongString.Quote());


Console.WriteLine("=======NumbersHelper=========");

Console.WriteLine(2.isEven());
Console.WriteLine(3.isOdd());
Console.WriteLine(4.isEven());
Console.WriteLine(5.isOdd());
Console.WriteLine(5.isEven());


Console.WriteLine("=======ProductHelper=========");

Product product1 = new Product { Id = 1, Name = "Product 1" };
Product product2 = new Product { Id = 2, Name = "Product 2" };
Product product3 = new Product { Id = 3, Name = "Product 3" };

Console.WriteLine("Products Ids printed in console:");
product1.PrintProductId();
product2.PrintProductId();
product3.PrintProductId();

// PiggyBacking

