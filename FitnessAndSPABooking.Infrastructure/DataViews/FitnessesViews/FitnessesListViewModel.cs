using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.Fitnesses
{
    public  class FitnessesListViewModel
    {
        public IEnumerable<FitnessViewModel> Fitnesses { get; set; }
    }
}
