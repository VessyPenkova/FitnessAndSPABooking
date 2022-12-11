using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.CategoriesViews
{
    public class CategorySimpleViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int SalonsCount { get; set; }
    }
}
