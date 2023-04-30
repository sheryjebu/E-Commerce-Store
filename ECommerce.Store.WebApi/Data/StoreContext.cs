using System;
using System.Collections.Generic;
using ECommerce.Store.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Store.WebApi.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }// resembles product table
    }
}

