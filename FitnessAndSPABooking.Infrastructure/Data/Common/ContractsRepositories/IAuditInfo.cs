using System;

namespace FitnessAndSPABooking.Infrastructure.Data.Common.ContractsRepositories
{
    public interface IAuditInfo
    {
        DateTime CreatedOn { get; set; }

        DateTime? ModifiedOn { get; set; }
    }
}
