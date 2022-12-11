using FitnessAndSPABooking.Core.Contracts;
using FitnessAndSPABooking.Infrastructure.Data.Categories;
using FitnessAndSPABooking.Infrastructure.Data.Common.Pignation;
using FitnessAndSPABooking.Infrastructure.Data.Fitnesses;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAndSPABooking.Controllers
{
    public class FitnessesController : Controller
    {
        private readonly IFitnessesService fitnessesService;
        private readonly ICategoriesService categoriesService;

        public FitnessesController(
            IFitnessesService _fitnessesService,
            ICategoriesService categoriesService)
        {
            fitnessesService = _fitnessesService;
            this.categoriesService = categoriesService;
        }

        public async Task<IActionResult> Index(
            int? sortId, // categoryId
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            if (sortId != null)
            {
                var category = await this.categoriesService
                    .GetByIdAsync<CategorySimpleViewModel>(sortId.Value);
                if (category == null)
                {
                    return new StatusCodeResult(404);
                }

                this.ViewData["CategoryName"] = category.Name;
            }

            this.ViewData["CurrentSort"] = sortId;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            this.ViewData["CurrentFilter"] = searchString;

            int pageSize = PageSizesConstants.Salons;
            var pageIndex = pageNumber ?? 1;

            var fitnesses = await fitnessesService
                .GetAllWithSortingFilteringAndPagingAsync<FitnessViewModel>(
                    searchString, sortId, pageSize, pageIndex);
            var fitnesssList = fitnesses.ToList();

            var count = await this.fitnessesService
                .GetCountForPaginationAsync(searchString, sortId);

            var viewModel = new FitnessesPaginatedListViewModel
            {
                Fitnesses = new PaginatedList<FitnessViewModel>(fitnesssList, count, pageIndex, pageSize),
            };

            return this.View(viewModel);
        }

        public async Task<IActionResult> Details(string id)
        {
            var viewModel = await this.fitnessesService.GetByIdAsync<FitnessWithServicesViewModel>(id);

            if (viewModel == null)
            {
                return new StatusCodeResult(404);
            }

            return this.View(viewModel);
        }
    }
}
