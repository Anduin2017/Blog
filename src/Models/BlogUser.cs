using System;
using Aiursoft.Pylon.Models;

namespace Aiursoft.Blog.Models
{
    public class BlogUser : AiurUserBase
    {
        public bool IsWebSiteOwner { get; set; }
    }
}