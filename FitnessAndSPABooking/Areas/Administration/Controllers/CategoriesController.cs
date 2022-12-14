using FitnessAndSPABooking.Core.Constrains;
using FitnessAndSPABooking.Infrastructure.Data.Categories;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAndSPABooking.Areas.Administration.Controllers
{
    public class CategoriesController : AdministartionController
    {
        private readonly ICategoriesService categoriesService;
        private readonly ICloudinaryService cloudinaryService;

        public CategoriesController(
            ICategoriesService categoriesService,
            ICloudinaryService cloudinaryService)
        {
            this.categoriesService = categoriesService;
            this.cloudinaryService = cloudinaryService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new CategoriesListViewModel
            {
                Categories = await this.categoriesService.GetAllAsync<CategoryViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult AddCategory()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            string imageUrl;
            try
            {
                imageUrl = await this.cloudinaryService.UploadPictureAsync(input.Image, input.Name);
            }
            catch (System.Exception)
            {
                // In case of missing Cloudinary configuration from appsettings.json
                imageUrl = GlobalConstants.Images.CloudinaryMissing;
            }

            await this.categoriesService.AddAsync(input.Name, input.Description, imageUrl);
            return this.RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.Categories)
            {
                return this.RedirectToAction("Index");
            }

            await this.categoriesService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
