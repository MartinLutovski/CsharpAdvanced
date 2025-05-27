

namespace Qinshift.Class11
{
    public class OurJsonSerializer
    {
        public string SerializeStudent (Student student)
        {
            string json = string.Empty;
            json += "{";
            json += $"\"FirstName\":\"{student.FirstName}\",";
            json += $"\"LastName\":\"{student.LastName}\",";
            json += $"\"Age\":{student.Age},";
            json += $"\"IsPartTime\":{student.IsPartTime.ToString().ToLower()},";
            json += "}";

            return json;
        }
    }
}
