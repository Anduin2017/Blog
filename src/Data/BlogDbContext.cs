using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Aiursoft.Blog.Data
{
    public class BlogDbContext : IdentityDbContext<BlogUser>
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }
    }
}
