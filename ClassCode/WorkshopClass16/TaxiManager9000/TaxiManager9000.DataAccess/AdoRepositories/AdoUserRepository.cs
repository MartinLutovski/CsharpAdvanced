

using Microsoft.Data.SqlClient;
using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.DataAccess.AdoRepositories
{
    public class AdoUserRepository : IUserRepository
    {
        private readonly string _connectionString;
        public AdoUserRepository(string connString)
        {
            _connectionString = connString;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            var users = new List<User>();
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("SELECT * FROM Users", conn);
            await conn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                users.Add(new User
                {
                    Id = reader.GetFieldValue<int>(0),
                    Username = reader.GetFieldValue<string>(1),
                    Password = reader.GetFieldValue<string>(2),
                    Role = (Role)reader.GetFieldValue<int>(3)
                });
            }
            return users;
        }
    }
}
