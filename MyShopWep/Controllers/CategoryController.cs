using Microsoft.EntityFrameworkCore;
using MyShopWep.Models;

namespace MyShopWep.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categoriy { get; set; } 
    }
}
