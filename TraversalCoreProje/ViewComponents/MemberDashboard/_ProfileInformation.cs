using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.MemberDashboard
{
    public class _ProfileInformation : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileInformation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = user.Name + " " + user.Surname;
            ViewBag.userPhone = user.PhoneNumber;
            ViewBag.eMail = user.Email;
            return View();
        }
    }
}
