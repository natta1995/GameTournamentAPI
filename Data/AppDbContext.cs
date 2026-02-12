using GameTournamentAPI.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;




namespace GameTournamentAPI.Data
{
  public class AppDbContext : DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Tournament> Tournaments => Set<Tournament>();
    }
}
