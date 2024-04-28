using System;
using Microsoft.EntityFrameworkCore;
using WDC.Products.Data.Entities;

namespace WDC.Products.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }

    }
}

