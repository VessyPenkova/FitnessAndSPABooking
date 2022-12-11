using System.ComponentModel.DataAnnotations;
using FitnessAndSPABooking.Core.Constrains;
using Microsoft.AspNetCore.Http;
using FitnessAndSPABooking.Infrastructure.Data.Common.ValidationAtributes;

namespace FitnessAndSPABooking.Web.ViewModels.BlogViews
{
    public class BlogInputModel
    {
        [Required]
        [StringLength(
            GlobalConstants.DataValidations.TitleMaxLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Title,
            MinimumLength = GlobalConstants.DataValidations.TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(
            GlobalConstants.DataValidations.ContentMaxLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Content,
            MinimumLength = GlobalConstants.DataValidations.ContentMinLength)]
        public string Content { get; set; } = null!;

        [Required]
        [StringLength(
            GlobalConstants.DataValidations.NameMaxLength,
            ErrorMessage = GlobalConstants.ErrorMessages.Author,
            MinimumLength = GlobalConstants.DataValidations.NameMinLength)]
        public string Author { get; set; } = null!;

        [Required]
        [DataType(DataType.Upload)]
        [ValidateImage(ErrorMessage = GlobalConstants.ErrorMessages.Image)]
        public IFormFile Image { get; set; } = null!;
    }
}
