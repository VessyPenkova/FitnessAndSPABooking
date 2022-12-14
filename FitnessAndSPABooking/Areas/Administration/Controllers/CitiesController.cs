using FitnessAndSPABooking.Core.Constrains;
using FitnessAndSPABooking.Infrastructure.Data.Cities;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAndSPABooking.Areas.Administration.Controllers
{
    public class CitiesController : AdministartionController
    {
        private readonly ICitiesService citiesService;

        public CitiesController(ICitiesService citiesService)
        {
            this.citiesService = citiesService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new CitiesListViewModel
            {
                Cities = await this.citiesService.GetAllAsync<CityViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult AddCity()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCity(CityInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.citiesService.AddAsync(input.Name);

            return this.RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCity(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.Cities)
            {
                return this.RedirectToAction("Index");
            }

            await this.citiesService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
