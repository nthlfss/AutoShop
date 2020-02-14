using AutoShop.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoShop.Data
{
    public class AutoDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Repair> Repairs { get; set; }

        public AutoDbContext(DbContextOptions<AutoDbContext> options) : base(options)
        { 
        }
    }
}
