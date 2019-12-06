namespace Aiursoft.Blog.Models.SharedViewModels
{
    public class LayoutViewModel
    {
        public LayoutViewModel() { }

        public string Title { get; set; }
        public int ActivePanel { get; set; }
        public string Description { get; set; }
        public BlogUser Owner { get; set; }
    }
}
