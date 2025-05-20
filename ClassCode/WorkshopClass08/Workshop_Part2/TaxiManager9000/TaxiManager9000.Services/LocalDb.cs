using TaxiManager9000.Domain.Models;

namespace TaxiManager9000.Services
{
    internal class LocalDb<T> : IDb<T> where T : BaseEntity
    {
    }
}