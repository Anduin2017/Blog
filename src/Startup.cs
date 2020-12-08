using Aiursoft.Archon.SDK.Services;
using Aiursoft.Blog.Data;
using Aiursoft.Blog.Models;
using Aiursoft.Identity;
using Aiursoft.SDK;
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
        private readonly IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            AppsContainer.CurrentAppId = configuration["BlogAppId"];
            AppsContainer.CurrentAppSecret = configuration["BlogAppSecret"];
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextWithCache<BlogDbContext>(Configuration.GetConnectionString("DatabaseConnection"));

            services.AddIdentity<BlogUser, IdentityRole>()
                .AddEntityFrameworkStores<BlogDbContext>()
                .AddDefaultTokenProviders();
            services.AddAiurMvc();
            services.AddAiursoftIdentity<BlogUser>(
                archonEndpoint: Configuration.GetConnectionString("ArchonConnection"),
                observerEndpoint: Configuration.GetConnectionString("ObserverConnection"),
                probeEndpoint: Configuration.GetConnectionString("ProbeConnection"),
                gateEndpoint: Configuration.GetConnectionString("GatewayConnection"));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseAiurUserHandler(env.IsDevelopment());
            app.UseAiursoftDefault();
        }
    }
}
