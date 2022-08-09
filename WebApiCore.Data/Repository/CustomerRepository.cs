using System.Collections.Generic;
using System.Linq;
using WebApiCore.Data.Context;
using WebApiCore.Data.Models;
using System;

namespace WebApiCore.Data.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly WebApiCoreContext Context;

        public IEnumerable<Customer> All => Context.Customers.ToList();

        public CustomerRepository(WebApiCoreContext context)
        {
            Context = context;
        }

        public void Add(Customer entity)
        {
            Context.Customers.Add(entity);
        }

        public void Delete(Customer entity)
        {
            Context.Customers.Remove(entity);
            Context.SaveChanges();
        }

        public Customer FindById(int id)
        {
            return Context.Customers.FirstOrDefault(e => e.Id == id);
        }
        public void Update(Customer entity)
        {
            Context.Customers.Update(entity);
            Context.SaveChanges();
        }
    }
}
