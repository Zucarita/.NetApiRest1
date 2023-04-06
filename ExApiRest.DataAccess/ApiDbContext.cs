using ExApiRest.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExApiRest.DataAccess
{
    public class ApiDbContext : IdentityDbContext
    {
        public DbSet<FootballTeam> Teams { get; set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Entity>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
