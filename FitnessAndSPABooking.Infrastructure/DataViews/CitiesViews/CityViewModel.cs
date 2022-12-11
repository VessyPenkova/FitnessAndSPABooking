using FitnessAndSPABooking.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.CitiesViews
{
    public  class CityViewModel 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SalonsCount { get; set; }
    }
}
