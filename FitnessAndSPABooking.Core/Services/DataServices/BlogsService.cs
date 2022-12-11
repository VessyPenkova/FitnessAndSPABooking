using FitnessAndSPABooking.Core.Contracts;
using FitnessAndSPABooking.Core.Services.MapperSrvices;
using FitnessAndSPABooking.Infrastructure.Data.Common.ContractsRepositories;
using FitnessAndSPABooking.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessAndSPABooking.Core.Services.DataServices
{
    public class BlogsService :IBlogsService
    {
        private readonly IDeletableEntityRepository<Blog> blogsRepository;

        public BlogsService(IDeletableEntityRepository<Blog> _blossRepository)
        {
            blogsRepository = _blossRepository;
        }

        public async Task<IEnumerable<T>> GetAllAsync<T>(int? count = null)
        {
            IQueryable<Blog> query =
                blogsRepository
                .All()
                .OrderByDescending(x => x.CreatedOn);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return await query.To<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllWithPagingAsync<T>(
            int? sortId,
            int pageSize,
            int pageIndex)
        {
            IQueryable<Blog> query =
                blogsRepository
                .AllAsNoTracking()
                .OrderByDescending(x => x.CreatedOn);

            if (sortId != null)
            {
                query = query
                    .Where(x => x.Id == sortId);
            }

            return await query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize).To<T>().ToListAsync();
        }

        public async Task<int> GetCountForPaginationAsync()
        {
            return await blogsRepository
                .AllAsNoTracking()
                .CountAsync();
        }

        public async Task<T> GetByIdAsync<T>(int id)
        {
            var blogPost =
                await this.blogsRepository
                .All()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefaultAsync();
            return blogPost;
        }

        public async Task AddAsync(string title, string content, string author, string imageUrl)
        {
            await this.blogsRepository.AddAsync(new Blog
            {
                Title = title,
                Content = content,
                Author = author,
                ImageUrl = imageUrl,
            });
            await blogsRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var blogPost =
                await this.blogsRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            this.blogsRepository.Delete(blogPost);
            await this.blogsRepository.SaveChangesAsync();
        }
    }
}
