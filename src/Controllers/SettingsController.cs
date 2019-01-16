using Aiursoft.Blog.Models.SettingsViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
