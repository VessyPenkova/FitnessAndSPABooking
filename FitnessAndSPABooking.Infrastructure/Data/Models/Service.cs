using FitnessAndSPABooking.Core.Constrains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessAndSPABooking.Infrastructure.Data.FitnesServices;
using System.ComponentModel.DataAnnotations.Schema;
using FitnessAndSPABooking.Infrastructure.Data.Common.Models;

namespace FitnessAndSPABooking.Infrastructure.Data.Models
{
    public class Service : BaseDeletableModel<int>
    {
        public Service()
        {
            Fitnesses = new List<FitnessService>();
            Bookings = new List<Booking>();
        }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.NameMaxLength)]
        public string Name { get; set; } = null!;

        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual Category? Category { get; set; }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public virtual ICollection<FitnessService> Fitnesses { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
