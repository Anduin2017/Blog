using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aiursoft.Blog.Models.TagsViewModels
{
    public class IndexViewModel : TagsViewModel
    {
        public IndexViewModel()
        {
            Title = "Tags";
            Description = string.Empty;
        }
    }
}
