using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.CitiesViews
{
    public  class CitiesListViewModel
    {
        public IEnumerable<CityViewModel> Cities { get; set; }
    }
}
