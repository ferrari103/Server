using Microsoft.EntityFrameworkCore;
namespace Server.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<EventItem> Events { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }
 
        
    }
}