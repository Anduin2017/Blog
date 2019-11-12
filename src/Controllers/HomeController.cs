using Aiursoft.Blog.Models;
using Aiursoft.Blog.Models.HomeViewModels;
using Aiursoft.Pylon;
using Aiursoft.Pylon.Attributes;
using Aiursoft.Pylon.Models;
using Aiursoft.Pylon.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Aiursoft.Blog.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<BlogUser> _signInManager;
        private readonly ILogger _logger;
        private readonly ServiceLocation _serviceLocation;

        public HomeController(
            SignInManager<BlogUser> signInManager,
            ILoggerFactory loggerFactory,
            ServiceLocation serviceLocation)
        {
            _signInManager = signInManager;
            _logger = loggerFactory.CreateLogger<HomeController>();
            _serviceLocation = serviceLocation;
        }

        [AiurForceAuth("", "", true)]
        public IActionResult Index()
        {
            var model = new IndexViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation(4, "User logged out.");
            return this.SignOutRootServer(_serviceLocation.Gateway, new AiurUrl(string.Empty, "Home", nameof(Index), new { }));
        }
    }
}
