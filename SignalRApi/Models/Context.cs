using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace SignalRApi.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {
            
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
