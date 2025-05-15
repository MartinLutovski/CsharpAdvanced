

namespace Qinshift.Events.Entities
{
    public class Person
    {
        public string Name { get; set; }
        public bool HasWokenUp { get; set; } = false;

        public void WakeUp()
        {
            Console.WriteLine($"{Name} waaaakeeeeeeeeeeee up.");
            HasWokenUp = true;
        }
    }
        
   }
