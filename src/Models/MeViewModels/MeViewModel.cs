using Aiursoft.Blog.Models.SharedViewModels;

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
