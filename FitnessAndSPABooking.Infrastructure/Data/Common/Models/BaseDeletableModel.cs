using FitnessAndSPABooking.Infrastructure.Data.Common.ContractsRepositories;

namespace FitnessAndSPABooking.Infrastructure.Data.Common.Models
{
    public abstract class BaseDeletableModel<TKey> : BaseModel<TKey>, IDeletableEntity
    {
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
