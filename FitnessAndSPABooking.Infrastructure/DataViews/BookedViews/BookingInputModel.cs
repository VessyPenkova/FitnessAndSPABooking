using FitnessAndSPABooking.Core.Constrains;
using FitnessAndSPABooking.Infrastructure.Data.Common.ValidationAtributes;
using FitnessAndSPABooking.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;


namespace FitnessAndSPABooking.Infrastructure.Data.BookedViews
{
    public  class BookingInputModel 
    {
        [Required]
        public string FitnessId { get; set; } = null!;

        [Required]
        public int ServiceId { get; set; }

        [Required]
        [ValidateDate(ErrorMessage = GlobalConstants.ErrorMessages.DateTime)]
        public string Date { get; set; } = null!;

        [Required]
        [ValidateTime(ErrorMessage = GlobalConstants.ErrorMessages.DateTime)]
        public string Time { get; set; } = null!;
    }
}
