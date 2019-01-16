using Aiursoft.Blog.Models.SharedViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aiursoft.Blog.Models.HomeViewModels
{
    public class HomeViewModel : LayoutViewModel
    {
        public HomeViewModel()
        {
            ActivePanel = 1;
        }
    }
}
