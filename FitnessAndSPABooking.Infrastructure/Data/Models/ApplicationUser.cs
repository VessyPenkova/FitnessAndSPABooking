using FitnessAndSPABooking.Infrastructure.Data.Common.ContractsRepositories;
using Microsoft.AspNetCore.Identity;

namespace FitnessAndSPABooking.Infrastructure.Data.Models
{
    public  class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid().ToString();
            Roles = new List<IdentityUserRole<string>>();
            Claims = new List<IdentityUserClaim<string>>();
            Logins = new List<IdentityUserLogin<string>>();
            Bookings = new List<Booking>();
            Fitnesses = new List<Fitness>();
        }

        // Check info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }

        public virtual ICollection<Fitness> Fitnesses { get; set; }
    }
}
