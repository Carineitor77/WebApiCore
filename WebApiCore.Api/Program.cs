using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WebApiCore.Api
{
    class Program
    {
        static void Main(string[] args)
        { 
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}