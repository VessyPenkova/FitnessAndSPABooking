using FitnessAndSPABooking.Infrastructure.Data.Common.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.Models
{
    public class FitnessService : BaseDeletableModel<int>
    {
        public FitnessService()
        {
            Bookings = new List<Booking>();
        }

        [Required]
        public string FitnessId { get; set; } = null!;

        [ForeignKey(nameof(FitnessId))]
        public virtual Fitness? Fitness { get; set; }

        public int ServiceId { get; set; }
        [ForeignKey(nameof(ServiceId))]
        public virtual Service? Service { get; set; }

        // Each Salon gets all Services from its Category, but may not provide them all
        public bool Available { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
