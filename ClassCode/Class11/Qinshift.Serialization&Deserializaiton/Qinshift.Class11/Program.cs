using Qinshift.Class11;

string directoryPath = @"..\..\..\OurData";

string fileName = "myFirstJson.json";
string filePath = Path.Combine(directoryPath, fileName);

ReaderWriter readerWriter = new ReaderWriter();

if (!Directory.Exists(directoryPath))
{
    Directory.CreateDirectory(directoryPath);
}

Student bob = new Student
{
    FirstName = "Bob",
    LastName = "Bobsky",
    Age = 23,
    IsPartTime = true
};


OurJsonSerializer jsonSerializer = new OurJsonSerializer();
string bobString = jsonSerializer.SerializeStudent(bob);

readerWriter.WriteFile(filePath, bobString);
