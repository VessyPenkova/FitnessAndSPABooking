using FitnessAndSPABooking.Core.Constrains;
using FitnessAndSPABooking.Infrastructure.Data.Common.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessAndSPABooking.Infrastructure.Data.Models
{
    public class Fitness : BaseDeletableModel<string>
    {
        public Fitness()
        {
            Bookings = new HashSet<Booking>();
            Services = new HashSet<FitnessService>();
        }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        // Not Required! Allows testing/showing functionality with seeded data in Admin/Manager Area
        // For now Fitnesses can be created only in the AdminDashboard and all of them are managed by one seeded ManagerAccount
        // This will be used when Registering a Fitness becomes an option for every user
        public string? OwnerId { get; set; }

        public virtual ApplicationUser? Owner { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category? Category { get; set; }

        public int CityId { get; set; }


        [ForeignKey(nameof(CityId))]

        public virtual City? City { get; set; }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.AddressMaxLength)]
        public string Address { get; set; } = null!;

        public double Rating { get; set; }

        public int RatersCount { get; set; }

        public virtual ICollection<FitnessService> Services { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
