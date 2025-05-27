Console.WriteLine("============\n DISPOSING ===========\n");


const string AppPath = @"../../../Text";

const string FilePath = AppPath + @"\test.txt";

void CreateFolder(string path)
{
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
}

void CreateFile(string path)
{
    if (!File.Exists(path))
    {
        File.Create(path).Close();
    }

}
CreateFolder(AppPath);
CreateFile(FilePath);

#region Manual Dispose Methods
void AppendTextInFile(string text, string path)
{
    StreamWriter streamWriter = new StreamWriter(path, true);
    streamWriter.WriteLine(text);
    streamWriter.Dispose();
}

void ReadTextFromFile(string path)
{
    StreamReader sr = new StreamReader(path);
    Console.WriteLine(sr.ReadToEnd());
    sr.Dispose();
}
void ManualDisposeExample()
{
    Console.WriteLine("Enter text part 1:");
    string test1 = Console.ReadLine();
    AppendTextInFile(test1, FilePath);

    Console.WriteLine("Enter text part 2:");
    string test2 = Console.ReadLine();
    AppendTextInFile(test2, FilePath);

    Console.WriteLine("Enter text part 3:");
    string test3 = Console.ReadLine();
    AppendTextInFile(test3, FilePath);

}

ManualDisposeExample();
ReadTextFromFile(FilePath);


#endregion


#region Dispose using block

void AppendTextInFileSafe(string text, string path)
{
    using StreamWriter streamWriter = new StreamWriter(path, true);
    streamWriter.WriteLine(text);

}

void ReadTextFromFileSafe(string path)
{
    using (StreamReader sr = new StreamReader(path))
    {
        Console.WriteLine(sr.ReadToEnd());
    }

}
void ManualDisposeExampleSafe()
{
    Console.WriteLine("Enter text part 1:");
    string test1 = Console.ReadLine();
    AppendTextInFile(test1, FilePath);

    Console.WriteLine("Enter text part 2:");
    string test2 = Console.ReadLine();
    AppendTextInFile(test2, FilePath);

    Console.WriteLine("Enter text part 3:");
    string test3 = Console.ReadLine();
    AppendTextInFile(test3, FilePath);

}


#endregion

