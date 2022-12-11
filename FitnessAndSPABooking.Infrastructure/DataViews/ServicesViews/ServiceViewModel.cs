using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.Services
{
    public  class ServiceViewModel
    {

        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;


        public string CategoryName { get; set; } = null!;


        public int FitnessesCount { get; set; }

        public int BookingssCount { get; set; }
    }
}
