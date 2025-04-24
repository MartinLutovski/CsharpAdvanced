#region Abstract classes

//Human human = new Human(); =>  Error: Cannot create an instance of the abstract class or interface 'Human'
// Abstract classes cannot be instantiated directly. But they do have a constructor!!!

using AbstractAndInterface.Entities;

Developer dev = new Developer("Martin Lutovski", 31, 071273260, new List<string> { "C#", "JavaScript" }, 1);

Tester tester = new Tester("Bob Bobsky", 32, 071333222, 100);

Console.WriteLine("The Developer");
Console.WriteLine(dev.GetInfo());
dev.Greet("Students");
dev.Code();
dev.DrinkCoffee();
dev.Debug();

Console.WriteLine("------------------------------");
Console.WriteLine("The Tester");
Console.WriteLine(tester.GetInfo());
tester.TestFeature("Demo example feature");
tester.WriteTestCases();
tester.DocumentBugs();

if (tester.FoundBug())
{
    Console.WriteLine($"The tester {tester.FullName} has found a bug!");
}
else
{
    Console.WriteLine($"The tester {tester.FullName} has not found a bug!");
}



#endregion



#region Interfaces
void DoSomething(Developer dev, string name) {
    dev.Greet(name);
    Console.WriteLine(dev.SayGoodbye(name));


}

DoSomething(dev, "Martin");



#endregion
