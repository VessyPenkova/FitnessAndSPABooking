using Microsoft.AspNetCore.Mvc;

namespace FitnessAndSPABooking.Areas.Administration.Controllers
{
    public class DashboardController : AdministartionController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
