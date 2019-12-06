using Aiursoft.Blog.Models.MeViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Aiursoft.Blog.Controllers
{
    public class MeController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexViewModel();
            return View(model);
        }

        public IActionResult Videos()
        {
            var model = new VideosViewModel();
            return View(model);
        }

        public IActionResult Apps()
        {
            var model = new AppsViewModel();
            return View(model);
        }
    }
}
