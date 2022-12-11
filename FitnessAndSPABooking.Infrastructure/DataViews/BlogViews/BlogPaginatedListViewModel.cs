using FitnessAndSPABooking.Infrastructure.Data.Common.Pignation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.BlogViews
{
    public  class BlogPaginatedListViewModel
    {
        public PaginatedList<BlogViewModel> Blog { get; set; }
    }
}
