

namespace FitnessAndSPABooking.Infrastructure.Data.BookedViews
{
    public class BookingViewModel 
    {
        public string Id { get; set; } = null!;

        public DateTime DateTime { get; set; }

        public string UserEmail { get; set; } = null!;

        public string SalonId { get; set; } = null!;

        public string SalonName { get; set; } = null!;

        public string SalonCityName { get; set; } = null!;

        public string SalonAddress { get; set; } = null!;

        public int ServiceId { get; set; }

        public string ServiceName { get; set; } = null!;

        public bool? Confirmed { get; set; }

        public bool? IsSalonRatedByTheUser { get; set; }

    }
}
