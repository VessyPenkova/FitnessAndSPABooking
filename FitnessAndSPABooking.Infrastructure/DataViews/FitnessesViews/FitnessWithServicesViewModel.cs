using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.Fitnesses
{
    public  class FitnessWithServicesViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;


        public string CategoryName { get; set; } = null!;


        public string CityName { get; set; } = null!;


        public string Address { get; set; } = null!;


        public double Rating { get; set; }

        public int RatersCount { get; set; }

        public virtual ICollection<FitnessServiceViewModel> Services { get; set; }
    }
}
