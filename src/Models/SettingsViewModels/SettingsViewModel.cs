using Aiursoft.Blog.Models.SharedViewModels;

namespace Aiursoft.Blog.Models.SettingsViewModels
{
    public class SettingsViewModel : LayoutViewModel
    {
        public int SubActivePanel { get; set; }
        public SettingsViewModel()
        {
            ActivePanel = 0;
        }
    }
}
