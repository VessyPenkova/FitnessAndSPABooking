using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Core.Contracts
{
    public interface IServicesService
    {
        Task<IEnumerable<T>> GetAllAsync<T>();

        Task<IEnumerable<int>> GetAllIdsByCategoryAsync(int categoryId);

        Task<int> AddAsync(string name, int categoryId, string description);

        Task DeleteAsync(int id);
    }
}
