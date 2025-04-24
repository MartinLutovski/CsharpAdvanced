

using AbstractAndInterface.Interfaces;

namespace AbstractAndInterface.Entities
{
    public class Developer : Human, IDeveloper
    {
        public Developer(string fullName, int age, long phoneNumber, List<string> programingLanguages, int yearsOfExperience) 
            : base(fullName, age, phoneNumber)
        {
            ProgramingLanguages = programingLanguages;
            YearsOfExperience = yearsOfExperience;
        }
        public List<string> ProgramingLanguages { get; set; } = new ();

        public int YearsOfExperience { get; set; }

        public void Code()
        {
            Console.WriteLine($"Tak tak tak");
            Console.WriteLine("Opens stack overflow");
            Console.WriteLine($"Tak tak tak");
        }

        public void Debug()
        {
            Console.WriteLine($"The Developer is ebugging!");
        }

        public void DrinkCoffee()
        {
            Console.WriteLine($"Break! Get some coffee!");
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age} years of age - {YearsOfExperience} years in experience)";
        }
    }
}
