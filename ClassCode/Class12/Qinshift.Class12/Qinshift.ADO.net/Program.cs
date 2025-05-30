using Qinshift.ADO.net.Entities;
using Qinshift.ADO.net.Services;

string connectionString = "Server=PALMYRA17\\SQLEXPRESS; Database=SEDC_ACADEMY; Trusted_Connection=True;TrustServerCertificate=True;";

StudentService studentService = new StudentService(connectionString);

Console.WriteLine("Press 'ENTER' if you want to fetch all the students from the Database");
Console.ReadLine();

var students = studentService.GetAllStudents();

foreach (var student in students)
{
    Console.WriteLine($"Student: {student.FirstName} {student.LastName} | {student.StudentCardNumber}  | {student.DateOfBirth} | {student.EnrolledDate}");
}

Console.WriteLine("Enter ID to fetch a student by id:");
string studentId = Console.ReadLine();
var studentById = studentService.GetStudentById(studentId);

Console.WriteLine($"Student: {studentById?.FirstName} {studentById?.LastName} | {studentById?.StudentCardNumber}  | {studentById?.DateOfBirth} | {studentById?.EnrolledDate}");


Console.WriteLine("Look now a new student will be inserted");

Student s = new Student
{
    //Id = 571,
    FirstName = "Martin",
    LastName = "Lutovski",
    DateOfBirth = new DateTime(1993, 8, 7),
    EnrolledDate = DateTime.Now,
    Gender = 'M',
    NationalIdNumber = 1234567890,
    StudentCardNumber = "S1234567890"
};


studentService.InsertStudent(s);

