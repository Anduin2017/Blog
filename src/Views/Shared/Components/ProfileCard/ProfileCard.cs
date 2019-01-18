using Aiursoft.Blog.Data;
using Aiursoft.Blog.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aiursoft.Blog.Views.Shared.Components.ProfileCard
{

    public class ProfileCard : ViewComponent
    {
        private readonly BlogDbContext _dbContext;
        private readonly UserManager<BlogUser> _userManager;
        public ProfileCard(
            BlogDbContext dbContext,
            UserManager<BlogUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync(UserClaimsPrincipal);
            var model = new ProfileCardViewModel
            {
                NickName = user.NickName,
                Bio = user.Bio
            };
            return View(model);
        }
    }
}