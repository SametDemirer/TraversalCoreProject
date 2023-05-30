using BusinessLayer.Abstract;
using EntityLayer.Concrete;
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

        public ReservationController(IDestinationService destinationService, IReservationService reservationService)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
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
        public IActionResult MyActiveReservations()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MyOldReservation()
        {
            return View();
        }
    }
}
