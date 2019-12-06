using Microsoft.AspNetCore.Mvc;

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
