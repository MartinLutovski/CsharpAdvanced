namespace Qinshift.Practices.Practices
{

    // Bad example bellow
    class user // This class is not public, and it does not follow PascalCase naming convention for classes.
    {
        public int id; // This field should be private or protected, and it should follow camelCase naming convention.
        public string name; // It should follow camelCase naming convention.
        public bool isValid;
        private string userPath;
        public void printUser() { }
    }

    // Good example bellow

    public class User

    {
        public int Id { get; set; } // Use PascalCase for properties and make them public with getters and setters.

        public string Name { get; set; } // Use PascalCase for properties.
        public bool isValid { get; set; }
        private string _userPath; // Use "_" prefix for private fields to distinguish them from properties.
        public void PrintUser()
        {

        }

        // Bad example exception bellow

        class LoginProblem : Exception { }


        // Good example exception bellow

        class LoginException : Exception
        {

        }


    }

}
