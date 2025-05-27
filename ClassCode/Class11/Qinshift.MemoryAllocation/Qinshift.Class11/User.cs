using Qinshift.Class11;

namespace Qinshift.Class11
{
    public class User
    {
        public User() { } // Add a public parameterless constructor

        public User(string firstName, string lastName, int age) // Ensure this constructor is public
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
        }
    }
}
