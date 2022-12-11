using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.CategoriesViews
{
    public class CategoriesSimpleListViewModel
    {
        public IEnumerable<CategorySimpleViewModel> Categories { get; set; }
    }
}
