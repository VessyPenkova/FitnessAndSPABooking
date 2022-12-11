using FitnessAndSPABooking.Core.Constrains;
using FitnessAndSPABooking.Infrastructure.Data.Common.Models;
using System.ComponentModel.DataAnnotations;

namespace FitnessAndSPABooking.Infrastructure.Data.Models
{
    public  class Blog : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(GlobalConstants.DataValidations.TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(GlobalConstants.DataValidations.ContentMaxLength)]
        public string Content { get; set; } = null!;

        // Blog can be created only in the Admin Dashboard
        // so the Author is not a User, just a string for name
        [Required]
        [MaxLength(GlobalConstants.DataValidations.NameMaxLength)]
        public string Author { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;
    }
}
