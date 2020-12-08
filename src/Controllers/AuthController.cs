using Aiursoft.Blog.Models;
using Aiursoft.Gateway.SDK.Models.ForApps.AddressModels;
using Aiursoft.Handler.Attributes;
using Aiursoft.Identity.Attributes;
using Aiursoft.Identity.Services;
using Aiursoft.WebTools;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Aiursoft.Blog.Controllers
{
    [LimitPerMin]
    public class AuthController : Controller
    {
        private readonly AuthService<BlogUser> _authService;
        private readonly UserManager<BlogUser> _userManager;
        private readonly SignInManager<BlogUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthController(
            AuthService<BlogUser> authService,
            UserManager<BlogUser> userManager,
            SignInManager<BlogUser> signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            _authService = authService;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [AiurForceAuth(preferController: "", preferAction: "", justTry: false, register: false)]
        public IActionResult GoAuth()
        {
            return RedirectToAction("Index", "Home");
        }

        [AiurForceAuth(preferController: "", preferAction: "", justTry: false, register: true)]
        public IActionResult GoRegister()
        {
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> AuthResult(AuthResultAddressModel model)
        {
            var user = await _authService.AuthApp(model);
            this.SetClientLang(user.PreferedLanguage);
            if (!await ThisSiteHasOwnerRole())
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = Consts.OwnerRoleName });
            }
            if (!await ThisSiteHasOwner())
            {
                await _userManager.AddToRoleAsync(user, Consts.OwnerRoleName);
                await _signInManager.SignInAsync(user, true);
            }
            return Redirect(model.State);
        }

        private async Task<bool> ThisSiteHasOwnerRole()
        {
            var hasOwnerRole = await _roleManager.RoleExistsAsync(Consts.OwnerRoleName);
            return hasOwnerRole;
        }

        private async Task<bool> ThisSiteHasOwner()
        {
            var owners = await _userManager.GetUsersInRoleAsync(Consts.OwnerRoleName);
            return owners.Any();
        }
    }
}