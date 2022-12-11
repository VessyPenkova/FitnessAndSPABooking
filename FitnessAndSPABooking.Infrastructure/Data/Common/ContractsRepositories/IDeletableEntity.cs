using System;

namespace FitnessAndSPABooking.Infrastructure.Data.Common.ContractsRepositories
{
    public interface IDeletableEntity
    {
        bool IsDeleted { get; set; }

        DateTime? DeletedOn { get; set; }
    }
}
