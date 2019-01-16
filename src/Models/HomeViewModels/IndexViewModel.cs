using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aiursoft.Blog.Models.HomeViewModels
{
    public class IndexViewModel : HomeViewModel
    {
        public IndexViewModel()
        {
            Title = "Home";
            Description = string.Empty;
        }
    }
}
