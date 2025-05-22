


string appPath = @"..\..\..\";

string folderPath = appPath + @"MyFolder\";

string filePath = folderPath + "text.txt";


// Could also use Path.Combine to create the file path
//string combinePaths = Path.Combine(folderPath, "text.txt");
//Console.WriteLine(combinePaths);

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine($"Directory created: {folderPath}");
}

#region Writing with StreamWriter

using (StreamWriter sw = new StreamWriter(filePath))
{
    sw.WriteLine("Hello Qinshift Academy!");
    sw.WriteLine("This is a new line added in the same file!.");
    Console.WriteLine("Writing in a file completed!");
}

using (StreamWriter sw = new StreamWriter(filePath, true))
{
    sw.WriteLine("This is another text added to the file!");
    sw.WriteLine("I hope that it will not overwrite the previous text!");
    Console.WriteLine("Writing in a file completed one more time");
}

using(StreamReader sr = new StreamReader(filePath))
{
    //string firstLine = sr.ReadLine();
    //string secondLine = sr.ReadLine();

    string fileContent = sr.ReadToEnd();

    //Console.WriteLine($"First line: {firstLine}");
    //Console.WriteLine($"Second line: {secondLine}");
    Console.WriteLine($"The rest of the content: {fileContent}");
}

#endregion