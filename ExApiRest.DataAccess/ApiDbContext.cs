using ExApiRest.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExApiRest.DataAccess
{
    public class ApiDbContext : DbContext
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
