using System.Collections.Generic;
using System.Linq;
using WebApiCore.Data.Context;
using WebApiCore.Data.Models;

namespace WebApiCore.Data.Repository
{
    public class WeatherRepository : IRepository<CurrentWeather>
    {
        public readonly WebApiCoreContext Context;

        public IEnumerable<CurrentWeather> All => Context.Weathers.ToList();

        public WeatherRepository(WebApiCoreContext context)
        {
            Context = context;
        }

        public void Add(CurrentWeather entity)
        {
            Context.Weathers.Add(entity);
        }

        public void Delete(CurrentWeather entity)
        {
            Context.Weathers.Remove(entity);
            Context.SaveChanges();
        }

        public CurrentWeather FindById(int id)
        {
            return Context.Weathers.FirstOrDefault(e => e.Id == id);
        }

        public void Update(CurrentWeather entity)
        {
            Context.Weathers.Update(entity);
            Context.SaveChanges();
        }
    }
}
