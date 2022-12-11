using FitnessAndSPABooking.Core.Constrains;
using FitnessAndSPABooking.Core.Contracts;
using FitnessAndSPABooking.Infrastructure.Data.BlogViews;
using Microsoft.AspNetCore.Mvc;
using static FitnessAndSPABooking.Areas.Administration.Controllers.AdministartionController;

namespace FitnessAndSPABooking.Areas.Administration.Controllers
{
    public class BlogController : AdministrationController
    {
        private readonly IBlogsService blogsService;
        public BlogController(IBlogsService _blogPostsService)


        {
            blogsService = _blogPostsService;
           
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new BlogListViewModel
            {
                BlogsPosts = await this.blogService.GetAllAsync<BlogViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult AddBlogPost()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBlogPost(BlogInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            string imageUrl;
            try
            {
                imageUrl = await this.cloudinaryService.UploadPictureAsync(input.Image, input.Title);
            }
            catch (System.Exception)
            {
                // In case of missing Cloudinary configuration from appsettings.json
                imageUrl = GlobalConstants.Images.CloudinaryMissing;
            }

            await this.blogPostsService.AddAsync(input.Title, input.Content, input.Author, imageUrl);
            return this.RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteBlogPost(int id)
        {
            if (id <= GlobalConstants.SeededDataCounts.BlogPosts)
            {
                return this.RedirectToAction("Index");
            }

            await this.blogPostsService.DeleteAsync(id);

            return this.RedirectToAction("Index");
        }
    }
}
