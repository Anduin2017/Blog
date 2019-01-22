using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aiursoft.Blog.Models.MeViewModels
{
    public class AppsViewModel : MeViewModel
    {
        public AppsViewModel()
        {
            Title = "My Apps";
            Description = "About me apps page.";
            SubActivePanel = 3;
        }
    }
}
