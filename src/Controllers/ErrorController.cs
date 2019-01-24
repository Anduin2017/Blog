using Aiursoft.Blog.Models.ErrorViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aiursoft.Blog.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Code404()
        {
            var model = new Code404ViewModel();
            return View(model);
        }
        public IActionResult ServerException()
        {
            return View();
        }
    }
}
