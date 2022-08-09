using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using WebApiCore.Data.Models;

namespace WebApiCore.Data.Configurations
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(new List<Customer>()
            {
                new Customer { Id = 1, Name = "Nick", Email = "Nick@mail.com", BirthDate = new DateTime(2000, 01, 01) },
                new Customer { Id = 2, Name = "Tom", Email = "Tom@mail.com", BirthDate = new DateTime(1980, 5, 11) }
            });
        }
    }
}