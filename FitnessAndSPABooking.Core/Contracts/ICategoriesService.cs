

namespace FitnessAndSPABooking.Core.Contracts
{
    public interface ICategoriesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>(int? count = null);

        Task<T> GetByIdAsync<T>(int id);

        Task AddAsync(string name, string description, string imageUrl);

        Task DeleteAsync(int id);
    }
}
