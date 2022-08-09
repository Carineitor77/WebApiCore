using Microsoft.EntityFrameworkCore;
using WebApiCore.Data.Configurations;
using WebApiCore.Data.Models;

namespace WebApiCore.Data.Context
{
    public class WebApiCoreContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CurrentWeather> Weathers { get; set; }


        public WebApiCoreContext(DbContextOptions<WebApiCoreContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new WeatherConfiguration());
        }
    }
}
