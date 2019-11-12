using Aiursoft.Blog.Data;
using Aiursoft.Blog.Models;
using Aiursoft.Pylon;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Aiursoft.Blog
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BlogDbContext>(options =>
                options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<BlogUser, IdentityRole>()
                .AddEntityFrameworkStores<BlogDbContext>()
                .AddDefaultTokenProviders();
            services.AddAiurMvc();
            services.AddAiurDependencies<BlogUser>("Blog");
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseAiurUserHandler(env.IsDevelopment());
            app.UseAiursoftDefault();
        }
    }
}
