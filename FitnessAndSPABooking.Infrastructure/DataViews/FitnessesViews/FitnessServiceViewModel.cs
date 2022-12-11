using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.Fitnesses
{
    public class FitnessServiceViewModel : IMapFrom<SalonService>
    {
        public string FitnessId { get; set; } = null!;

        public int ServiceId { get; set; }

        public string ServiceName { get; set; } = null!;

        public string ServiceDescription { get; set; } = null!;

        public bool Available { get; set; }
    }
}
