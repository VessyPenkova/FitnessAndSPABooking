using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.Fitnesses
{
    public  class FitnessViewModel : IMapFrom<Salon>
    {
        public string Id { get; set; }

        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = null!;

        public string CityName { get; set; } = null!;

        public string Address { get; set; } = null!;

        public double Rating { get; set; }

        public int RatersCount { get; set; }

        public int BookingsCount { get; set; }
    }
}
