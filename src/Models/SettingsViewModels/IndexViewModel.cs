using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aiursoft.Blog.Models.SettingsViewModels
{
    public class IndexViewModel : SettingsViewModel
    {
        public IndexViewModel()
        {
            Title = "Settings Home";
            Description = "The main settings page for blog.";
            SubActivePanel = 1;
        }
    }
}
