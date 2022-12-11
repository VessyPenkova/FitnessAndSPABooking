using Microsoft.AspNetCore.Mvc;

namespace FitnessAndSPABooking.Areas.Manager.Controllers
{
    public class DashboardController : ManagerBaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
