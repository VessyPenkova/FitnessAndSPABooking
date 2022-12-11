using FitnessAndSPABooking.Infrastructure.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.Models
{
    public class Booking : BaseDeletableModel<string>
    {
        public DateTime DateTime { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]

        public virtual ApplicationUser User { get; set; } = null!;

        [Required]
        public string FitnessId { get; set; } = null!;


        [ForeignKey(nameof(FitnessId))]
        public virtual Fitness Fitness { get; set; } = null!;



        public int ServiceId { get; set; }

        [ForeignKey(nameof(ServiceId))]
        public virtual Service Service { get; set; } = null!;

        public virtual FitnessService FitnessService { get; set; } = null!;

        // The Fitness can Confirm or Decline an booking
        public bool? Confirmed { get; set; }

        // For every booking the User can Rate the Fitness
        // But rating can be given only once for each booking
        public bool? IsFitnessRatedByTheUser { get; set; }
    }
}
