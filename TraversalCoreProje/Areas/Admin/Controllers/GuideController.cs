﻿using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Guide")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var values = _guideService.TGetList();
            return View(values);
        }
        [Route("AddGuide")]

        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            GuideValidator validationRules = new GuideValidator();

            ValidationResult result = validationRules.Validate(guide);

            if (result.IsValid)
            {
                _guideService.TAdd(guide);

                return RedirectToAction("Index", "Guide", new { area = "Admin" });
            }

            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(guide);
            }

        }
        [Route("EditGuide/{id}")]

        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var value = _guideService.TGetById(id);

            return View(value);
        }

        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            _guideService.TUpdate(guide);

            return RedirectToAction("Index", "Guide", new { area = "Admin" });

        }
        [Route("ChangeToTrue/{id}")]

        [HttpGet]
        public IActionResult ChangeToTrue(int id)
        {

            _guideService.TChangeToTrueByGuideId(id);

            return RedirectToAction("Index", "Guide", new { area = "Admin" });

        }
        [Route("ChangeToFalse/{id}")]

        [HttpGet]
        public IActionResult ChangeToFalse(int id)
        {
            _guideService.TChangeToFalseByGuideId(id);


            return RedirectToAction("Index", "Guide", new { area = "Admin" });

        }
    }
}
