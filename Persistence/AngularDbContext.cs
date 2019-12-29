using angular_dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace angular_dotnet.Persistence
{
    public class AngularDbContext : DbContext
    {
        public AngularDbContext(DbContextOptions<AngularDbContext> options)
            : base(options)
        {
            // options.UseMySql()
        }
        public DbSet<Make> Makes { get; set; }
    }
}