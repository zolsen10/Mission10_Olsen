using Microsoft.EntityFrameworkCore;

namespace Mission10API.Data
{
    public class BowlingLeagueContext : DbContext
    {
        public BowlingLeagueContext()
        {

        }

        public BowlingLeagueContext(DbContextOptions<BowlingLeagueContext> options) : base(options) { }

        public virtual DbSet<Bowler> Bowlers { get; set; }

        public virtual DbSet<Team> Teams { get; set; }


    }


}
