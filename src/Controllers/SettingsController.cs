using Aiursoft.Blog.Models.SettingsViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aiursoft.Blog.Controllers
{
    [Authorize(Roles = Consts.OwnerRoleName)]
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexViewModel();
            return View(model);
        }

        public IActionResult Profile()
        {
            var model = new ProfileViewModel();
            return View(model);
        }
    }
}
