using FitnessAndSPABooking.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessAndSPABooking.Infrastructure.Data.CategoriesViews
{
    public class CategoryViewModel 
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public int SalonsCount { get; set; }

        public int ServicesCount { get; set; }
    }
}
