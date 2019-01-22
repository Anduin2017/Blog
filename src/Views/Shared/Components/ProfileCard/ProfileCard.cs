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

        public IViewComponentResult Invoke(BlogUser owner)
        {
            var model = new ProfileCardViewModel
            {
                NickName = owner.NickName,
                Bio = owner.Bio
            };
            return View(model);
        }
    }
}