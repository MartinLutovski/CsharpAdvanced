internal class ReaderWriter
{
    public void WriteFile(string filePath, string content)
    {
        File.WriteAllText(filePath, content);
    }
}