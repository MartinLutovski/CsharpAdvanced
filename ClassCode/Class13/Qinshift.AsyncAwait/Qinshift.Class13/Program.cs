void sendMessage(string message)
{
    Console.WriteLine("Sending message ...");
    Thread.Sleep(7000);
    Console.WriteLine($"The message '{message}' was sent!");
}


async Task SendMessageAsync(string message)
{
    Console.WriteLine("Sending message ...");
   await Task.Run(() =>
    {
        Thread.Sleep(7000);
        Console.WriteLine($"The message '{message}' was sent!");

        });
    Console.WriteLine($"The message '{message}' was sent!");
}


void ShowAd(string product)
{
    Console.WriteLine("While you wait let us show you an ad!");
    Thread.Sleep(1000);
    Console.WriteLine("Buy the best product in the world");
    Thread.Sleep(1000);
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write($"{product}");
    Thread.Sleep(1000);
    Console.ResetColor();
    Console.Write(" now and get");
    Thread.Sleep(1000);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(" FREE");
    Console.ResetColor();
    Thread.Sleep(1000);
    Console.WriteLine(" shipping worldwide!");
    Console.ReadLine();
}

sendMessage("Hello there!");

var x = SendMessageAsync("Hello there!");
Console.WriteLine(x.Status);

ShowAd("Tomato");
Console.ReadLine();
Console.WriteLine(x.Status);
