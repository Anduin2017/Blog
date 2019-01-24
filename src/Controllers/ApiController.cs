using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aiursoft.Pylon.Attributes;
using Microsoft.AspNetCore.Identity;
using Aiursoft.Blog.Models;
using Aiursoft.Pylon.Services;

namespace Aiursoft.Blog.Controllers
{
    [APIExpHandler]
    [APIModelStateChecker]
    public class ApiController : Controller
    {
        private readonly UserManager<BlogUser> _userManager;
        private readonly ServiceLocation _serviceLocation;
        public ApiController(
            UserManager<BlogUser> userManager,
            ServiceLocation serviceLocation)
        {
            _userManager = userManager;
            _serviceLocation = serviceLocation;
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
                        Src = _serviceLocation.OSS + "/download/fromkey/" + owner.HeadImgFileKey + ".png?w=48&h=48",
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
