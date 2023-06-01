using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.MemberDashboard
{
    public class _GuideList : ViewComponent
    {
        private readonly IGuideService _guideService;

        public _GuideList(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IViewComponentResult Invoke()
        {
            var guides = _guideService.TGetList();

            return View(guides);
        }
    }
}
