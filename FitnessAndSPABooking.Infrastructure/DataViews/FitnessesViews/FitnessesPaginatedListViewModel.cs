using FitnessAndSPABooking.Infrastructure.Data.Common.Pignation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.Fitnesses
{
    public  class FitnessesPaginatedListViewModel
    {
        public PaginatedList<FitnessViewModel> Fitnesses { get; set; }
    }
}
