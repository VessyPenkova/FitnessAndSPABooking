using FitnessAndSPABooking.Core.Constrains;
using FitnessAndSPABooking.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FitnessAndSPABooking.Core.Constrains.GlobalConstants;

namespace FitnessAndSPABooking.Infrastructure.Data.BookedViews
{
    public class BookingRatingViewModel 
    {
        public string Id { get; set; }

        public string FitnessId { get; set; } = null!;

        public string FitnessName { get; set; } = null!;

        public string FitnessCategoryName { get; set; } = null!;

        public string FitnessCityName { get; set; } = null!;

        public string FitnessAddress { get; set; } = null!;

        public string FitnessImageUrl { get; set; } = null!;

        public bool? IsFitnessRatedByTheUser { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = GlobalConstants.ErrorMessages.Rating)]
        public int RateValue { get; set; }

    }
}
