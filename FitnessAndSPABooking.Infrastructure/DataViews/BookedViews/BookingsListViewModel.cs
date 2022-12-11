using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.BookedViews

{
    public class BookingsListViewModel
    {
        public IEnumerable<BookingViewModel> Bookings { get; set; }

    }
}
