using FirstGroup_1.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstGroup_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }



        // Define your DbSets here
        // public DbSet<YourEntity> YourEntities { get; set; }
        public DbSet<Employee> Employees { get; set; }


       
    }
}
