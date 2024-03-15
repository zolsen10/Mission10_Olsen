using Microsoft.EntityFrameworkCore;

namespace Mission10API.Data
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _context;

        public EFBowlingRepository(BowlingLeagueContext temp) { 
            _context = temp;
        }

        public IEnumerable<Bowler> Bowlers => _context.Bowlers.Include(x => x.Team);

        public IEnumerable<Team> Teams => _context.Teams;
    }
}
