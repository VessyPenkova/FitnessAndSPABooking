﻿using FitnessAndSPABooking.Core.Contracts;
using FitnessAndSPABooking.Infrastructure.Data.Blog;
using FitnessAndSPABooking.Infrastructure.Data.Common.Pignation;
using Microsoft.AspNetCore.Mvc;

namespace FitnessAndSPABooking.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogsService blogsService;

        public BlogController(IBlogsService _blogsService)
        {
            blogsService = _blogsService;
        }

        public async Task<IActionResult> Index(
            int? sortId,
            int? pageNumber) // blogPostId
        {
            if (sortId != null)
            {
                var blogPost = await this.blogsSerivice
                    .GetByIdAsync<BlogViewModel>(sortId.Value);
                if (blogPost == null)
                {
                    return new StatusCodeResult(404);
                }
            }

            this.ViewData["CurrentSort"] = sortId;

            int pageSize = PageSizesConstants.BlogPosts;
            var pageIndex = pageNumber ?? 1;

            var blogPosts = await this.blogPostsService
                .GetAllWithPagingAsync<BlogPostViewModel>(sortId, pageSize, pageIndex);
            var blogPostsList = blogPosts.ToList();

            var count = await this.blogPostsService.GetCountForPaginationAsync();

            var viewModel = new BlogPostsPaginatedListViewModel
            {
                BlogPosts = new PaginatedList<BlogPostViewModel>(blogPostsList, count, pageIndex, pageSize),
            };

            return this.View(viewModel);
        }
    }
}
