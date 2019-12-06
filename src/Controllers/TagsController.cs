using Aiursoft.Blog.Models.TagsViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Aiursoft.Blog.Controllers
{
    public class TagsController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexViewModel();
            return View(model);
        }
    }
}
