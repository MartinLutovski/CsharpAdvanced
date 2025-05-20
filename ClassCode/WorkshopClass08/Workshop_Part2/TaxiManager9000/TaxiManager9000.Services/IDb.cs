using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.Services
{
    internal interface IDb<T> where T : BaseEntity
    {
        object GetAll();
        User GetById(int id);
        void Update(User user);
    }
}