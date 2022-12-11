using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.FitnesServices
{
    public  class FitnessServiceDetailsViewModel : IMapFrom<FitnessService>
    {
        public string FitnessId { get; set; } = null!;

        public string FitnessName { get; set; } = null!;

        public string FitnessCityName { get; set; } = null!;

        public string FitnessAddress { get; set; } = null!;

        public int ServiceId { get; set; }

        public string ServiceName { get; set; } = null!;
    }
}
