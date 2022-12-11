using FitnessAndSPABooking.Core.Constrains;
using FitnessAndSPABooking.Infrastructure.Data.Common.Models;
using System.ComponentModel.DataAnnotations;

namespace FitnessAndSPABooking.Infrastructure.Data.Models
{
    public class Category : BaseDeletableModel<string>
    {
        public Category()
        {
            Services = new List<Service>();
            Fitnesses = new List<Fitness>();
        }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(GlobalConstants.DataValidations.DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        public virtual ICollection<Service> Services { get; set; }

        public virtual ICollection<Fitness> Fitnesses { get; set; }
    }
}
