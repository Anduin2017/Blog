using Aiursoft.Blog.Models.SharedViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aiursoft.Blog.Models.MeViewModels
{
    public class MeViewModel :  LayoutViewModel
    {
        public int SubActivePanel { get; set; }
        public MeViewModel()
        {
            ActivePanel = 3;
        }
    }
}
