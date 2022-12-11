using FitnessAndSPABooking.Core.Constrains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FitnessAndSPABooking.Core.Constrains.GlobalConstants;

namespace FitnessAndSPABooking.Infrastructure.Data.CitiesViews
{
    public  class CityInputModel
    {
        [Required]
        [StringLength(
            GlobalConstants.DataValidations.NameMaxLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Name,
            MinimumLength = GlobalConstants.DataValidations.NameMinLength)]
        public string Name { get; set; }
    }
}
