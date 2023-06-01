using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
    }
}
