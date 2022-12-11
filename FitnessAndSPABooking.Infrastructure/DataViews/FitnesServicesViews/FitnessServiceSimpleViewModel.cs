using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.FitnesServices
{
    public  class FitnessServiceSimpleViewModel : IMapFrom<FitnessService>
    {
        public string FitnessId { get; set; }

        public int ServiceId { get; set; }

        public bool Available { get; set; }
    }
}
