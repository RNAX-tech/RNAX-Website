using Microsoft.EntityFrameworkCore;


namespace RNAX_web.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public System.Data.Entity.DbSet<User> Users { get; set; }

        
    }
}
