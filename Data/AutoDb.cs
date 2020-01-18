using AutoShop.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoShop.Data
{
    public class AutoDb : DbContext
    {
        
        public AutoDb(DbContextOptions<AutoDb> options) : base(options){ }
        public DbSet<Customer> Customers { get; set; }
    }
}
