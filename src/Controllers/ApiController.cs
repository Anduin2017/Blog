using Aiursoft.Blog.Models;
using Aiursoft.Handler.Attributes;
using Aiursoft.Probe.SDK.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Aiursoft.Blog.Controllers
{
    [LimitPerMin]
    [APIExpHandler]
    [APIModelStateChecker]
    public class ApiController : Controller
    {
        private readonly UserManager<BlogUser> _userManager;
        private readonly ProbeLocator _probeLocator;
        public ApiController(
            UserManager<BlogUser> userManager,
            ProbeLocator probeLocator)
        {
            _userManager = userManager;
            _probeLocator = probeLocator;
        }

        [Route("/manifest.json")]
        public async Task<IActionResult> Manifest()
        {
            var owner = (await _userManager.GetUsersInRoleAsync(Consts.OwnerRoleName))
                .First();
            var descriptionAttribute = Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyDescriptionAttribute>().Description;
            var model = new ManifestModel
            {
                ShortName = owner.NickName,
                Name = owner.NickName + "'s Blog",
                Description = descriptionAttribute,
                StartUrl = "/",
                Icons = new List<ManifestIcon>()
                {
                    new ManifestIcon
                    {
                        Src = _probeLocator.GetProbeOpenAddress(owner.IconFilePath) + "?w=48&square=true",
                        Sizes = "48x48",
                        Type = "image/png"
                    },
                    new ManifestIcon
                    {
                        Src = _probeLocator.GetProbeOpenAddress(owner.IconFilePath) + ".png?w=72&square=true",
                        Sizes = "72x72",
                        Type = "image/png"
                    },
                    new ManifestIcon
                    {
                        Src = _probeLocator.GetProbeOpenAddress(owner.IconFilePath) + ".png?w=144&square=true",
                        Sizes = "144x144",
                        Type = "image/png"
                    },
                    new ManifestIcon
                    {
                        Src = _probeLocator.GetProbeOpenAddress( owner.IconFilePath) + ".png?w=240&square=true",
                        Sizes = "240x240",
                        Type = "image/png"
                    },
                    new ManifestIcon
                    {
                        Src = _probeLocator.GetProbeOpenAddress(owner.IconFilePath) + ".png?w=512&square=true",
                        Sizes = "512x512",
                        Type = "image/png"
                    }
                },
                BackgroundColor = "#3097D1",
                ThemeColor = "#3097D1",
                Display = "standalone",
                Orientation = "portrait"
            };
            return Json(model);
        }
    }
}
