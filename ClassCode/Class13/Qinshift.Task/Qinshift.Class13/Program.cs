Console.WriteLine("App start ...");

// Single Task example

Task myTask = new Task(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("This comes into the console after 2 seconds.");

});

myTask.Start();

// Single Task with return type

Task<int> valueTask = new Task<int>(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("We can now get the number ...");

    throw new Exception("Something went wrong!");
});
Console.WriteLine("Task status:" + valueTask.Status);
valueTask.Start();
Console.WriteLine("Task status:" + valueTask.Status);

Thread.Sleep(3000);
if(valueTask.IsCompleted)
{
    Console.WriteLine("Task is completed!");
}
else
{
    Console.WriteLine("Task is still running on some thread!");
}

if (valueTask.IsCompletedSuccessfully)
{
    Console.WriteLine("My value task is complete succesfully!");
}
else
{
    Console.WriteLine("My value task is not complete succesfully!");
}

    Task.Run(() =>
    {
        Thread.Sleep(3000);
        Console.WriteLine("This is executed immediately!");
    });

Console.WriteLine(valueTask.Result);

Console.WriteLine("App end ...");

//for (int i = 0; i <= 20; i++)
//{
//    int temp = i;
//    Task.Run(() =>
//    {
//        Thread.Sleep(2000);
//        Console.WriteLine("Task number:" + temp);
//    });
//}



Console.ReadLine(); // This line will be executed immediately after starting the task, not waiting for it to complete.
// Because the task is running asynchronously, the program will not wait for it to finish before moving on to the next line of code.
