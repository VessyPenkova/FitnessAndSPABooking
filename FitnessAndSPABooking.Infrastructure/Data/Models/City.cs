using FitnessAndSPABooking.Core.Constrains;
using FitnessAndSPABooking.Infrastructure.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.Models
{
    public class City : BaseDeletableModel<int>
    {
        public City()
        {
            Fitnesses = new List<Fitness>();
        }

        [Required]
        [MaxLength(GlobalConstants.DataValidations.NameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Fitness> Fitnesses { get; set; }
    }
}
