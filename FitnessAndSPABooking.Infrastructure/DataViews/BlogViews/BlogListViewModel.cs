using FitnessAndSPABooking.Infrastructure.Data.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.BlogViews
{
    public  class BlogListViewModel
    {
        public IEnumerable<BlogViewModel> Blog { get; set; }
    }
}
