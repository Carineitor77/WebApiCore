using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using WebApiCore.Data.Models;

namespace WebApiCore.Data.Configurations
{
    internal class WeatherConfiguration : IEntityTypeConfiguration<CurrentWeather>
    {
        public void Configure(EntityTypeBuilder<CurrentWeather> builder)
        {
            builder.HasData(new List<CurrentWeather>()
            {
                new CurrentWeather { Id = 1, Status = "Cloud", MinTemp = 20, MaxTemp = 22 },
                new CurrentWeather { Id = 2, Status = "Clear", MinTemp = 18, MaxTemp = 20 }
            });
        }
    }
}