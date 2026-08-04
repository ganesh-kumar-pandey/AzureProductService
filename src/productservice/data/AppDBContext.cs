using System;
using Microsoft.EntityFrameworkCore;
using productservice.models;


namespace productservice.data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Product> products { get; set; }

    }
}