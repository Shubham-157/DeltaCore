using DeltaCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DeltaCore.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options):base(options) 
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
