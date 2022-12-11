using Microsoft.AspNetCore.Mvc;
using static FitnessAndSPABooking.Areas.Administration.Controllers.AdministartionController;

namespace FitnessAndSPABooking.Areas.Administration.Controllers
{
    public class BookingsController : AdministrationController
    {
        private readonly IAppointmentsService appointmentsService;

        public AppointmentsController(IAppointmentsService appointmentsService)
        {
            this.appointmentsService = appointmentsService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new AppointmentsListViewModel
            {
                Appointments =
                    await this.appointmentsService.GetAllAsync<AppointmentViewModel>(),
            };
            return this.View(viewModel);
        }
    }
    }
}
