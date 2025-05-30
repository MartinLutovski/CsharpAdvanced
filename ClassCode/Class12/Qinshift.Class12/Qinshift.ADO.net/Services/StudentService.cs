using Microsoft.Data.SqlClient;
using Qinshift.ADO.net.Entities;

namespace Qinshift.ADO.net.Services
{
    public class StudentService
    {
        private readonly string _conString;

        public StudentService(string conString)
        {
            _conString = conString;
        }


        public List<Student> GetAllStudents()
        {
            // 1. Open a connection to the database
            // 2. Create query
            // 3. Create query command
            // 4. Execute the query command
            // 5. Read the students returned if there are any
            // 6. Map the data into list of students
            // 7. Return the list of students as a result

            var students = new List<Student>();

            using (SqlConnection connection = new SqlConnection(_conString))
            {
                connection.Open();
                string query = "SELECT ID, FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIdNumber, StudentCardNumber FROM Student";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student()
                        {
                            Id = reader.GetInt32(0),
                            FirstName = reader.IsDBNull(1) ? null : reader.GetString(1),
                            LastName = reader.IsDBNull(2) ? null : reader.GetString(2),
                            DateOfBirth = reader.IsDBNull(3) ? null : reader.GetDateTime(3),
                            EnrolledDate = reader.IsDBNull(4) ? null : reader.GetDateTime(4),
                            Gender = reader.IsDBNull(5) ? null : reader.GetString(5)[0],
                            NationalIdNumber = reader.IsDBNull(6) ? null : reader.GetInt64(6),
                            StudentCardNumber = reader.IsDBNull(7) ? null : reader.GetString(7)
                        });
                    }
                }
            }
            return students;
        }

        public Student? GetStudentById(string id)
        {
            Student? student = null;
            using (SqlConnection connection = new SqlConnection(_conString))
            {
                connection.Open();
                string query = $"SELECT ID, FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIdNumber, StudentCardNumber FROM Student WHERE ID = '{id}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            student = new Student()
                            {
                                Id = reader.GetFieldValue<int>(0),
                                FirstName = reader.IsDBNull(1) ? null : reader.GetFieldValue<string>(1),
                                LastName = reader.IsDBNull(2) ? null : reader.GetFieldValue<string>(2),
                                DateOfBirth = reader.IsDBNull(3) ? null : reader.GetFieldValue<DateTime>(3),
                                EnrolledDate = reader.IsDBNull(4) ? null : reader.GetFieldValue<DateTime>(4),
                                Gender = reader.IsDBNull(5) ? null : reader.GetFieldValue<string>(5)[0],
                                NationalIdNumber = reader.IsDBNull(6) ? null : reader.GetFieldValue<long>(6),
                                StudentCardNumber = reader.IsDBNull(7) ? null : reader.GetFieldValue<string>(7)
                            };
                        }
                    }
                }
            }
            return student;
        }

        public void InsertStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(_conString))
            {
                connection.Open();
                string query = @"INSERT INTO Student (FirstName, LastName, DateOfBirth, EnrolledDate, Gender, NationalIdNumber, StudentCardNumber)
                                VALUES (@FirstName, @LastName, @DateOfBirth, @EnrolledDate, @Gender, @NationalIdNumber, @StudentCardNumber)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", student.Id);
                    command.Parameters.AddWithValue("@FirstName", (object)student.FirstName ?? DBNull.Value);
                    command.Parameters.AddWithValue("@LastName", (object)student.LastName ?? DBNull.Value);
                    command.Parameters.AddWithValue("@DateOfBirth", (object)student.DateOfBirth ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EnrolledDate", (object)student.EnrolledDate ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Gender", (object)student.Gender ?? DBNull.Value);
                    command.Parameters.AddWithValue("@NationalIdNumber", (object)student.NationalIdNumber ?? DBNull.Value);
                    command.Parameters.AddWithValue("@StudentCardNumber", (object)student.StudentCardNumber ?? DBNull.Value);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
