class Program {

    static void SayHello(string person)
    {
        Console.WriteLine($"Hello there dear, {person}!");
    }

   static void SayGoodbye(string person)
    {
        Console.WriteLine($"Goodbye {person}, see you next time!");
    }

   static void PrintNumber(int number)
    {
        Console.WriteLine($"The number is {number}");
    }
   static void SayWhatever(string whatever, SayDelegate sayDel)

    {
        Console.WriteLine("Chatbot says:");
        sayDel(whatever);
    }

    static void MasterCalculator(int a, int b,NumberDelegate numberDel)
    {
        Console.WriteLine($"The result is : {numberDel(a, b)}");
    }



    public delegate void SayDelegate(string person);

    public delegate int NumberDelegate(int a, int b);
    static void Main(string[] args)
    {

        #region Declare and instantiate a delegate
        SayDelegate sayHelloDel = new SayDelegate(SayHello);
        SayDelegate sayGoodbyeDel = new SayDelegate(SayGoodbye);
        SayDelegate SayWoowDel = new SayDelegate(x => Console.WriteLine($"Wooow {x}"));


        //SayDelegate PrintNumber = new SayDelegate(PrintNumber); ---> this will not work,
        // because the signature does not match the SayDelegate delegate signature


        sayHelloDel("Bob");
        sayGoodbyeDel("Martin");
        SayWoowDel("Slave");
        #endregion



        #region Passing a method to a delegate parameter
        Console.WriteLine("============Passing delegate as parameter on other method================");


        SayWhatever("Bob", SayHello);
        SayWhatever("Jill", SayGoodbye);

        SayWhatever("Ana", x => Console.WriteLine($"Hi {x}, Before the chatbotsays something, welcome on behalf our company!"));

        #endregion


        #region Making a high order method
        MasterCalculator(123, 235, (a, b) => a + b);
        MasterCalculator(2356, 1289, (a, b) => a * b);
        MasterCalculator(478, 22, (a, b) => a - b);
        MasterCalculator(677, 25, (a, b) => a / b);
        MasterCalculator(2, 3, (a, b) => a * a + b * b);



        #endregion


    }


}
