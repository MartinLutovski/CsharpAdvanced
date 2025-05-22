

#region Directory Manipulation





string currentDirectory = Directory.GetCurrentDirectory();

Console.WriteLine($"Current Directory: {currentDirectory}");

// Relative path to our application
string relativePath = @"..\..\..\";
Console.WriteLine($"Relative Path: {relativePath}");

// Absolute path to our application

string absolutePath = "C:\\Users\\code\\Desktop\\myRepo\\CsharpAdvanced\\ClassCode\\Class09\\Qinshift.Class09\\Qinshift.FileSystem\\";
Console.WriteLine($"Absolute Path: {absolutePath}");


// Create new folder
Console.WriteLine("======= Creating new Directory =======");
bool ifDemoFolderExists = Directory.Exists(relativePath + @"DemoFolder");
bool ifDemoFolderExistsString = Directory.Exists(absolutePath + @"DemoFolder");

Console.WriteLine($"Does DemoFolder exists: {ifDemoFolderExists}");
Console.WriteLine($"Does DemoFolder absolute path exists: {ifDemoFolderExistsString}");

// Create new folder

string demoFolderPath = relativePath + @"DemoFolder";

Console.WriteLine($"Does DemoFolder exists before: {Directory.Exists(demoFolderPath)}");

if (!Directory.Exists(demoFolderPath))
{
    Directory.CreateDirectory(demoFolderPath);
    Console.WriteLine($"DemoFolder created.");
}

Console.WriteLine($"Does DemoFolder exists after: {Directory.Exists(demoFolderPath)}");

//Console.WriteLine("Press any key to delete the folder!");
//Console.ReadLine();

//if (Directory.Exists(demoFolderPath))
//{
//    Directory.Delete(demoFolderPath);
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine($"DemoFolder was deleted.");
//    Console.ResetColor();
//}
//else
//{
//    Console.WriteLine($"DemoFolder does not exist.");
//}
//Console.ReadLine();
#endregion

#region File Manipulation
Console.ReadLine();
string folderPath = relativePath + @"DemoFolder_1\";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine($"DemoFolder_1 created.");
}

// File Create
string filePath = folderPath + @"demo.txt";

if (!File.Exists(folderPath + @"demo.txt"))
{
    File.Create(folderPath + @"demo.txt").Close();
    Console.WriteLine($"demo.txt created.");
}

// File Delete

//if (File.Exists(folderPath + @"demo.txt"))
//{
//    File.Delete(folderPath + @"demo.txt");
//    Console.WriteLine($"demo.txt was deleted.");
//}


// Write to file
if (File.Exists(folderPath + @"demo.txt"))
{
    File.WriteAllText(filePath, "Hello there we are learning how to insert text in file and it is awesome!");
    Console.WriteLine("Succesfully writen in a file!");
}

// Read from file
if (File.Exists(filePath))
{
    string content = File.ReadAllText(filePath);
    Console.WriteLine($"Content of the file: {content}");
}








#endregion
