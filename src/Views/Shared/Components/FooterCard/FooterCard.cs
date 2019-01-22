using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aiursoft.Blog.Views.Shared.Components.FooterCard
{
    public class FooterCard : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
