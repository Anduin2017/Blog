using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aiursoft.Blog.Models.SharedViewModels
{
    public class LayoutViewModel
    {
        public LayoutViewModel() { }

        public string Title { get; set; }
        public int ActivePanel { get; set; }
        public string Description { get; set; }
    }
}
