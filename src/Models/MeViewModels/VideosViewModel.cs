using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aiursoft.Blog.Models.MeViewModels
{
    public class VideosViewModel : MeViewModel
    {
        public VideosViewModel()
        {
            Title = "Videos";
            Description = "About me videos page.";
            SubActivePanel = 2;
        }
    }
}
