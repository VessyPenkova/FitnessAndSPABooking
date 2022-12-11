using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.Fitnesses
{
    public  class FitnessSimpleViewModel : IMapFrom<Salon>
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
