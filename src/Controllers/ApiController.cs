using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aiursoft.Pylon.Attributes;
using Microsoft.AspNetCore.Identity;
using Aiursoft.Blog.Models;

namespace Aiursoft.Blog.Controllers
{
    [APIExpHandler]
    [APIModelStateChecker]
    public class ApiController : Controller
    {
        private readonly UserManager<BlogUser> _userManager;
        public ApiController(UserManager<BlogUser> userManager)
        {
            _userManager = userManager;
        }
        [Route("/manifest.json")]
        public async Task<IActionResult> Manifest()
        {
            var owner = (await _userManager.GetUsersInRoleAsync(Consts.OwnerRoleName))
                .First();
            var model = new ManifestModel
            {
                ShortName = owner.NickName,
                Name = owner.NickName + "'s Blog",
                StartUrl = "/",
                Icons = new List<ManifestIcon>()
                {
                    new ManifestIcon
                    {
                        Src = "",
                        Sizes = "48x48",
                        Type = "image/png"
                    }
                },
                BackgroundColor = "#2391D3",
                ThemeColor = "#2391D3",
                Display = "standalone",
                Orientation = "portrait"
            };
            return Json(model);
        }
    }
}
