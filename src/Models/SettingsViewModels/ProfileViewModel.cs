namespace Aiursoft.Blog.Models.SettingsViewModels
{
    public class ProfileViewModel : SettingsViewModel
    {
        public ProfileViewModel()
        {
            Title = "Profile Settings";
            Description = "The profile settings for your blog.";
            SubActivePanel = 2;
        }
    }
}
