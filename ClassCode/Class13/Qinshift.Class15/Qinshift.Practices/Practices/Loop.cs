

namespace Qinshift.Practices.Practices
{
    public class Loop
    {
        List<string> stringNames = new List<string>()
        {
            "Bob",
            "Jordan",
            "Zoran",
            "Goran",
            "Horvat",
            "Jill"
        };

        public void LoopExample()
        {
        // Bad example below
            for (int i = 0; i < stringNames.Count; i++)
            {
                if (stringNames[i].Length == stringNames.Count)
                {
                    Console.WriteLine(stringNames[i]);
                }
            }

            // Good example below
            foreach (string name in stringNames)
            {
                if (name.Length == stringNames.Count)
                {
                    Console.WriteLine(name);
                }
            }
        }

    }
}
