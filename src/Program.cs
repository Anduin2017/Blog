using Aiursoft.Blog.Data;
using Aiursoft.SDK;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using static Aiursoft.WebTools.Extends;

namespace Aiursoft.Blog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            App<Startup>(args).Update<BlogDbContext>().Run();
        }

        // For EF
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return BareApp<Startup>(args);
        }
    }
}
