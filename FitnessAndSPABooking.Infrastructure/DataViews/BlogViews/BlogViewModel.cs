

namespace FitnessAndSPABooking.Infrastructure.Data.BlogViews
{
    public  class BlogViewModel 
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Author { get; set; } = null!;

        public string Content { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

    }
}
