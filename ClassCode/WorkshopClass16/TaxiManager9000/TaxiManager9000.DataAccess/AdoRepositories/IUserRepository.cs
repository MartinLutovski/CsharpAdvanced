

using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.DataAccess.AdoRepositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();


    }
}
