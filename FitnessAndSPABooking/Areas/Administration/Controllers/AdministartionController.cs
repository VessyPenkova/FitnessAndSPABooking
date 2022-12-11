using FitnessAndSPABooking.Controllers;
using FitnessAndSPABooking.Core.Constrains;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace FitnessAndSPABooking.Areas.Administration.Controllers
{
    public class AdministartionController : BaseController
    {
         

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
}
