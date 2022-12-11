using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Core.Contracts
{
    public interface IFitnesServicesService
    {
        Task<T> GetByIdAsync<T>(string salonId, int serviceId);

        Task AddAsync(string salonId, IEnumerable<int> servicesIds);

        Task AddAsync(IEnumerable<string> salonsIds, int serviceId);

        Task ChangeAvailableStatusAsync(string salonId, int serviceId);
    }
}
