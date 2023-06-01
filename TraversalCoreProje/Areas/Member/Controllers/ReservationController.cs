using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TraversalCore.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ReservationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IReservationService _reservationService;
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(IDestinationService destinationService, IReservationService reservationService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = _destinationService.TGetList().Select(x => new SelectListItem
            {
                Text = x.City,
                Value = x.Id.ToString()
            }).ToList();

            ViewBag.Values = values;

            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.AppUserId = 4;
            reservation.Status = "Onay Bekliyor";
            _reservationService.TAdd(reservation);

            return RedirectToAction(nameof(MyActiveReservations));
        }

        [HttpGet]
        public async Task<IActionResult> MyApprovalReservations()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationService.GetListWithReservationsByWaitApproval(values.Id);
            return View(valuesList);
        }

        [HttpGet]
        public async Task<IActionResult> MyActiveReservations()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationService.GetListWithReservationsByApproved(values.Id);
            return View(valuesList);
        }
        [HttpGet]
        public async Task<IActionResult> MyOldReservations()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationService.GetListOldReservations(values.Id);
            return View(valuesList);
        }
    }
}
