using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCore.Areas.Admin.Models;

namespace TraversalCore.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    [Route("Admin/Announcement")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        [Route("Index")]

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDTO>>(_announcementService.TGetList());
            //    var list = _announcementService.TGetList()
            //    .Select(x => new AnnouncementListViewModel
            //    {
            //        Id = x.Id,
            //        Title = x.Title,
            //        Content = x.Content
            //    }).ToList();

            return View(values);
        }

        [Route("AddAnnouncement")]
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [Route("AddAnnouncement")]
        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDTO model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TAdd(new Announcement()
                {
                    Content = model.Content,
                    Title = model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    Status = true
                });
                return RedirectToAction("Index", "Announcement", new { area = "Admin" });
            }
            return View(model);
        }

        [HttpGet]
        [Route("DeleteAnnouncement/{id}")]
        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.TGetById(id);
            _announcementService.TDelete(values);

            return RedirectToAction("Index", "Announcement", new { area = "Admin" });

        }

        [HttpGet]
        [Route("UpdateAnnouncement/{id}")]
        public IActionResult UpdateAnnouncement(int id)
        {
            var value = _mapper.Map<AnnouncementUpdateDTO>(_announcementService.TGetById(id));

            return View(value);
        }

        [HttpPost]
        [Route("UpdateAnnouncement/{id}")]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {
                    Id=model.Id,
                    Content = model.Content,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    Status = model.Status,
                    Title = model.Title
                });

                return RedirectToAction("Index", "Announcement", new { area = "Admin" });
            }
            return View(model);

        }
    }
}
