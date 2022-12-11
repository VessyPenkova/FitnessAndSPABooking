using Microsoft.AspNetCore.Mvc;
using FitnessAndSPABooking.Controllers;
using FitnessAndSPABooking.Core.Constrains;
using Microsoft.AspNetCore.Authorization;


namespace FitnessAndSPABooking.Areas.Manager.Controllers
{
   
    [Authorize(Roles = GlobalConstants.SalonManagerRoleName)]
    [Area("Manager")]
    public class ManagerBaseController : BaseController
    {
    }
}
