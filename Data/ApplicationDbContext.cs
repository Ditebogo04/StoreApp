using Microsoft.EntityFrameworkCore;

namespace StoreApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Models.Entities.AppUser> Users { get; set; }
    }
}
